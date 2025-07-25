using FinalProject.Application.Interface.Context;
using FinalProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// اتصال به دیتابیس SQL Server
string connectionString = @"Server=localhost,1433;Database=FinalProject;User Id=sa;Password=StrongP@ss2025;Encrypt=False;TrustServerCertificate=True;";

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly("FinalProject.endpoint")));


builder.Services.AddControllersWithViews();
// تا اینحا

var app = builder.Build();

// پیکربندی pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
