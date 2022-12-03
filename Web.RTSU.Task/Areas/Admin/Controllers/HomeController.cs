using Microsoft.AspNetCore.Mvc;

namespace Web.RTSU.Task.Areas.Admin.Controllers
{
    [Area("Admin")]   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
