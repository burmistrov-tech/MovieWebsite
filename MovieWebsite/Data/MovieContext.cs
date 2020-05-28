using Microsoft.EntityFrameworkCore;

using MovieWebsite.Models;

namespace MovieWebsite.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
