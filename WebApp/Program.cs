using Microsoft.EntityFrameworkCore;
using WebApp.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<WebApp.Models.CategoryRepository>();
//Trend VN
builder.Services.AddScoped<BrandRepository>();

builder.Services.AddDbContext<StoreContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("Store")));
builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles(); //css, js, image
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
//app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
app.Run();