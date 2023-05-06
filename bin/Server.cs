class Server {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Server(string name, int age, string phone, string email)
    {
        Name = name;
        Age = age;
        Phone = phone;
        Email = email;
    }

    public void TakeOrder(Customer customer, List<MenuItem> items)
    {
        // Order order = new Order(customer, items, this);
        Console.WriteLine($"Order taken by {Name} for {customer.Name}");
        // order.PrintOrder();
    }
}