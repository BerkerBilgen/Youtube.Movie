using Microsoft.EntityFrameworkCore;
using YoutubeMovie.Entities.Models;

namespace YoutubeMovie.Entities.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Video>().ToTable("Video");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Slider>().ToTable("Slider");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Admin>().ToTable("Admin");
        }
    }
}
