public class Product
{
    private static int Contatore_id = 0;
    private int _id;
    public int Id => _id; // private id
    public string Name { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }

    public Product(string name, int price, string category)
    {
        Contatore_id++;
        _id = Contatore_id;
        Name = name;
        Price = price;
        Category = category;
    }
}

// Product (Id, Name, Price, Category)