var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder().AddUserSecrets<Program>(true);
builder.Configuration.AddUserSecrets<Program>(true);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run();
