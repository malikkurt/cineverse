namespace cineverse.Models
{
    public class Watchlist
    {
        public int WatchlistID { get; set; }  
        public int UserID { get; set; }  
        public int? MovieID { get; set; }  
        public int? ShowID { get; set; }  
        public DateTime AddedAt { get; set; }  

        // İlişkiler
        public User User { get; set; }
        public Movie Movie { get; set; }
        public TVShow TVShow { get; set; }
    }
}
