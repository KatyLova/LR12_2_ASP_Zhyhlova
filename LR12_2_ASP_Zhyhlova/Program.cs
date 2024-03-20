using LR12_2_ASP_Zhyhlova.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = "Data Source=C:\\sqlite3\\db2.db";

builder.Services.AddDbContext<CompaniesContext>(options => options.UseSqlite(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Companies}/{action=Index}/{id?}");

app.Run();