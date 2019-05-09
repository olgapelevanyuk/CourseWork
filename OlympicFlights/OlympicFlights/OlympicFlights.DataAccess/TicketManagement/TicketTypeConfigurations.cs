using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.TicketManagement
{
    public sealed class TicketTypeConfigurations : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("tbl_tickets");
            builder.HasKey(t => t.TicketId);
            builder.Property(t => t.TicketId).HasColumnName("cln_ticket_id");
            builder.Property(t => t.ClientId).HasColumnName("cln_ticket_client_id");
            builder.Property(t => t.FlightId).HasColumnName("cln_ticket_flight_id");
            builder.Property(t => t.Created).HasColumnName("cln_ticket_created").IsRequired();
            builder.Property(t => t.IsPurchaseApproved).HasColumnName("cln_ticket_is_purchase_approved").HasDefaultValue(false);
            builder.Property(t => t.IsDeleted).HasColumnName("cln_ticket_is_deleted").HasDefaultValue(false);

            builder.HasOne(t => t.Flight).WithMany(fl => fl.Tickets).HasForeignKey(t => t.FlightId);
            builder.HasOne(t => t.Client).WithMany(cl => cl.Tickets).HasForeignKey(t => t.ClientId);
        }
    }
}
