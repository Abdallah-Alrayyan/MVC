using Microsoft.AspNetCore.Mvc;

namespace Day_3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
