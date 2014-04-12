using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.Core.Domain2.Users
{
    public class UserLoginInfo : BaseEntity2
    {
        public int UserId { get; set; }
        public string LoginIpAddress { get; set; }
    }
}
