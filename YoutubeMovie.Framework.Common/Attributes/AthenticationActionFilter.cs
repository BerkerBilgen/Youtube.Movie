using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using YoutubeMovie.Framework.Common.Extensions;
using YoutubeMovie.Framework.Common.Models;

namespace YoutubeMovie.Framework.Common.Attributes
{
    public class AthenticationActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var action = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ActionName;
            var controller = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ControllerName;

            var isLoginPage = controller == "Home" && action == "Login";

            var admin = context.HttpContext.Session.GetObjectFromJson<AdminModel>("Admin");

            if (admin != null && isLoginPage)
                context.Result = new RedirectResult("/Home/Index");

            else if ((admin == null || admin.UserId == Guid.Empty) && !isLoginPage)
                context.Result = new RedirectResult("/Home/Login");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
