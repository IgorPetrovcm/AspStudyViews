using Microsoft.AspNetCore.Mvc;
using Models;
namespace MvcApp;
public class UserController : Controller 
{
    public PersonStorage persons;
    public UserController(PersonStorage persons) => this.persons = persons;
    [HttpGet]
    public IActionResult AddUser() 
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddUser(string name, int age)
    {
        Person person = new Person(name, age);
        persons.persons.Add(person);
        return View();
    }
    public IActionResult UserStorage() 
    {
        return View(persons.persons);
    }
}