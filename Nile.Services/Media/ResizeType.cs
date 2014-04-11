using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Nile.Core;
using Nile.Core.Data;
using Nile.Core.Domain.Catalog;
using Nile.Core.Domain.Media;
using Nile.Services.Configuration;
using Nile.Services.Events;
using Nile.Services.Logging;
using Nile.Services.Seo;

namespace Nile.Services.Media
{
    /// <summary>
    /// Resize types
    /// </summary>
    public enum ResizeType
    {
        LongestSide,
        Width,
        Height
    }
}
