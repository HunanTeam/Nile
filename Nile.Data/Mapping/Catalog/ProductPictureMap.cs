using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Catalog;

namespace Nile.Data.Mapping.Catalog
{
    public partial class ProductPictureMap : EntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureMap()
        {
            this.ToTable("Product_Picture_Mapping");
            this.HasKey(pp => pp.Id);
            
            this.HasRequired(pp => pp.Picture)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(pp => pp.PictureId);


            this.HasRequired(pp => pp.Product)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(pp => pp.ProductId);
        }
    }
}