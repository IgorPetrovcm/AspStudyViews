using Microsoft.AspNetCore.Mvc;
namespace MvcApp;
public class HomeController : Controller 
{

    public IActionResult Index(string list) 
    {
        ViewBag.Message = list;
        return View();
    }
}