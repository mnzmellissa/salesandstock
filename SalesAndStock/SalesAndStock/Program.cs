using SalesAndStock;

while (true)
{
    Console.Clear();

    Console.WriteLine("~~~~ MENU OPTIONS ~~~~");
    Console.WriteLine("1 - Quantity of products in stock");
    Console.WriteLine("9 - Quit");

    Console.WriteLine();

    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

     int.TryParse(input, out int option);

    MenuOption selectedOption = (MenuOption)option;

    switch (selectedOption)
    {
        case MenuOption.QuantityProductsInStock:
            Console.WriteLine("Option 1 selected");
            break;

        case MenuOption.Quit:
            return;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
}

