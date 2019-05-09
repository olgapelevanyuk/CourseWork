using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.AirportManagement
{
    public sealed class AirportTypeConfigurations : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("tbl_airports");
            builder.HasKey(ap => ap.AirportId);
            builder.HasIndex(ap => new { ap.AirportCode, ap.AirportName });
            builder.Property(ap => ap.AirportId).HasColumnName("cln_airport_id");
            builder.Property(ap => ap.AirportCode).HasColumnName("cln_airport_code").IsRequired();
            builder.Property(ap => ap.AirportName).HasColumnName("cln_airport_name").IsRequired();
            builder.Property(ap => ap.CityId).HasColumnName("cln_airport_city_id").IsRequired();
            builder.Property(ap => ap.Created).HasColumnName("cln_airport_created").IsRequired();
            builder.Property(ap => ap.Updated).HasColumnName("cln_airport_updated");
            builder.Property(ap => ap.IsDeleted).HasColumnName("cln_airport_is_deleted").HasDefaultValue(false);

            builder.HasOne(ap => ap.City).WithMany(city => city.Airports).HasForeignKey(ap => ap.CityId);
        }
    }
}
