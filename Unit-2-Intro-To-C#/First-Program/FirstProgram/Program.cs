namespace FirstProgram;

// This program will ask for three numbers
//      add them together and display the total

// Programming Solution - Human Thinking
// Identify the detailed steps

// Ask for the numbers one at a time
// Write-down each number as its given
// Add the numbers together create a sum/total
// Tell the requester the total

// Now that we have the steps in out solution
// Identify any data you need for the steps

// 1. A place to write down each number - a variable in a program
// 2. A place to hold the sum/total - a variable in a program
// 3. A way to ask for the numbers - a method in a program (object.method())
// 4. A way to receive the numbers - a method in a program (object.method())
// 5. A way to report the sum/total - a method in a program (object.method())

// Place the steps in the order and provide more detail if necessary
// we need to solve the problem

// 1. Ask for the numbers one at a time
//      a. Tell whoever is giving us the numbers to give me the number first
//      b. Receive the first number from sender
//      c. Write down the first number
//      d. Loop for each request (in this case its 3)

// 2. Add the numbers together create a sum/total
//      a. Add the first number to the sum/total
//      b. Add the second number to the sum/total
//      c. Add the third number to the sum/total

// 3. Tell the requester the sum/total (display)

class Program
{
    static void Main(string[] args)
    {
        /*
         *  Define my data the program needs at the top of the program
         *
         *  Data may be defined anywhere before it's used, it's easier to find at the top of the program
         *
         *  To define a variable: data-type name = initial-value;
         *
         *  Commonly used data types in C#:
         *
         *      int - Numeric data that is a whole number between +/- 2 billion
         *      long - A whole number that is greater than +/- 2 billion
         *      double - Numeric value with decimal places
         *      char - a single alphanumeric character
         *      string - a series of alphanumeric characters (words or sentences)
         *      bool - true or false value for conditions
         *
         *      examples:   10  - int (or long)
         *                  1.0 - double
         *                  'a' - char (note it is enclosed in ' ')
         *                  "some words" - string (note it is enclosed in " ")
         *
         *  Variable names in C# are usually spelled in camelCase; Use _ to separate words
         *  (camelCase means the first letter is in lowercase, and all other words start with an upper case letter)
         *
         *  It's always good to initialize variables when defining them so you know what is in them
         */
        
        // Define the variables to hold the numbers we need to add

        int number1 = 0;
        int number2 = 0;
        int number3 = 0;

        //  Define a variable to hold the sum
        
        int sum = 0;
        
        Console.WriteLine("--- Starting Program ---");
        
        // Ask for the numbers one at a time using C# Console object
        //      which represents the keyboard and screen
        // Console.ReadLine() returns a string - cannot store in an int
        
        Console.WriteLine("Please enter a number: ");   // Asking for the number
        string aLine;                                   // String to hold the line of input from the keyboard
        aLine = Console.ReadLine();                     // Get a line from the keyboard
        
        // We need an int value to store our numbers
        // Console.ReadLine() only returns a string
        // So we need to convert the string from Console.ReadLine() to an int
        // int.Parse(string) will convert a string into an int
        
        number1 = int.Parse(aLine);
        
        Console.WriteLine("--- Ending Program ---");
    }
}