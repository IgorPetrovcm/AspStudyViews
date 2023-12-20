using Microsoft.AspNetCore.Mvc;
using System.Text;
namespace MvcApp;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(IFormFile uploadFile)
    {
        if (uploadFile.Length == 0)
        {
            throw new Exception("File empty");
        }
        StringBuilder str = new StringBuilder();
        using (FileStream stream = new FileStream("Documents/" + uploadFile.FileName, FileMode.Create))
        {
            uploadFile.CopyTo(stream);
            using (StreamReader reader = new StreamReader("Documents/" + uploadFile.FileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    str.Append(line);
                }
            }
        }

        return View();

    }
} 