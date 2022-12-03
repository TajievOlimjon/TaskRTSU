using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Services.MapperServices;
using Web.RTSU.Task.ExtensionMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connection = builder.Configuration.GetConnectionString("DefaultCoonection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

builder.Services.AddServicesToTheContainer();//Add services to the container.

builder.Services.AddAutoMapper(typeof(MapService));

builder.AddSerelogServices(); // add serelog settings to container

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

app.AddMapControllerRoute();

app.Run();
