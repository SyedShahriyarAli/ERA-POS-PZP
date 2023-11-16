namespace ERA_POS_PZP.Data;

public class ActiveOrder
{
    public string TableNo { get; set; }
    public string OrderNo { get; set; }
    public string Server { get; set; }
    public TimeOnly Time { get; set; }
    public double Amount { get; set; }
}

public class Table
{
    public string TableNo { get; set; }
    public bool Vacant { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

public class Cart
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public string Comment { get; set; }
    public bool IsNew { get; set; } = true;
    public int SeatNo { get; set; }
}

public class Order
{
    public string OrderNo { get; set; }
    public string TableNo { get; set; }
    public Customer Customer { get; set; }
    public List<Cart> Items { get; set; } = new();
    public int Guests { get; set; }
}

public class Customer
{
    public string Name { get; set; }
    public string Identity { get; set; }
    public double Balance { get; set; }
}

public class Payment
{
    public string Method { get; set; }
    public double Amount { get; set; }
}