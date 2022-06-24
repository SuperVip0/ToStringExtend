using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToStringExtend;

namespace WebApi.Models
{
    public class UserInfo:ClassToString
    {
        public string UserId { get; set; }
        public string Pwd { get; set; }
    }
}