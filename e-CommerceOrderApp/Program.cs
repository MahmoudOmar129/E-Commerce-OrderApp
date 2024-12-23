var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();

var App = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
