namespace Day_1_Student_Class_Example;

// internal attribute so we can use the class anywhere
// public - anyone can use this class
// class - this is the definition of a C# class
// Student - name of the class - Classname's are in PascalCase

// A class is a description of an object that is used in object-oriented programming
// A class contains data and methods (class members/class data and (class methods))
// A class is a programmer defined data type (much like an int, string, double, List<>)
// Because it is PROGRAMMER defined data type, the programmer is responsible for:
//
//      the data in the class
//      the methods that manipulate the class data
//
// A class can do whatever a programmer decides it should and shouldn't do
public class Student
{
    // Define the data for our class
    // private indicates only members of the class can access the data
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods defined in the class
    // Note: The data is defined without an initial value
    //       Class data should be initialized in constructors
    private string studentName;
    private List<int> testScores;
    
    // Define methods for the class
    
    // One special methods for a class is called a constructor
    // A constructor is responsible for initializing the data in a class
    // (data should never be uninitialized - the starting value needs to be known)
    
    // a constructor method is special because:
    //
    //  1. it has no return type; not even void
    //  2. it has the same name as the Class
    //  3. it may or may not receive parameters (initializers)
    //      (a constructor with no parameters is called a default constructor)
    //  4. Usually public
    
    // Define a constructor to initialize out data with values
    //          specified by the user

    public Student(string name, List<int> scores)
    {
        studentName = name; // Set the class data to the data passed in from the user
        testScores = scores; // Set the class data to the data passed in from the user
    }
    
    // Provide a method to display our data
    // (Console.WriteLine() doesn't know how to do it)
    public void ShowStudent()
    {
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Scores: ");
        foreach (int score in testScores)
        {
            Console.WriteLine(score);
        }
    }
}