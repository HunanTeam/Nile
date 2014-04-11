using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Orders;

namespace Nile.Data.Mapping.Orders
{
    public partial class CheckoutAttributeMap : EntityTypeConfiguration<CheckoutAttribute>
    {
        public CheckoutAttributeMap()
        {
            this.ToTable("CheckoutAttribute");
            this.HasKey(ca => ca.Id);
            this.Property(ca => ca.Name).IsRequired().HasMaxLength(400);

            this.Ignore(pva => pva.AttributeControlType);
        }
    }
}