using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
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
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
           // modelBuilder.ApplyConfiguration(new PassengerConfiguration());

            modelBuilder.Entity<Passenger>().ToTable("Passenger");
            modelBuilder.Entity<Traveller>().ToTable("Traveller");
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }


        //ay propriété String ( twalli Varchar 120 )
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(120);
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
            configurationBuilder.Properties<Double>().HavePrecision(2, 3);
        }

        


    }
}
