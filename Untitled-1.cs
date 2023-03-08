
public static class Menu
{
    /// <summary>
    /// Displays a menu of options on the console and waits for the user to make a selection.
    /// </summary>
    /// <param name="x">The x-coordinate of the top-left corner of the menu box.</param>
    /// <param name="y">The y-coordinate of the top-left corner of the menu box.</param>
    /// <param name="items">The options to display in the menu.</param>
    /// <returns>The selected option as a string.</returns>
    /// 
    static void Main(string[] args) 
	{
        string[] items = { "apple", "orange", "banana" };
        Console.WriteLine(Draw(0, 0, items));

    }

    public static string Draw(int x, int y, string[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("item " + i + ": " + items[i]);
        }
        Console.WriteLine("Please select item number ");
        int itemNumberSelected = Int32.Parse(Console.ReadLine());

        return items[itemNumberSelected];


    }
}
