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
        public IActionResult Index(string interaction, int val1, int val2) 
        {
            if (interaction == "Addition") 
            {
                ViewData["Output"] = val1 + val2;
                return Redirect("/Home/Index");
            }
            if (interaction == "Subtraction") 
            {
                ViewData["Output"] = val1 - val2;
                return Redirect("/Home/Index");
            }
            return BadRequest("Not found interaction");
        }
    }
}