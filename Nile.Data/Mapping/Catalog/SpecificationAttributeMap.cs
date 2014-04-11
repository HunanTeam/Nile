using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Catalog;

namespace Nile.Data.Mapping.Catalog
{
    public partial class SpecificationAttributeMap : EntityTypeConfiguration<SpecificationAttribute>
    {
        public SpecificationAttributeMap()
        {
            this.ToTable("SpecificationAttribute");
            this.HasKey(sa => sa.Id);
            this.Property(sa => sa.Name).IsRequired();
        }
    }
}