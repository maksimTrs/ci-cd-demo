using System.Net;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
  return "Hello";
});

app.Run();