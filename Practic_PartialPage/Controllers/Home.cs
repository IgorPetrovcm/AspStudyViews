using Microsoft.AspNetCore.Mvc;
namespace MvcApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string page)
        {
            ViewBag.Message = page;
            return View();
        }
    } 
}