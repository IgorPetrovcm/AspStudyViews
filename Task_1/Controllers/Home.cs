using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class Home : Controller 
    {
        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult About() 
        {
            return View("Test");
        }
    } 
}