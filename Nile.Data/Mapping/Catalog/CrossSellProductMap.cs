using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Catalog;

namespace Nile.Data.Mapping.Catalog
{
    public partial class CrossSellProductMap : EntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}