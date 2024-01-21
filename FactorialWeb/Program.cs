using FactorialService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "The factorial of 5 is " + FactorialLogic.GetFactorialValue(5));

app.Run();
