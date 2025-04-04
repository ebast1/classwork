namespace VariablesExercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Starting Variables Exercise ---");
        
        Console.WriteLine("--- 1.1 Echo String ---");
        Console.WriteLine("Please enter a string: ");
        string userInput = Console.ReadLine();
        Console.WriteLine("Your string is: " + userInput);

        Console.WriteLine("--- 1.2 Adding a number to an integer ---");
        Console.WriteLine("Please enter a number: ");
        int userInputInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Adding 1 to your int: " + userInputInt + 1);
        
        Console.WriteLine("--- 1.3 Adding a number to an float ---");
        Console.WriteLine("Please enter another number: ");
        double userInputDouble = double.Parse(Console.ReadLine());
        Console.WriteLine("Adding 0.5 to your int: " + userInputDouble + 0.5);
        
        Console.WriteLine("--- 1.4 Adding two floats ---");
        Console.WriteLine("Please enter a float: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another float: ");
        double num2 = double.Parse(Console.ReadLine());
        double sum = num1 + num2;
        Console.WriteLine("The sum of those numbers is: " + sum);
        
        Console.WriteLine("--- 1.5 Multiplying floats ---");
        Console.WriteLine("Please enter a float: ");
        double multNum1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a float: ");
        double multNum2 = double.Parse(Console.ReadLine());
        double multSum = multNum1 *= multNum2;
        Console.WriteLine("The sum of those numbers is: " + multSum);
        
        Console.WriteLine("--- 1.6 Divide integers ---");
        Console.WriteLine("Please enter a number: ");
        int divNum1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number: ");
        int divNum2 = int.Parse(Console.ReadLine());
        double divSum = divNum1 / divNum2;
        Console.WriteLine("The quotient of those numbers is: " + divSum);
            
        Console.WriteLine("--- 1.7 Entering booleans ---");
        Console.WriteLine("Please enter a boolean: ");
        bool userInputBool = bool.Parse(Console.ReadLine());
        Console.WriteLine("Your input is: " + userInputBool);
        if (userInputBool == true)
        {
            userInputBool = false;
        }
        else
        {
            userInputBool = true;
        }
        Console.WriteLine("The opposite of your input is: " + userInputBool);
        
        Console.WriteLine("--- Ending Variables Exercises ---");
    }
}