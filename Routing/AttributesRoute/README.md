# Атрибуты маршрутизации
Мы можем использовать в приложени маршрутизацию на основе атрибутов фреймворка **MVC**. Такой способ маршретизации называется **Atribute-Based Routing**Ю к слову, маршрутизация на основе условностей называется **Convention-Based Routing**. Атрибуты позволяют маршрутизировать более гибко.

##### [Route]
```csharp
using Microsoft.AspNetCore.Mvc;
namespace Mvc;
public class HomeController : Controller 
{
    [Route("Home/Index")]
    public string Index() => "Index page";
    [Route("About")]
    public string Page() => "This random page";
} 
```
В данном случае метод `Index` будет обрабатываться по адресу `/Home/Index`, а метод `Page` по адресу `/About`

Если в проекте мы используем маршрутизацию на основе атрибутов, то в файле `Program.cs` для объекта `app` определяет метод `MapControllers`:
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllers();

app.Run();

```

Теперь мы можем обращаться по адресам переданым в атрибутах, например `http://localhost{...}/About`:
![Alt text](image.png)

# Комбинируем Atribute-Based с Convention-Based
```csharp
    [Route("HomePage")]
    public string Index() => "Index page";
```