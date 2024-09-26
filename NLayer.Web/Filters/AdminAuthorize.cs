using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayer.Web.Models;

namespace NLayer.Web.Filters
{
    public class AdminAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Admin oturum açmış mı?
            var adminId = context.HttpContext.Request.Cookies["admin_id"];
            if (string.IsNullOrEmpty(adminId))
            {
                // Eğer admin oturum açmamışsa, giriş sayfasına yönlendir
                ErrorViewModel error = new ErrorViewModel() { Errors = new List<string> { "Bu Sayfaya girme yetkiniz yok!" } };
                context.Result = new RedirectToActionResult("Error", "Home", error);
            }

            base.OnActionExecuting(context);
        }
    }
}
