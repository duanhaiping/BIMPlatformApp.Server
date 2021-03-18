using System;
using System.Collections.Generic;
using System.Text;

namespace BIMPlatformApplication.Application.Domain.Users
{
    public class User
    {

        public int ID { get; set; }
        public Guid? TenantId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string UserHeadImgUrl { get; set; }
        public string WeiXinOpenID { get; set; }
        public bool IsActivated { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
