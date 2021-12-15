using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBSearch
{
    internal class GenreResult
    {
        public Genre[] Genres { get; set; }

        public string GetName(int id)
        { return Genres.First(i => i.Id == id).Name; }
    }
}
