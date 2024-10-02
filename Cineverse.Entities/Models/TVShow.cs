using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineverse.Entities.Models
{
    public class TVShow
    {
        public int ShowID { get; set; }
        public string Title { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public string PosterURL { get; set; }
        public string TrailerURL { get; set; }
    }
}
