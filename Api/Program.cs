using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddServiceScoped();
builder.Services.AddCustomServices();
var app = builder.Build();

//add some configuration to app
app.UseCustomMiddleware();
app.Run();
