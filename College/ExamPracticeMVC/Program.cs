using ExamPracticeMVC.Services;
using ExamPracticeMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Injecting New Service
builder.Services.AddSingleton<ILog, Log>();


// Database Connection
builder.Services.AddDbContext<AppDbContext>(option => {
    option.UseMySQL(builder.Configuration.GetConnectionString("Dev_Connection"));
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
