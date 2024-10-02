using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineverse.Entities.Models
{
    public class Review
    {
        public int ReviewID { get; set; }   
        public int UserID { get; set; }  
        public int? MovieID { get; set; } 
        public int? ShowID { get; set; }  
        public string Comment { get; set; }  
        public float Rating { get; set; }  
        public DateTime CreatedAt { get; set; }  

        // İlişkiler
        public User User { get; set; }
        public Movie Movie { get; set; }
        public TVShow TVShow { get; set; }
    }
}
