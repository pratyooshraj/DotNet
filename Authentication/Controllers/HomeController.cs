using Authentication.Areas.Identity.Data;
using Authentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Authentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;//ctrl+R+R to rename

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserId"] = _userManager.GetUserId(this.User);
            return View();
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
