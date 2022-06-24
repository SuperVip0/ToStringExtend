using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Filters;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class IndexController : ApiController
    {
        #region Throw Exception
        [WebApiException]
        [HttpPost]
        public void ThrowError([FromBody] UserInfo vo)
        {
            int.Parse("22add");
        }
        #endregion
        #region Throw Exception
        [WebApiException]
        [HttpPost]
        public void ThrowError2([FromBody] UserInfoEx vo)
        {
            int.Parse("22add");
        }
        #endregion
    }

}