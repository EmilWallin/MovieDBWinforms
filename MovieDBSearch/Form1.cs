namespace MovieDBSearch
{
    public partial class formMovieSearch : Form
    {
        private MovieSearch mSearch = new MovieSearch();
        private System.Windows.Forms.Timer? timer;

        private bool isEditingText = false;
        private string prevSearch = "";

        //Movielist and latest retrieved searchresults
        private List<Movie> movieList = new List<Movie>();
        private SearchResult? currentResult;
        private GenreResult genres = new();

        private string? currentHomepage = "";

        public formMovieSearch()
        {
            InitializeComponent();

            FetchGenres();

            linkHomepage.Text = "";

            //Initialize timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(SearchMovies);
        }

        private async void FetchGenres()
        {
            var res = await mSearch.FetchGenres();
            genres = res;
        }

        #region Movie Search Logic
        private void radioTitle_CheckedChanged(object sender, EventArgs e)
        {
            SearchMovies(sender, e);
        }
        //Text search changed. Checks for empy text and calls appropriate methods
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            isEditingText = true;

            if (string.IsNullOrEmpty(textBoxSearch.Text) || prevSearch == textBoxSearch.Text)
            {
                movieList.Clear();
                UpdateList();
                return;
            }
            prevSearch = textBoxSearch.Text;

            ResetTimer(this, new EventArgs());
        }

        //Resets the timer
        private void ResetTimer(Object obj, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            timer.Start();
        }

        //Checks input, fills movieList and checks returns for null. Calls method to update listbox
        private async void SearchMovies(Object obj, EventArgs e)
        {
            timer.Stop();

            movieList.Clear();
            currentResult = null;

            if (radioId.Checked)
            {
                if (int.TryParse(textBoxSearch.Text, out int idSearch))
                {
                    var result = await mSearch.SearchById(idSearch);
                    if (result != null)
                        movieList.Add(result);
                }
            }
            else
            {
                var result = await mSearch.SearchByTitle(textBoxSearch.Text);
                if (result != null)
                {
                    currentResult = result;
                    movieList.AddRange(currentResult.Results);
                    movieList = movieList.OrderBy(m => m.Title).ToList();
                }
            }
            UpdateList();
        }

        //Updates the listbox. Uses Items.Add instead of datasource to be able to show "No movies found."
        private void UpdateList()
        {
            listBoxResults.Items.Clear();
            if (movieList.Count > 0)
                listBoxResults.Items.AddRange(movieList.Select(m => m.ToString()).ToArray());
            else
                listBoxResults.Items.Add("No movies found.");
        }
        #endregion

        //On index change
        private async void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movieList.Count <= 0) return;

            if (listBoxResults.SelectedIndex != -1)
                await FillInfoBox(movieList[listBoxResults.SelectedIndex]);
        }

        //Fills infobox with info and picture
        private async Task FillInfoBox(Movie movie)
        {
            lblTitle.Text = movie.Title;
            lblRating.Text = $"Rating: {movie.Vote_Average}";
            lblRelease.Text = "Release Date:";
            textBoxSynopsis.Text = movie.Overview;

            if (!string.IsNullOrEmpty(movie.Release_Date))
                lblRelease.Text = $"Release Date: {movie.Release_Date}";

            lblGenre.Text = "";
            if (movie.Genres != null)
            {
                for (int i = 0; i < movie.Genres.Count(); i++)
                {
                    lblGenre.Text += $"{movie.Genres[i].Name}";
                    lblGenre.Text += i != movie.Genres.Count() - 1 ? ", " : "";
                }
            }
            else if (movie.Genre_Ids != null)
            {
                for (int i = 0; i < movie.Genre_Ids.Count(); i++)
                {
                    lblGenre.Text += $"{genres.GetName(movie.Genre_Ids[i])}";
                    lblGenre.Text += i != movie.Genre_Ids.Count() - 1 ? ", " : "";
                }
            }

            if (string.IsNullOrEmpty(movie.Homepage))
            {
                currentHomepage = "";
                linkHomepage.Text = "";
            }
            else
            {
                currentHomepage = movie.Homepage;
                linkHomepage.Text = "Homepage";
            }

            lblRuntime.Text = $"Runtime: {TimeConvert.MinutesToTimeString(movie.Runtime)}";

            lblLanguage.Text = $"Original Language: {movie.Original_Language.ToUpper()}";

            try
            {
                if (picturePoster.Image != null)
                {
                    picturePoster.Image.Dispose();
                    picturePoster.Image = null;
                }
                if (!string.IsNullOrEmpty(movie.Poster_Path))
                {
                    labelNoImage.Text = "";
                    picturePoster.LoadAsync($"https://image.tmdb.org/t/p/w200/{movie.Poster_Path}");
                }
                else
                    labelNoImage.Text = "No Image";
            }
            catch (Exception ex)
            {
                labelNoImage.Text = "No Image";
            }
        }


        //When Homepagelink is clicked
        private void linkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(currentHomepage))
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(currentHomepage) { UseShellExecute = true });
        }
    }
}