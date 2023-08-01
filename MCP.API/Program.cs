// Bring in the necessary namespaces for the classes and interfaces used in this code.
using Azure.Storage.Blobs;
using MCP.API;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

// Configure Azure Blob Storage service
builder.Services.AddScoped(_ =>
{
    return new BlobServiceClient(builder.Configuration.GetConnectionString("AzureStorage"));
});
// // AzureADB2C
// builder.Services.AddAuthentication(options =>
//     {
//         options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//         options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
//     })
//     .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAdB2C"));

// Configure logging
builder.Host.ConfigureLogging((context, logging) =>
{
    logging.ClearProviders();
    logging.AddConfiguration(context.Configuration.GetSection("Logging"));
    logging.AddDebug();
    logging.AddConsole();
});

// Initialize and configure the Startup class
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

// Build the application
var app = builder.Build();

// Configure the request pipeline
startup.Configure(app, app.Environment);

// Run the application
app.Run();