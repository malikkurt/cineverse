namespace cineverse.Models
{
    public class TVShow
    {
        public int ShowID { get; set; }  
        public string Title { get; set; }  
        public int Seasons { get; set; } 
        public int Episodes { get; set; } 
        public float Rating { get; set; }  
        public string Description { get; set; } 
        public string PosterURL { get; set; } 
        public string TrailerURL { get; set; }  
    }
}
