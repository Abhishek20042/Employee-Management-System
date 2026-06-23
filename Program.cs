using DemoApp.Model;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<EmpModel>();
var app = builder.Build();

app.MapGet("/Index", () => "Index");
app.MapDefaultControllerRoute();

app.Run();
