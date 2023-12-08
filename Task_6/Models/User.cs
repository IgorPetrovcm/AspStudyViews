using System.ComponentModel.DataAnnotations;
namespace AppModels;
public class User 
{
    [Required (ErrorMessage = "Логин не указан")]
    [RegularExpression (@"\s", ErrorMessage = "В логине не должно быть пробелов")]
    [StringLength (50,MinimumLength = 3, ErrorMessage = "Длина логина больше 3 и меньше 50")]
    public string login;
    [Required (ErrorMessage = "пин-код не указан")]
    [StringLength (5,MinimumLength = 4, ErrorMessage = "Пин-код имеет четырехзначное значение")]
    public int pin_code;
    [Required]
    public string email;
}