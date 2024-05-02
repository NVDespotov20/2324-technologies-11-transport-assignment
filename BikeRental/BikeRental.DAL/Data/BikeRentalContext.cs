using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL.Data
{
    public class BikeRentalContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Bike> Bikes { get; set; } = null!;
        public DbSet<RentalAgreement> RentalAgreements { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:bikrentalserver.database.windows.net,1433;Initial Catalog=BikeRentalDB;Persist Security Info=False;User ID=serverAdmin;Password=QnakaPalqka123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<RentalAgreement>()
                .HasOne(ra => ra.Renter)
                .WithMany(u => u.RentalAgreementsAsRenter)
                .HasForeignKey(ra => ra.RenterId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
