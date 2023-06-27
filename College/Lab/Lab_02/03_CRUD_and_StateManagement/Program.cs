using _03_CRUD_and_StateManagement;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Making Mysql Connection
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseMySQL(builder.Configuration.GetConnectionString("Dev_Connection"));// Connection String that we define in './appsettings.json'
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
