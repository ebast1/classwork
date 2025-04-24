namespace Exercises;

class Program
{
    
    /*
     *      Exercises
     * 
     *    TenCharExtract() Extracts the first 10 characters of a user entered string
     *          Needs
     *              1. A way to ask a user for a string of characters
     *              2. A place to store those characters for extraction
     *              3. A method to remove any spaces or other characters from the string
     *              4. A way to show the user the 10 characters
     *
     *    LastTenCharExtract() Does the same thing as TenCharExtract() but at a different point in the string
     *          Needs
     *              1. A way to ask a user for a string of characters
     *              2. A place to store those characters for extraction
     *              3. A method to remove any spaces or other characters from the string
     *              4. A way to show the user the last 10 characters
     *
     *     NumOfVowels() takes a string and tells the user how many vowels are in that string
     *          Needs
     *              1.
     */

    /************************************************
                      Helper Methods
     ************************************************/
    
    static string TenCharExtract(string input)
    {
        string inputNoSpaces = input.Replace(" ", "");
        string result = "";
        
        for (int i = 0; i < 10; i++)
        {
            result += inputNoSpaces[i];
        }
        
        return result;
    }

    static string LastTenCharExtract(string input)
    {
        string inputNoSpaces = input.Replace(" ", "");
        string result = "";

        for (int i = (inputNoSpaces.Length - 10); i < inputNoSpaces.Length; i++)
        {
            result += inputNoSpaces[i];
        }

        return result;

    }

    static int NumOfVowels(string input)
    {
        char vowels = "";
        
        foreach (char letter in input)
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                
            }
        }
        
    }

    /************************************************
                      Helper Methods
     ************************************************/
    
    static void Main(string[] args)
    {
        Console.WriteLine("--- Starting Exercises ---");
        
        Console.WriteLine("Please enter a sentence: ");
        string userInput = Console.ReadLine();
        Console.WriteLine(TenCharExtract(userInput));
        
        Console.WriteLine("Please enter a sentence: ");
        string userInput2 = Console.ReadLine();
        Console.WriteLine(LastTenCharExtract(userInput2));
        
        
        
        Console.WriteLine("--- Ending Exercises ---");
    } // End of Main()
    
}