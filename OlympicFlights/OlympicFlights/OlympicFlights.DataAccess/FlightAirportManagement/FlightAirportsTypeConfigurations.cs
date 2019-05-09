using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightAirportManagement
{
    public sealed class FlightAirportsTypeConfigurations : IEntityTypeConfiguration<FlightAirports>
    {
        public void Configure(EntityTypeBuilder<FlightAirports> builder)
        {
            builder.ToTable("tbl_flight_airports");
            builder.HasKey(fa => fa.FlightAirportsId);
            builder.Property(fa => fa.FlightAirportsId).HasColumnName("cln_flight_airport_id").IsRequired();
            builder.Property(fa => fa.AirportId).HasColumnName("cln_flight_aiport_airport_id").IsRequired();
            builder.Property(fa => fa.FlightId).HasColumnName("cln_flight_aiport_flight_id").IsRequired();
            builder.Property(fa => fa.IsArrive).HasColumnName("cln_flight_airport_is_arrive").IsRequired();

            builder.HasOne(fa => fa.Flight).WithMany(fl => fl.Airports).HasForeignKey(fa => fa.FlightId);
            builder.HasOne(fa => fa.Airport).WithMany(ap => ap.Flights).HasForeignKey(fa => fa.AirportId);



        }
    }
}
