using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectCoffe.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string BancoConexao =
              builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextPool<DatabaseContext>(options =>
                options.UseSqlServer(BancoConexao,
                      ServerVersion.AutoDetect(BancoConexao)));

builder.Services.AddControllersWithViews();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
