class Order
    {
        public List<MenuItem> Items { get; set; }

        public Order(List<MenuItem> items)
        {
            Items = items;
        }
        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }
        public void PrintOrder()
        {
            Console.WriteLine("Items:");
            double total = 0.00;
            foreach (MenuItem item in Items)
            {
                total += item.Price;
                Console.WriteLine($"\t{item.Name} - {item.Price.ToString("0.00")}");
            }
            Console.WriteLine($"\nYour total is ${total.ToString("0.00")}\n");
        }
    }