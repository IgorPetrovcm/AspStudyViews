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
    public IActionResult Index(string login, int pin_code ) 
    {
        if (ModelState.IsValid) {
            ViewBag.Message = $"{login} - {pin_code}";
            return View();
        }
        var strErrors = new StringBuilder();
        foreach (var item in ModelState) 
        {
            strErrors.Append(item.Key + " " + item.Value + "\n");
        }
        foreach (var item in ModelState) 
        {
            foreach (var error in item.Value.Errors) 
            {
                strErrors.Append($"{item.Key} {error.ErrorMessage}\n");
            }
        }
        return Unauthorized(strErrors.ToString());
    } 
}