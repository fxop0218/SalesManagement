using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Services;
using SalesManagment.Services.Contracts;
using Syncfusion.Blazor; // Imported

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionStr = builder.Configuration.GetConnectionString("SalesDbConnection")
    ?? throw new InvalidOperationException("Connection 'SalesDbConnection' don't exists");

// Connect to database
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionStr));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Necesary to use blazer sync fusion
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<IEmployeeManagementService, EmployeeManagementService>();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("licence");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
