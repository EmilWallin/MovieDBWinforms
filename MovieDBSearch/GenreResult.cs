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

        //GetName of genre id (id != index, which is why this is needed)
        public string GetName(int id)
        { return Genres.First(i => i.Id == id).Name; }
    }
}
