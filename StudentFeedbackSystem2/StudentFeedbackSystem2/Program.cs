using Microsoft.EntityFrameworkCore;
using StudentFeedbackSystem2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//DI
builder.Services.AddDbContext<MiniProjectDbContext>(options =>
                        options.UseSqlServer(builder.Configuration.GetConnectionString("MiniProjectDbContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Create}/{id?}");

app.Run();
