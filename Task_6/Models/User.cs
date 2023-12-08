using System.ComponentModel.DataAnnotations;
namespace AppModels;
public class User 
{
    [Required]
    public string login;
    [Required]
    public int pin_code;
}