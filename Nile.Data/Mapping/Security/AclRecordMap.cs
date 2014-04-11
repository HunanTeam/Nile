using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Security;

namespace Nile.Data.Mapping.Security
{
    public partial class AclRecordMap : EntityTypeConfiguration<AclRecord>
    {
        public AclRecordMap()
        {
            this.ToTable("AclRecord");
            this.HasKey(ar => ar.Id);

            this.Property(ar => ar.EntityName).IsRequired().HasMaxLength(400);

            this.HasRequired(ar => ar.CustomerRole)
                .WithMany()
                .HasForeignKey(ar => ar.CustomerRoleId)
                .WillCascadeOnDelete(true);
        }
    }
}