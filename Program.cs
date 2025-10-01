var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/greeting", () =>
{
    return "Hello from ASP.NET Core";
})
// .WithName("getgreet")
.WithOpenApi();

app.Run();