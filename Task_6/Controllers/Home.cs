using Microsoft.AspNetCore.Mvc;
namespace MvcApp;
class HomeController : Controller 
{
    public IActionResult Index() => View();
}