using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Project.Entities
{
    public class E_Reviews
    {
        public int id_movie { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int Length_min { get; set; }
        public int id_studio { get; set; }

    }
}
