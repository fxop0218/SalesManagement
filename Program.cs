using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesManagment.Data;
using SalesManagment.Services;
using SalesManagment.Services.Contracts;
using Syncfusion.Blazor; // Imported
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionStr = builder.Configuration.GetConnectionString("SalesDbConnection")
    ?? throw new InvalidOperationException("Connection 'SalesDbConnection' don't exists");

// Connect to database
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionStr));

// Only can enter in the sistem if the user validates the email, RequireConfirmedAccount = true
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Necesary to use blazer sync fusion
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<TokenProvider>();

builder.Services.AddScoped<IEmployeeManagementService, EmployeeManagementService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ISalesOrderReportService, SalesOrderReportService>();
builder.Services.AddScoped<IOriganisationService, OrganisationService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

var app = builder.Build();


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

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

app.UseAuthorization();
app.UseAuthentication();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
