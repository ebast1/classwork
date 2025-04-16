using System.Net.Http.Headers;

namespace BasicStringProcessing;

class Program
{
    
    static string[] sentenceWords;


    static void splitSentence(string sentence)
    {
        sentenceWords = sentence.Split(" ");
    }
    
    static bool moreInput()
    {
        bool   isThereInput  = false; 

        string whatUserTyped = "";     

        bool   getInput      = true;   

        do
        {
            Console.WriteLine("Do you have any numbers to enter (Y/N)?");
            whatUserTyped = Console.ReadLine();

            whatUserTyped = whatUserTyped.ToUpper();

            string firstChar = whatUserTyped.Substring(0, 1);

            if (firstChar == "Y")
            {
                getInput = false;
                isThereInput = true;
            }
            else
            {
                if (firstChar == "N")
                {
                    getInput = false;
                    isThereInput = false;
                }
            }
        } while (getInput); // Loop while we get input

        return isThereInput;
    }
    
    // Have the user inout some text to add to a list
    // ask the user to continue
    // loop
    // a. a place to put the inputs
    // b. a method to add the inputs to a list
    // c. a method to print the list as a string
    
    static List<string> sentenceList = new List<string>(); // List to keep the userInputs

    static string ongoingSentence = ""; // place to keep the ongoingSentence 
    
    static void addList()  // Method to add the userInput into the List
    {
        Console.WriteLine("Please enter some text: ");
        string listInput = Console.ReadLine();
        sentenceList.Add(listInput);

        ongoingSentence = ""; // Clears the sentence so nothing duplicates
        
        foreach (string word in sentenceList)
        {
            ongoingSentence += word + " ";
        }

        // for (int i = 0; i < sentenceList.Count; i++)
        // {
        //     ongoingSentence += sentenceList[i] + " ";
        // }
        
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("\n--- Starting BasicStringProcessing ---!\n");

        // do
        // {
        //     Console.WriteLine("Please enter a string: ");
        //     string input = Console.ReadLine();
        //     splitSentence(input);
        //
        //     foreach (string word in sentenceWords)
        //     {
        //         Console.WriteLine(word);
        //     }
        //     
        // }while(moreInput());

        do
        {
            addList();
            Console.WriteLine("You have entered: " + ongoingSentence);
        }while(moreInput());

        Console.WriteLine("\n--- Ending BasicStringProcessing ---!\n");
    }
}

