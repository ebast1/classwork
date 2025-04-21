using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();
            
            // Let's add students and their grades until the user indicates they are done
            // Loop until the user satisfies a condition instead of a specific number of times
            // Replace the for-loop with either a while-loop or a do-while
            // Do we want to loop at least once? Yes -  do-while;    No - while-loop
            // Is it Ok to loop 0-times? Yes - while-loop;   No - do-while
            //
            // In this case we have to ask the user at least once to enter some data
            // How do we want the user to let us know they are done?
            // Create an on/off switch
            // Prompt - ask if they are done
            // Set a condition based on what they tell us
            // Define data used in the loop BEFORE the loop so it's accessible 
            //      both inside and outside the loop
            // scope - where can a variable 
            
            string userResponse = "";
            
            do
            {
                    
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                // Console.Write("Enter grade: ");
                //  Because the user might enter a non-numeric grade causing an exception
                //  We should handle that exception
                //  With a message that will scare a human
                //  We can use a try/catch block to handle the exception
                //  When the user enters a non-numeric grade:
                //      1. ignore it  -  We are going to do this
                //                       the student is added with a grade of 0
                //      2. Give them another chance to handle the exception
                //      3. Set the grade to 0

                double grade = 0;
                string userGrade = "";
                List<double> grades = new List<double>();
                
                try     // A statement inside this try block might cause an exception
                {
                    // We need to get multiple grades for each student and store them in a List
                    string whatTheyTyped = "";
                    while (whatTheyTyped != "end") // Loop until the user enters "end"
                    {
                        
                        Console.WriteLine("Enter grade or end: ");
                        
                        // Get the user input as a string in case we need it later
                        whatTheyTyped = Console.ReadLine();
                        if (whatTheyTyped == "end")
                        {
                            break; // exit the loop - continue would be OK too
                        }
                        grade = Double.Parse(whatTheyTyped); // Get student grade
                        grades.Add(grade);  // Add the grade entered to the List
                    }
                    // at the end of this loop the grades List has all the grades
                }
                catch (Exception exceptionObject)   // If it throws a FormatException ...
                {
                    Console.WriteLine("The data you entered " + userGrade + " is not a valid number");
                    Console.WriteLine("The data is ignored");
                    // Skip adding the student to the dictionary (skip the rest of the loop processing)
                    continue;   // Skip the rest of the loop processing
                }
                

                // Add the data to our Dictionary only if we have a valid grade
                // Dictionary[key}     = value;
                gradeBook[studentName] = grades; // gradeBook.Add(studentName, grade) // may cause an exception
                // Get a response from the user and convert it to lowercase

                do
                {
                    Console.WriteLine("Are you done? [y/n]");
                    userResponse = Console.ReadLine().ToLower();
                    if (userResponse != "y" && userResponse != "n")
                    {
                        Console.WriteLine("Sorry we only accept 'y' or 'n'");
                    }
                    
                }while (userResponse != "n");
                
            } while (userResponse != "y");  // Loop while they are not done (done = "n")
            
            
            
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, List<double>> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}