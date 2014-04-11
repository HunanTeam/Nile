
using Nile.Core.Configuration;

namespace Nile.Core.Domain.Common
{
    public class AdminAreaSettings : ISettings
    {
        public int GridPageSize { get; set; }

        public bool DisplayProductPictures { get; set; }
    }
}