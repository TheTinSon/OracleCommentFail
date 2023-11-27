var builder = WebApplication.CreateBuilder(args); 
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("secrets.json");
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
