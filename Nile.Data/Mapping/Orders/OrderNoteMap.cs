using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Orders;

namespace Nile.Data.Mapping.Orders
{
    public partial class OrderNoteMap : EntityTypeConfiguration<OrderNote>
    {
        public OrderNoteMap()
        {
            this.ToTable("OrderNote");
            this.HasKey(on => on.Id);
            this.Property(on => on.Note).IsRequired();

            this.HasRequired(on => on.Order)
                .WithMany(o => o.OrderNotes)
                .HasForeignKey(on => on.OrderId);
        }
    }
}