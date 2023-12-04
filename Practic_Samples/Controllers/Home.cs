using Microsoft.AspNetCore.Mvc;
namespace MvcApp;
public class HomeController : Controller 
{
    public IActionResult Index() => View();
    public IActionResult Name() => View();
    public IActionResult Description() => View();
}