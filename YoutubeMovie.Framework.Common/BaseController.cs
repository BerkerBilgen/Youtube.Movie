using Microsoft.AspNetCore.Mvc;
using YoutubeMovie.Framework.Common.Extensions;
using YoutubeMovie.Framework.Common.Models;

namespace YoutubeMovie.Framework.Common
{
    public class BaseController : Controller
    {
        protected AdminModel GetAdmin()
        {
            var admin = HttpContext.Session.GetObjectFromJson<AdminModel>("Admin");

            return admin;
        }
    }
}
