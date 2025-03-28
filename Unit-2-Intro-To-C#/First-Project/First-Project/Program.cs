
// This is a comment - everything after the double slash is ignored

/*
 *  This is a block comment - everything after between the slash-asterisk
 *                            and asterisk-slash is ignored
 *
 * this is userful if you have a lot to say or to deactivate code
 *
 
   The * at the start of the line is optional
   
 */

// a namespace identifies a context in which a word is known 
// allows the same name to be used in different contexts and to mean different things

namespace First_Project;

// Everything in C# is defined in a Class
// a Class is a group of related things
// a Class starts with the class keyword

class Program
    
// { } surround blocks of code aka code-blocks

{ // Start of the Code for the Class
    
    // Every application has a program called Main()
    // a method is a self-contained set of code that performs a function
    // also known as: a function or a program
    // a method may return a value and accept data to process
    // method signature identifies what the method returns, it's name and what it accepts
    //      return-type name(data-it-accepts)
    
    // Main() is simply where every application starts
    // Every application has one and only one Main() method
    
    // Below Main() is a method that returns void and accepts string[] called args
    //
    // void means it returns nothing
    // static means there can only be one of these in this block or code (Program class)
    
    //     return
    //     type   name(data-it-accepts)
    static void   Main(string[] args) // method signature for Main()
    
    { 
        // Start of the Code for Main()
        // This code will display whatever is between the ("") on the screen
        
        // Console is an object defined by the C# to represent the screen
        // An object has certain behaviors
        // A behavior is something an object can do with data
        // behaviors are implemented using methods
        
        // object.method(data) - object oriented programming
        // 
        // when you see a . after a name, the name to the left of the dot is probable an object
        //                name(, the name is a method
        //                name after the ., the name is usually a method
        
        // object.method(data-for-the-method-to-process)
        Console.WriteLine("Hello, World!"); // EVERY C# STATEMENT ENDS WITH A ;
        
    } // End of the Code for Main()
    
} // End of the Code for the Class