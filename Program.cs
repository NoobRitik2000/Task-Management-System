using Microsoft.EntityFrameworkCore;
using Task_Management_System.Models; // Replace 'YourNamespace' with the actual namespace where ApplicationDbContext is located


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
// Configure DbContext with SQL Server
builder.Services.AddDbContext<AppDBContext>(item =>
    item.UseSqlServer(config.GetConnectionString("TaskManage")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
