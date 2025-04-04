namespace MethodsExamples;

class Program
{
            /**************************************************************************
             *
             *  Demonstrate the use of Programmer defined methods
             *
             *  a method is a program that processes data and usually returns a value
             *
             *  a method starts with a method signature, which identifies the name of the method
             *                                                            what type of data it returns
             *                                                            what data it will accept for processing
             *
             *  Method signature:   return-type Name(data-it-will-accept)
             *
             *      return-type - the type of data returned from the method
             *                    use void if the method does not return data
             *
             *      Name() - name of the method - method names are in PascalCase
             *                                    PascalCase - the first letter of every word is capitalized
             *
             *      (data-it-will-accept) - data-type and name of any parameters
             *
             *      parameter is a piece of data passed/given to a method for it's processing
             *
             **************************************************************************/    
     
    // Every application has one and only one called Main()
    //
    // Main() method signature    
    //
    //
    // static - indicates there can only be one of this in an application
    //
    //     return  
    //     type    name(parameters-it-may-accept)
    static void    Main(string[] args)  // Main() is a method that returns nothing and receives string[] called args
    {
        
        Console.WriteLine("Hello, World!");
        int mySum = Addem(4, 5);    // Send the numbers 4 and 5 to Addem to get the sum
                                    // Addem() will be executed with the numbers 4 and 5
                                    // it will return the sum
                                    // which will be stored in the variable mySum

        int yoda = 97;
        int obiWon = 420; 
        
        Console.WriteLine("The sum of 4 and 5 is: " + mySum);
        Console.WriteLine("The sum of 3 and 4 is: " + Addem(3, 4));
        Console.WriteLine("The sum yoda and obiWon is: " + Addem(yoda, obiWon));    // Calling Addem() with two ints
                                                                                    // Run the Addem() that takes two ints
        Console.WriteLine("The sum of 3.1 and 4.5 is: " + Addem(3.1, 4.5)); // Calling Addem() with two doubles 
                                                                            // Run the Addem() that takes two doubles
        Console.WriteLine("The sum of 3 and 4.5 is: " + Addem(3, 4.5));     // Calling Addem() with an int and a double
                                                                            // We don't have an Addem() that takes an int and a double
                                                                            // It runs the Addem() that takes two doubles   
                                                                            // C# converts the int into a double
                                                                            // so now it can run the Addem() that takes doubles
                                                                            
    } // End of Main()
    
    // After a method you may define other methods that method can use
    // "Helper Methods" - help a method perform a specific task
    
    // Define a method to receive two numbers and return the sum
    //
    // If a method will be used by a static method, it must be static itself
    // Any method used by Main() must be static because Main() is static
    
    
    //  Addem() is a method that receives two ints it's calling num1 and num2
    //                      and returns the sum of the ints as an int
    
    //  return
    //  type           name (parameters)
        static int     Addem(int num1, int num2)
        {
            return num1 + num2;  // Add the two parameters and return the sum
        }
        static double  Addem(double num1, double num2)
        {
            return num1 + num2;  // Add the two parameters and return the sum
        }

} // End of Program class