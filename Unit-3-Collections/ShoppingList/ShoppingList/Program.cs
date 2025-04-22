namespace ShoppingList;

class Program
{
    //  Two Collections : one for the menu and one for the shopping list
    //
    //  what will it do
    /*
     *
     *  Display at least 8 items names and prices
     *  Ask the user to enter an item name
     *      a. if that item exists, display that item and price and add that to the user's order
     *      b. if that item doesn't exist, display an error and re-prompt the user. (Display the menu again if you want to)
     *
     *  After adding one to their order, ask if they want to add another. If so, repeat
     *  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
     *
     *  When they are done adding items, display a list of all items ordered with prices in columns
     *  Display the sum price of the items ordered
     *
     */
    
    static bool moreShopping()
    {
        bool isThereInput = false;
        string whatUserEntered = "";
        bool getInput = true;

        do
        {
            Console.WriteLine("Would you like to shop for more items? (Y/N)");
            whatUserEntered = Console.ReadLine().ToUpper();

            if (whatUserEntered == "Y")
            {
                getInput = true;
            }
            else if (whatUserEntered == "N")
            {
                getInput = false;
            }

        } while (whatUserEntered != "Y" && whatUserEntered != "N");

        return getInput;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("--- Starting Shopping List ---");
        
        Dictionary<string, decimal> itemMenu = new Dictionary<string, decimal>();

        itemMenu["apple"] = 1.99M;
        itemMenu["pear"] = 2.99M;
        itemMenu["carrot"] = 3.99M;
        itemMenu["banana"] = 4.99M;
        itemMenu["pineapple"] = 5.99M;
        itemMenu["cherry"] = 6.99M;
        itemMenu["lemon"] = 7.99M;
        itemMenu["tomato"] = 8.99M;

        Console.WriteLine("\n***** Item Menu *****");
        
        foreach (KeyValuePair<string, decimal> item in itemMenu)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

        Console.WriteLine("*********************\n");
        
        List<string> shoppingList = new List<string>();

        decimal shoppingTotal = 0M;
        
            do
            {
                bool validInput = false;
                
                while (!validInput)
                {
                    Console.WriteLine("Please enter something you would like to buy: ");
                    string userInput = Console.ReadLine().ToLower();

                    if (itemMenu.ContainsKey(userInput))
                    {
                        shoppingTotal += itemMenu[userInput];
                        shoppingList.Add(userInput);
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid item you would like to buy");
                    }
                }
                
            } while (moreShopping());
            
        Console.WriteLine("\n***** Shopping List *****");
        foreach (string item in shoppingList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nYour total today comes out to: " + "$" + shoppingTotal + "\n");
        
        Console.WriteLine("--- Ending Shopping List ---");
        
    } // End of Main()
    
} // End of Program

