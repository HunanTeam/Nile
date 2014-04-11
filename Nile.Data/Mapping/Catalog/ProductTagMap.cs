using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Catalog;

namespace Nile.Data.Mapping.Catalog
{
    public partial class ProductTagMap : EntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            this.ToTable("ProductTag");
            this.HasKey(pt => pt.Id);
            this.Property(pt => pt.Name).IsRequired().HasMaxLength(400);
        }
    }
}