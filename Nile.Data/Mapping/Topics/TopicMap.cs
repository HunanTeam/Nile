using System.Data.Entity.ModelConfiguration;
using Nile.Core.Domain.Topics;

namespace Nile.Data.Mapping.Topics
{
    public class TopicMap : EntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
