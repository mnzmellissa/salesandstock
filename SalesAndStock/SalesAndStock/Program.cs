using SalesAndStock;

while (true)
{
    Console.Clear();

    Console.WriteLine("~~~~ MENU OPTIONS ~~~~");
    Console.WriteLine($"{(int)MenuOption.QuantityProductsInStock} - Quantity of Products in Stock");
    Console.WriteLine($"{(int)MenuOption.Quit} - Quit");

    Console.WriteLine();

    Console.Write("Choose an option: ");

    MenuOption SelectedOption()
    {
        string? input = Console.ReadLine();

        int.TryParse(input, out int option);

        MenuOption menuOption = (MenuOption)option;
        return menuOption;
    }

    var selectedOption = SelectedOption();

    switch (selectedOption)
    {
        case MenuOption.QuantityProductsInStock:
            Console.WriteLine("Quantity products in stock report");
            break;

        case MenuOption.Quit:
            if (ConfirmQuit())
                return;

            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    if (selectedOption != MenuOption.Quit)
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}
static bool ConfirmQuit()
{
    Console.WriteLine("Are you sure you want to quit? [Y/N]");
    string? response = Console.ReadLine();

    return response == "Y" || response == "y";
}