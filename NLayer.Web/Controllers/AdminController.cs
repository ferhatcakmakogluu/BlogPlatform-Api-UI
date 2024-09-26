using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Web.Models;
using NLayer.Web.Services;
using NLayer.Web.Filters;
namespace NLayer.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminApiService _adminApiService;

        public AdminController(AdminApiService adminApiService)
        {
            _adminApiService = adminApiService;
        }

        //root root123
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminsDto adminsDto)
        {
            var response = await _adminApiService.LoginAdmin(adminsDto.UserName, adminsDto.Password);
            if (response != null)
            {
                var cookieOptions = new CookieOptions
                {
                    // Tarayıcı tarafından okunabilir
                    HttpOnly = true
                };
                string adminId = response.Id.ToString();
                Response.Cookies.Append("admin_id", adminId, cookieOptions);

                //var userInfo = await _userApiService.GetUserByIdAsync(userId);

                //var userNameSurname = $"{userInfo.Name} {userInfo.LastName}";
                Response.Cookies.Append("adminName", response.Name.ToString(), cookieOptions);

                ViewBag.CookieUserId = response.Id;
                ViewBag.AdminLoginErrorMessage = "";
                //HttpContext.Session.SetInt32("UserId", response.UserId);

                return RedirectToAction("Dashboard", "Admin");
            }
            ViewBag.AdminLoginErrorMessage = "Kullanıcı adı veya şifre hatalı!";
            return View();
        }

        [AdminAuthorize]
        public IActionResult Dashboard()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult NewsPortal()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult Albumes()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult Admins()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult Comments()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult BannedUsers()
        {
            return View();
        }

        [AdminAuthorize]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("admin_id");
            Response.Cookies.Delete("adminName");
            return RedirectToAction("Index", "Admin");
        }
    }
}
