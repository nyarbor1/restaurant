public class Chef
{
    public int chefId { get; set; }
    public string chefName { get; set; }
    public bool isAvailable { get; set; }

    public Chef(int id, string name)
    {
        chefId = id;
        chefName = name;
        isAvailable = true;
    }

    void PrepareOrder(MenuItem item)
    {
        // Chef prepares the food
        Console.WriteLine($"Chef {chefName} is preparing {item.Name}");
        isAvailable = false;
        Thread.Sleep(5000); // Simulate cooking time
        isAvailable = true;
        Console.WriteLine($"Chef {chefName} has finished preparing {item.Name}");
    }
}