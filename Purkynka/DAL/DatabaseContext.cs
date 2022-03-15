using Microsoft.EntityFrameworkCore;
using Purkynka.DAL.Models;

namespace Purkynka.DAL
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tom\source\repos\Purkynka\Purkynka\DAL\Database.mdf;Integrated Security=True");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasMaxLength(250);
            modelBuilder.Entity<User>().Property(u => u.LastName).HasMaxLength(250);
            modelBuilder.Entity<User>().Ignore(u => u.FullName);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.User)
                .WithMany(u => u.Addresses);
        }
    }
}
