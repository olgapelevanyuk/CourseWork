using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.ClientManagement
{
    public sealed class ClientTypeConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("tbl_clients");
            builder.HasKey(cl => cl.ClientId);
            builder.Property(cl => cl.ClientId).HasColumnName("cln_client_id");
            builder.Property(cl => cl.ClientFirstname).HasColumnName("cln_client_first_name").HasMaxLength(30).IsRequired();
            builder.Property(cl => cl.ClientLastname).HasColumnName("cln_client_last_name").HasMaxLength(30).IsRequired();
            builder.Property(cl => cl.ClientAddress).HasColumnName("cln_client_address").HasMaxLength(255).IsRequired();
            builder.Property(cl => cl.UserId).HasColumnName("cln_client_user_id");
            builder.Property(cl => cl.Created).HasColumnName("cln_client_created").IsRequired();
            builder.Property(cl => cl.IsDeleted).HasColumnName("cln_client_is_deleted").HasDefaultValue(false).IsRequired();
            builder.Property(cl => cl.Updated).HasColumnName("cln_client_updated");
            builder.Property(cl => cl.UserId).HasColumnName("cln_client_user_id");

            builder.HasOne(cl => cl.User).WithMany(au => au.Clients).HasForeignKey(cl => cl.UserId);
        }
    }
}
