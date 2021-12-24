using Autofac;
using Autofac.Extensions.DependencyInjection;
using BookStore.Web;
using BookStore.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;
using Serilog.Filters;
using Serilog.Sinks.File;
using Serilog.Sinks.MSSqlServer;
using Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Options;

var builder = WebApplication.CreateBuilder(args);

//Autofac config
builder.Host.UseServiceProviderFactory(new
AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder
    .RegisterModule(new WebModule());
});


//Logger config
builder.Host.UseSerilog((ctx, lc) => lc
.MinimumLevel.Debug()
.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
.Enrich.FromLogContext()
.ReadFrom.Configuration(builder.Configuration));


var appSettings = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var logDB = @"Server=DESKTOP-SFE8PP4\\SQLEXPRESS;Database=SerilogExample;Integrated Security=SSPI;";
var sinkOpts = new MSSqlServerSinkOptions { TableName = "Logs" };
var columnOpts = new ColumnOptions();

Log.Logger = new LoggerConfiguration()
    .WriteTo.MSSqlServer(
        connectionString: logDB,
        sinkOptions: sinkOpts,
        columnOptions: columnOpts,
        appConfiguration: appSettings
    ).CreateLogger();


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

try
{
    var app = builder.Build();

    Log.Information("Application Started..");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

    app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
}
finally
{
    Log.CloseAndFlush();
}