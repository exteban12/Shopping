using Microsoft.EntityFrameworkCore;
using Shopping.Date.Entities;

namespace Shopping.Date
{
    public class DataContext : DbContext
    {
        //conexion a base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //agregacion de entidades a la base de datos
        public DbSet<Country> countries { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        }

    }
}
