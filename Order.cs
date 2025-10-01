public class Order
{
    public int Id { get; set; } // private id
    public string Order_str { get; set; }
    public int Quantity { get; set; }
    public Customer Customer { get; set; }
    public int Customer_id { get; set; }
    public Order() { }
    public Order(string order, int quantity)
    {
        Order_str = order;
        Quantity = quantity;
    }
}
