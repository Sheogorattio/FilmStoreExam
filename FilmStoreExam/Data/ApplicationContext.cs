using FilmStoreExam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmStoreExam.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .Property(p => p.ActorId)
        //        .IsRequired(false)
        //        .HasColumnType("int");

        //    modelBuilder.Entity<Actor>()
        //        .Property(p => p.ProductId)
        //        .IsRequired(false)
        //        .HasColumnType("int");

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
