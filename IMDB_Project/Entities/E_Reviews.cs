using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Project.Entities
{
    public class E_Reviews
    {

        public int Id_Reviews { get; set; }
        public int Id_Users { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Date { get; set; }
        public int id_Movie { get; set; }

    }
}
