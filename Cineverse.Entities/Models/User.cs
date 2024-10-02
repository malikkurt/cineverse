using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineverse.Entities.Models
{
    public class User
    {
        public int UserID { get; set; }  
        public string Email { get; set; }  
        public string PasswordHash { get; set; }  
        public string Username { get; set; }  
        public string ProfileImage { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime LastLogin { get; set; } 
    }
}
