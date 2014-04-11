using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Common;

namespace Nile.Data.Mapping.Common
{
    public partial class SearchTermMap : EntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
