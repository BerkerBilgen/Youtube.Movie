using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.CMS.Models;
using YoutubeMovie.Framework.Common;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.CMS.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService _adminService;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() 
        {
            var model = new UserDTO();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserDTO admin)
        {
            var result = await _adminService.Login(admin.Username, admin.Password);

            if (result != Guid.Empty)
                return Redirect("/Home/Index");

            return View();
        }

        [HttpPost]
        public JsonResult GetAdminInfo()
        {
            var admin = GetAdmin();

            return Json(admin);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
