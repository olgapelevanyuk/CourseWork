using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlympicFlights.DataAccess.CityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.CountryManagement
{
    public sealed class CountryTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("tbl_countries");
            builder.HasKey(cntry => cntry.CountryId);
            builder.HasIndex(cntry => cntry.CountryName);
            builder.Property(cntry => cntry.CountryId).HasColumnName("cln_country_id");
            builder.Property(cntry => cntry.CountryName).HasColumnName("cln_country_name");
            builder.Property(cntry => cntry.Created).HasColumnName("cln_country_created");
            builder.Property(cntry => cntry.Updated).HasColumnName("cln_country_updated");
            builder.Property(cntry => cntry.IsDeleted).HasColumnName("cln_country_is_deleted").HasDefaultValue(false);
        }
    }
}
