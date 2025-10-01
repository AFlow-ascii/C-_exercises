var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();


List<Product> products = new List<Product>
{
    new Product("Animal Farm", 10, "Book"),
    new Product("Acer", 1000, "Laptop"),
    new Product("Apple", 1, "Fruits")
};

app.MapGet("/products", () =>
{
    return Results.Ok(products);
})
// .WithName("getproducts")
.WithOpenApi();

app.Run();