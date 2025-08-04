using FinalProject.Application.Interface.Context;
using FinalProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using FinalProject.Application.Services.Queries.GetUsers;

var builder = WebApplication.CreateBuilder(args);

// اتصال به SQL Server
string connectionString = @"Server=localhost,1433;Database=FinalProject;User Id=sa;Password=StrongP@ss2025;Encrypt=False;TrustServerCertificate=True;";

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly("FinalProject.endpoint")));

// 🔧 این خط برای ثبت وابستگی IDatabaseContext
builder.Services.AddScoped<IDatabaseContext, DataBaseContext>();

// سرویس‌ها
builder.Services.AddScoped<IGetUserService, GetUserService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
