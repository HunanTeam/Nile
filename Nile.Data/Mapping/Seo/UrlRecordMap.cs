using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Seo;

namespace Nile.Data.Mapping.Seo
{
    public partial class UrlRecordMap : EntityTypeConfiguration<UrlRecord>
    {
        public UrlRecordMap()
        {
            this.ToTable("UrlRecord");
            this.HasKey(lp => lp.Id);

            this.Property(lp => lp.EntityName).IsRequired().HasMaxLength(400);
            this.Property(lp => lp.Slug).IsRequired().HasMaxLength(400);
        }
    }
}