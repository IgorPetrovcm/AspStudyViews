using Microsoft.AspNetCore.Mvc;
using ModelsApp.Models;
namespace MvcApp;
public class UserController : Controller 
{
    public IActionResult Index() => View(); 
    public IActionResult OutputValue() 
    {
        int output = 230;
        return View(output);
    } 
    public IActionResult OutputCollection() 
    {
        int[] arr = {1,2,3,4,5,6,7,8,9};
        List<User> users = new List<User>() {
            new User("Igor",22),
            new User("Vlad",18),
            new User("Maks",28)
        };
        return View(users);
    }
}