using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContexte : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localDB)\MsSqlLocalDb; initial catalog = DhaouJawharNET ; Integrated Security = true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasKey(f => f.FlightId);
            modelBuilder.Entity<Flight>().ToTable("MyFlight");
            modelBuilder.Entity<Flight>().Property(j => j.Deparature).IsRequired().HasMaxLength(100).HasColumnName("ville de depart").HasDefaultValue("TOUNES").HasColumnType("nchar");
        }


    }
}
