using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight> // CTRL + ; ( implementer interface ) 
    {
        public void Configure(EntityTypeBuilder<Flight> builder) // modelBuilder.Entity<Flight>() = builder ( mm type )
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("MyFlight");
            builder.Property(j => j.Deparature).IsRequired().HasMaxLength(100).HasColumnName("ville de depart").HasDefaultValue("TOUNES").HasColumnType("nchar");
            builder.HasOne(f=>f.plane).WithMany(p=>p.Flights).HasForeignKey(f=>f.PlaneFK).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(f => f.passengers).WithMany(f => f.flights).UsingEntity(p => p.ToTable("My Reservation"));
        }
    }
}
