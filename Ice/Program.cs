using Ice.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.AddBuilderConfiguration();

var app = builder.Build();
app.UseAppConfiguration();
app.Run();