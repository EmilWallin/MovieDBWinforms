namespace MovieDBSearch
{
    public partial class formMovieSearch : Form
    {
        //Search object and timer
        private MovieSearch mSearch = new MovieSearch();
        private System.Windows.Forms.Timer? timer;

        //Searchsafes
        private bool isEditingText = false;
        private string prevSearch = "";

        //Movielist and latest retrieved searchresults
        private List<Movie> movieList = new List<Movie>();
        private SearchResult? currentResult;
        private GenreResult genres = new();

        //Current homepage url (as string because Process.Start wants string)
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

        //Gets genres and fillls genres field
        private async void FetchGenres()
        {
            var res = await mSearch.FetchGenres();
            genres = res;
        }


        #region Movie Search Logic
        //Search movie when radiobox is changed
        private void radioTitle_CheckedChanged(object sender, EventArgs e)
        {
            SearchMovies(sender, e);
        }

        //Text search changed. Checks for empty text and calls appropriate methods
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

            if (movieList.Count == 1)               //Fills info box directly if there is only one result (aka searched by id)
                FillInfoBox(movieList[0]);
        }
        #endregion


        //On index change => update info
        private async void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedIndex != -1 && movieList.Count > 0)
                await FillInfoBox(movieList[listBoxResults.SelectedIndex]);
        }

        //When Homepagelink is clicked
        private void linkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentHomepage))
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(currentHomepage) { UseShellExecute = true });
        }

        //Fills infobox with info and picture - bigboy method but it's mostly label.text =...
        private async Task FillInfoBox(Movie movie)
        {
            //Init and always-available fields
            lblTitle.Text = movie.Title;
            lblRelease.Text = $"Release Date: {movie.Release_Date}";
            lblRating.Text = $"Rating: {movie.Vote_Average}";
            lblRelease.Text = "Release Date:";
            lblRuntime.Text = $"Runtime: {TimeConvert.MinutesToTimeString(movie.Runtime)}";
            textBoxSynopsis.Text = movie.Overview;
            lblLanguage.Text = $"Original Language: {movie.Original_Language.ToUpper()}";

            //Genre info
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

            //Homepage link
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

            //Load picture
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
    }
}