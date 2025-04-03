namespace NumbersAnalyzer;

class Program
{
    static void Main(string[] args)
    {

        int numberEntered = 0;
        string userName = "";
        
        Console.WriteLine("---- Starting Numbers Analyzer ----");
        
        Console.WriteLine("Before we start what is your name?");
        userName = Console.ReadLine();

        while (numberEntered <= 1 || numberEntered >= 100)
        {
            Console.WriteLine(userName + ", please enter a number between 1 and 100");
            numberEntered = int.Parse(Console.ReadLine());
        }

        if (numberEntered % 2 != 0 && numberEntered < 60)
            {
                Console.WriteLine(userName + ", your input is odd and less than 60");
            }
            else if (numberEntered % 2 == 0 && (numberEntered >= 2 && numberEntered <= 24))
            {
                Console.WriteLine(userName + ", your input is even and less than 25");
            }
            else if (numberEntered % 2 == 0 && (numberEntered >= 26 && numberEntered <= 60))
            {
                Console.WriteLine(userName + ", your input is even and between 26 and 60 inclusive");
            }
            else if (numberEntered % 2 == 0 && numberEntered > 60)
            {
                Console.WriteLine(userName + ", your input is even and greater than 60");
            }
            else if (numberEntered % 2 != 0 && numberEntered > 60)
            {
                Console.WriteLine(userName + ", your input is odd and greater than 60");
            }

        Console.WriteLine("---- Ending Numbers Analyzer ----");
        
    }
}