namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        
        // Ask the user to enter a sentence (series of words seperated bby whitespace - space, tab, something you can't see)
        // Display each word in the sentence
        
        Console.WriteLine("Please enter a sentence:");
        string sentence = Console.ReadLine();   // Get what they type and put it in a string
        
        // .split() will extract parts of a string into an array based on the characters inside ()
        string[] splitSentence = sentence.Split(" ");    // split sentence into words
        
        // Display each word in the sentence
        for (int i = 0; i < splitSentence.Length; i++)
        {
            Console.WriteLine(splitSentence[i]);
        }

        // foreach loop can also process arrays and Lists
        //
        // Syntax: foreach(data-type variable-name in array-or-List)
        //                 data-type is a type of data in the array or List
        //                 use the variable name inside the foreach loop to access an element in the array
        //
        // Foreach goes through the array or List from start to end assigning each element to the variable
        //
        // for-loop vs foreach
        //
        // Both can process an array or List from beginning to end
        // for-loop can start and end at any element by setting int i= and changing the condition
        // foreach loop ALWAYS processes from beginning to the end
        // for-loop you know which element you are processing by using the value in i
        // foreach loop you do not know what element number you are processing
        
        foreach (string aWord in splitSentence)
        {
            Console.WriteLine(aWord);
        }

    }
}