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
        public string Homepage { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
        public string Release_Date { get; set; }
        public int Runtime { get; set; }
        public string Title { get; set; }
        public float Vote_Average { get; set; }
    }
}
