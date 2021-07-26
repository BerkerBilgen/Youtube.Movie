using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using YoutubeMovie.Framework.Common.Extensions;
using YoutubeMovie.Framework.Common.Models;

namespace YoutubeMovie.Framework.Common
{
    public class BaseApiController : ControllerBase
    {
        protected UserClaims GetUser()
        {
            if (!User.Identity.IsAuthenticated || !User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier))
                throw new Exception();

            var user = new UserClaims
            {
                Username = User.Claims.Where(x => x.Type == "username").Select(x => x.Value).FirstOrDefault()
            };

            return user;
        }
    }
}
