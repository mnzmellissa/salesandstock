using SalesAndStock;

while (true)
{
    PrintMenuOptions();
    var selectedOption = GetSelectedOption();
    if (selectedOption == MenuOption.Quit && ConfirmQuit())
        return;

    switch (selectedOption)
    {
        case MenuOption.QuantityProductsInStock:
            Console.WriteLine("Quantity products in stock report");
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    WaitKeyPressed(selectedOption);
}

static void WaitKeyPressed(MenuOption selectedOption)
{
    if (selectedOption == MenuOption.Quit)
        return;

    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static MenuOption GetSelectedOption()
{
    Console.Write("Choose an option: ");

    string? input = Console.ReadLine();
    int.TryParse(input, out int option);

    return (MenuOption)option;
}

static void PrintMenuOptions()
{
    Console.Clear();
    Console.WriteLine("~~~~ MENU OPTIONS ~~~~");
    Console.WriteLine($"{(int)MenuOption.QuantityProductsInStock} - Quantity of Products in Stock");
    Console.WriteLine($"{(int)MenuOption.Quit} - Quit");
    Console.WriteLine();
}

static bool ConfirmQuit()
{
    Console.WriteLine("Are you sure you want to quit? [Y/N]");
    string? response = Console.ReadLine();

    return response == "Y" || response == "y";
}