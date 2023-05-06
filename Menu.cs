class Menu
{
    public List<MenuItem> Items { get; set; }

    public Menu(List<MenuItem> items)
    {
        Items = items;
    }

    public void AddItem(MenuItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(MenuItem item)
    {
        Items.Remove(item);
    }

    public string GetMenuItemsAsString()
    {
        string menuString = "";
        int i = 1;
        foreach (MenuItem item in Items)
        {
            menuString += i + ") " + item.Name + " - $" + item.Price.ToString("0.00") + "\n";
            i++;
        }

        return menuString;
    }
}