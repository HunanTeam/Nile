using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Media;

namespace Nile.Data.Mapping.Media
{
    public partial class DownloadMap : EntityTypeConfiguration<Download>
    {
        public DownloadMap()
        {
            this.ToTable("Download");
            this.HasKey(p => p.Id);
            this.Property(p => p.DownloadBinary).IsMaxLength();
        }
    }
}