class MenuItem
    {
    internal string name;
    internal object price;

    public string Name { get; set; }
        public double Price { get; set; }
        
        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }