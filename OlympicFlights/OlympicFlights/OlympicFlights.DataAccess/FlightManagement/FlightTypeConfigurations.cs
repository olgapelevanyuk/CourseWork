using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightManagement
{
    public sealed class FlightTypeConfigurations : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("tbl_flights");
            builder.HasKey(fl => fl.FlightId);
            builder.Property(fl => fl.FlightId).HasColumnName("cln_flight_id");
            builder.Property(fl => fl.DepartureTime).HasColumnName("cln_flight_departure_time").IsRequired();
            builder.Property(fl => fl.ArriveTime).HasColumnName("cln_flight_arrive_time").IsRequired();
            builder.Property(fl => fl.IsDeleted).HasColumnName("cln_flight_is_deleted").HasDefaultValue(false);
        }
    }
}
