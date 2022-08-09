Console.WriteLine("Welcome to your shopping list builder. \n");
decimal total = 0;
int itemNum = 1;

//Display at least 8 item names and prices fr a menu 
Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu["bread"] = 2.50m;
menu["milk"] = 1.50m;
menu["eggs"] = 2.00m;
menu["apple"] = .50m;
menu["banana"] = .75m;
menu["grapes"] = 3.00m;
menu["peanut butter"] = 2.50m;
menu["jelly"] = 2.00m;

//Initialize list
List<string> list = new List<string>();

Console.WriteLine($"---------------------");
Console.WriteLine($"     Shop Menu");
Console.WriteLine($"---------------------");
//Displays list of items with their prices 
foreach (var pair in menu)
{
    Console.WriteLine("{0, -15} {1, 5}",  $"{pair.Key}: ", $"${pair.Value}");

}
Console.WriteLine($"---------------------");


do
{
    //Ask the user to enter an item name
    Console.Write("\nWhat item would you like to add to your list?: ");
    string input = Console.ReadLine();

    //If that item exists, display that item and price and add that item to the user’s order.
    if (menu.ContainsKey(input.ToLower()))
    {

        //Store the name of the items the customer ordered to the list 
        //Add item name and price to the relevant List if it does (1 point)
        Console.WriteLine($"Added {input} to your cart.");
        list.Add($"{input} - {menu[input]}");

        total += menu[input];


        Console.WriteLine($"Your total is ${total}");

    }
    else //If that item doesn’t exist, display an error and re-prompt the user.   
    {
        Console.WriteLine($"I'm sorry, {input} was not found on the menu.");
    }

    //After adding one to their order, ask if they want to add another.
} while (KeepGoing());


//When they’re done adding items, display a list of all items ordered with prices in columns.
Console.WriteLine("\nYour final list: ");
foreach (var item in list)
{
    Console.WriteLine(item);
}


//Display the sum price of the items ordered.
Console.WriteLine($"Your total is ${total}");

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("\nWould you like to add another item to your list? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");

        }
    }
}


//Extra challenge: Implement a menu system so the user can enter just a letter or number for the item.
//Extra challenge: Display the most and least expensive item ordered.
//Extra challenge: Display the items ordered in order of price.
