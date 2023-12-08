using Microsoft.AspNetCore.Mvc;
using AppModels;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace MvcApp;
public class HomeController : Controller 
{
    [HttpGet]
    public IActionResult Index() => View();
    [HttpPost]
    public IActionResult Index(string login, int pin_code, string email) 
    {
        if (ModelState.IsValid) 
        {
            ViewBag.Message = $"{login} - {pin_code} - {email}";
            return View();
        }
        return View();
    }
}