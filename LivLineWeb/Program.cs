using LivLineWeb.Services;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddScoped<SimplificationService>();

app.UseStaticFiles();

app.UseDefaultFiles();

app.Run();
