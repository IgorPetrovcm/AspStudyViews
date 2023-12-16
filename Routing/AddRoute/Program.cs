var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id}");
app.MapControllerRoute(name: "pairNameAge", pattern: "{controller}/{action}/{name}/{age}");
app.Run();
