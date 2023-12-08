using Microsoft.AspNetCore.Mvc;
using AppModels;
namespace MvcApp;
public class HomeController : Controller 
{
    [HttpGet]
    public IActionResult Index() => View();
    [HttpPost]
    public IActionResult Index(string login, int pin_code ) 
    {
        if (ModelState.IsValid) {
            ViewBag.Message = $"{login} - {pin_code}";
            return View();
        }
        else return Unauthorized("Name or pin no valid");
    } 

}