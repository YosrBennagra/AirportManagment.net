using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder
                .HasMany(p => p.Passengers)
                .WithMany(p => p.Flights)
                .UsingEntity(f=>f.ToTable("VolPassenger"));
            /*builder
                .HasOne(p=>p.Plane)
                .WithMany(f=>f.Flights)
                .HasForeignKey(p=>p.PlaneFK);*/
        }
    }
}
