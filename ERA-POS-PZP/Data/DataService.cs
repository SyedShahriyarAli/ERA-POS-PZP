namespace ERA_POS_PZP.Data;

public class DataService
{
    public Task<List<ActiveOrder>> GetActiveOrders()
    {
        var orders = new List<ActiveOrder>();

        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 01", Server = "Waiter", TableNo = "Table # 01 - 01", Time = new TimeOnly(12, 30) });
        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 01", Server = "Waiter", TableNo = "Table # 01 - 02", Time = new TimeOnly(12, 30) });
        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 02", Server = "Waiter", TableNo = "Table # 02", Time = new TimeOnly(12, 30) });
        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 03", Server = "Waiter", TableNo = "Table # 03", Time = new TimeOnly(12, 30) });
        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 04", Server = "Waiter", TableNo = "Table # 04", Time = new TimeOnly(12, 30) });
        orders.Add(new ActiveOrder() { Amount = 2500.0, OrderNo = "Order # 05", Server = "Waiter", TableNo = "Table # 05", Time = new TimeOnly(12, 30) });

        return Task.FromResult(orders);
    }

    public Task<List<Table>> GetTables()
    {
        var tables = new List<Table>();

        for (int i = 1; i <= 10; i++)
        {
            tables.Add(new Table
            {
                TableNo = $"Table # {i.ToString().PadLeft(2, '0')}",
                Vacant = !(i <= 5)
            });
        }

        return Task.FromResult(tables);
    }

    public Task<List<Product>> GetProducts()
    {
        var products = new List<Product>()
        {
            new Product { Name = "Burger", Category = "Main Course", Price = 7.99 },
            new Product { Name = "Pizza", Category = "Main Course", Price = 12.99 },
            new Product { Name = "Salad", Category = "Appetizer", Price = 5.99 },
            new Product { Name = "Pasta", Category = "Main Course", Price = 9.99 },
            new Product { Name = "Ice Cream", Category = "Dessert", Price = 4.99 },
            new Product { Name = "Coffee", Category = "Beverage", Price = 2.99 },
            new Product { Name = "Steak", Category = "Main Course", Price = 15.99 },
            new Product { Name = "Soup", Category = "Appetizer", Price = 3.99 },
            new Product { Name = "Fish and Chips", Category = "Main Course", Price = 10.99 },
            new Product { Name = "Cheesecake", Category = "Dessert", Price = 6.99 }
        };


        return Task.FromResult(products);
    }

    public Task<List<Customer>> GetCustomers()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "John Doe", Identity = "123456789", Balance = 5000 },
            new Customer { Name = "Jane Smith", Identity = "213456789", Balance = 50 },
            new Customer { Name = "Bob Johnson", Identity = "132456789", Balance = 1000 },
            new Customer { Name = "Alice Williams", Identity = "124356789", Balance = 2000 },
            new Customer { Name = "Charlie Brown", Identity = "123546789", Balance = 3000 },
            new Customer { Name = "Eva Davis", Identity = "123465789", Balance = 7853 },
            new Customer { Name = "Frank Miller", Identity = "123457689", Balance = 2000 },
            new Customer { Name = "Grace Wilson", Identity = "123456879", Balance = 998 },
            new Customer { Name = "David Lee", Identity = "123456798", Balance = 4000 },
            new Customer { Name = "Sophia Brown", Identity = "213546789", Balance = 3500 }
        };


        return Task.FromResult(customers);
    }
}

