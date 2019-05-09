using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlympicFlights.DataAccess.CountryManagement;

namespace OlympicFlights.DataAccess.CityManagement
{
    internal sealed class CityTypeConfigurations : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("tbl_cities");
            builder.HasKey(c => c.CityId);
            builder.Property(c => c.CityId).HasColumnName("cln_city_id");
            builder.Property(c => c.CityName).HasColumnName("cln_city_name");
            builder.Property(c => c.CountryId).HasColumnName("cln_city_country_id");
            builder.Property(c => c.Created).HasColumnName("cln_city_created");
            builder.Property(c => c.Updated).HasColumnName("cln_city_updated");
        }
    }
}
