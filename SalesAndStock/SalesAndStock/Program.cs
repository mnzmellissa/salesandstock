while (true)
{
    Console.Clear();

    Console.WriteLine("~~~~ MENU OPTIONS ~~~~");
    Console.WriteLine("1 - Quantity of products in stock");
    Console.WriteLine("9 - Quit");

    Console.WriteLine();

    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

    int option;

    bool isValid = int.TryParse(input, out option);

    if (isValid == false)
    {
        Console.WriteLine("Invalid option");
        continue;
    }

    bool continueMessage = true;

    switch (option)
    {
        case 1:
            Console.WriteLine("Option 1 selected");
            break;

        case 9:
            continueMessage = false;
            if (confirmQuit())
            {
                return;
            }
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    if (continueMessage)
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue..."); //deve aparecer em todas as opções exceto a 9
        Console.ReadKey();
    }
}

static bool confirmQuit()
{
    Console.WriteLine("Are you sure you want to quit? [Y/N]");
    string response = Console.ReadLine();

    return response == "Y" || response == "y";
}