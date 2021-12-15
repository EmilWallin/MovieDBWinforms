using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieDBSearch
{
    internal class MovieSearch
    {
        private HttpClient client = new HttpClient();
        public async Task<Movie> SearchById(int id)
        {
            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");
            string uri = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";
            Movie? movie = null;

            try
            {
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var jsonData = await response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(jsonData);
                return movie;
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        public async Task<SearchResult> SearchByTitle(string title)
        {
            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");
            string uri = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query={title}";
            SearchResult results = new();

            try
            {
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var jsonData = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<SearchResult>(jsonData);
                return results;
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }


        public async Task<GenreResult> FetchGenres()
        {
            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");
            string uri = $"https://api.themoviedb.org/3/genre/movie/list?api_key={key}";
            
            try
            {
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var jsonData = await response.Content.ReadAsStringAsync();
                GenreResult genres = JsonConvert.DeserializeObject<GenreResult>(jsonData);
                return genres;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
