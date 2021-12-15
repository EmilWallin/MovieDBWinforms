using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBSearch
{
    internal class Movie
    {
        public Genre[] Genres { get; set; }
        public int[]? Genre_Ids { get; set; }
        public string Homepage { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
        public string Release_Date { get; set; }
        public int Runtime { get; set; }
        public string Title { get; set; }
        public float Vote_Average { get; set; }


        public override string ToString()
        {
            string releaseYear = string.IsNullOrEmpty(this.Release_Date) ? "Unknown" : this.Release_Date.Substring(0, 4);
            return $"{this.Title} ({releaseYear})";
        }
    }
}
