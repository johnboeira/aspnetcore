using eCommerce.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfra();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();