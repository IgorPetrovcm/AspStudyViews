using Microsoft.AspNetCore.Mvc;
namespace MvcApp;
public class UserController : Controller 
{
    public IActionResult Index() => View(); 
    
}