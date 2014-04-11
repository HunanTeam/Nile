using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Shipping;

namespace Nile.Data.Mapping.Shipping
{
    public class WarehouseMap : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.ToTable("Warehouse");
            this.HasKey(wh => wh.Id);
            this.Property(wh => wh.Name).IsRequired().HasMaxLength(400);
        }
    }
}
