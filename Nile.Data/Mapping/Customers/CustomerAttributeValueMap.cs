using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Customers;

namespace Nile.Data.Mapping.Customers
{
    public partial class CustomerAttributeValueMap : EntityTypeConfiguration<CustomerAttributeValue>
    {
        public CustomerAttributeValueMap()
        {
            this.ToTable("CustomerAttributeValue");
            this.HasKey(cav => cav.Id);
            this.Property(cav => cav.Name).IsRequired().HasMaxLength(400);

            this.HasRequired(cav => cav.CustomerAttribute)
                .WithMany(ca => ca.CustomerAttributeValues)
                .HasForeignKey(cav => cav.CustomerAttributeId);
        }
    }
}