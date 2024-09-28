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

        //[AdminAuthorize]
        public IActionResult Dashboard()
        {
            return View();
        }

        //[AdminAuthorize]
        public IActionResult NewsPortal()
        {
            var chartData = new List<NewsDto>
            {
                new NewsDto { Id=1,Title="Deneme",Description="Deneme yazısı", ReadCount=100,LikeCount=75,DislikeCount=10 },
                new NewsDto { Id=2,Title="Deneme",Description="Deneme yazısı", ReadCount=150,LikeCount=89,DislikeCount=35 },
                new NewsDto { Id=3,Title="Deneme",Description="Deneme yazısı", ReadCount=200,LikeCount=120,DislikeCount=50},
                new NewsDto { Id=4,Title="Deneme",Description="Deneme yazısı", ReadCount=145,LikeCount=110,DislikeCount=20 },
                new NewsDto { Id=5,Title="Deneme",Description="Deneme yazısı", ReadCount=250,LikeCount=175,DislikeCount=14 },
                new NewsDto { Id=6,Title="Deneme",Description="Deneme yazısı", ReadCount=325,LikeCount=250,DislikeCount=5 },
                new NewsDto { Id=7,Title="Deneme",Description="Deneme yazısı", ReadCount=169,LikeCount=100,DislikeCount=40 }
            };
            return View(chartData);
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
