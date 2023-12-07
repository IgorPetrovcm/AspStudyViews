var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Models.PersonStorage>();
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=User}/{action=AddUser}");

app.Run();
