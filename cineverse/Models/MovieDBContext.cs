using Microsoft.EntityFrameworkCore;

namespace cineverse.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<TVShow> TVShows { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //public DbSet<Watchlist> Watchlists { get; set; }
    }

}
