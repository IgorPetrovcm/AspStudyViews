using Microsoft.AspNetCore.Mvc;
namespace MvcApp;
public class HomeController : Controller
{
    public string Index(int id) => id.ToString();
    public string About(string name, int age) => $"{name}-{age}";
}