MenuItem hotDog = new MenuItem("Hot Dog", 2.50);
MenuItem cheeseburger = new MenuItem("Cheeseburger", 4.00);
MenuItem fries = new MenuItem("Fries", 1.50);
MenuItem sweetTea = new MenuItem("Sweet Tea", 2.00);
MenuItem lemonade = new MenuItem("Lemonade", 2.00);

// create menu
List<MenuItem> Items = new List<MenuItem>();
Items.Add(hotDog);
Items.Add(cheeseburger);
Items.Add(fries);
Items.Add(sweetTea);
Items.Add(lemonade);


Menu menu = new Menu(Items);


    Console.WriteLine("Welcome to the restaurant!");

// Ask for customer's name
Console.WriteLine("What is your name? ");
string customerName = Console.ReadLine();

// Create a new customer with the given name
Customer customer = new Customer(customerName);


// Ask the customer for their order
Console.WriteLine("Here is the menu:");
Console.WriteLine(menu.GetMenuItemsAsString());
List<MenuItem> orderList = new List<MenuItem>();
Boolean ordering = true;

while(ordering == true) {
    Console.Write("Select the number option of what would you like to order. (Enter 0 to complete your order)\n");
    int customerOrder = Convert.ToInt32(Console.ReadLine());
    int quantity = 0;
    switch(customerOrder) {
        case 1:
            Console.Write("How many would you like?\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) {
                orderList.Add(hotDog);
            }
            break;
        case 2:
            Console.Write("How many would you like?\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) {
                orderList.Add(cheeseburger);
            }
            break;
        case 3:
            Console.Write("How many would you like?\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) {
                orderList.Add(fries);
            }
            break;
        case 4:
            Console.Write("How many would you like?\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) {
                orderList.Add(sweetTea);
            }
            break;
        case 5:
            Console.Write("How many would you like?\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) {
                orderList.Add(lemonade);
            }
            break;
        
        case 0:
            ordering = false;
            break;
    }
}

// Create a new order with the customer and order details
Order order = new Order(orderList);

// Print the order details
Console.WriteLine("Your order is:");
order.PrintOrder();


// Let the customer know their order is being prepared
Console.WriteLine("Your order is being prepared by the chef!");

// // Wait for the chef to finish preparing the order
// Chef chef = new Chef(1, "Jose");
// chef.PrepareOrder(order);

// // Notify the server that the order is ready
// server.OrderReady(order);

for(int i = 0; i < 5; i++) {
    Thread.Sleep(1000);
    if(i == 2) {
        Console.WriteLine("Your will be out any minute...");
    } else {
        Console.WriteLine("....");
    }
}

// Let the customer know their order is ready
Console.WriteLine($"Your order is ready, {char.ToUpper(customerName[0]) + customerName.Substring(1)}! Enjoy your meal!");