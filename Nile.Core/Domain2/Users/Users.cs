using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.Core.Domain2.Users
{
    public partial class Users : BaseEntity2
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
        /// <summary>
        /// 加密方式
        /// </summary>
        public int PwdFormatId { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string PwdSalt { get; set; }
        /// <summary>
        /// 是否激活
        /// </summary>
        public bool Active { get; set; }

        public DateTime? ActiveTime { get; set; }
    }
}
