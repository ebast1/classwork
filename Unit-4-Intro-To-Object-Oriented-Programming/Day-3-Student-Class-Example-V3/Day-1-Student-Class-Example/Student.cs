﻿namespace Day_1_Student_Class_Example;

// internal attribute was removed so we can use the class anywhere

// public - anyone can use this class
// class - this is the definition of a C# class
// Student - name of the class - Classname are in PascalCase

// A class is a description of an object used in object oriented programming
// A class contains data (class member/class data and methods (class methods)
// A class is a programmer defined data type (much like int, string, double, List<>)
// Because it is a PROGRAMMER defined data type, the programmer is responsible for:
//
//     the data in the class
//     the methods that manipulate the class data (behaviors of the object)
//
//  class can do whatever a programmer decides it should or shouldn't do
// public is used so any one can instantiate objects of the class
//
// This class represents a student and their test scores
//
public class Student
{
    // Define the data for our class
    // private indicates only members of the class can access the data
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods
    //                 defined in the class.
    //
    // Note: The data is defined without an initial value
    //       Class data should be initialized in constructors
    private string       studentName;
    private List<double> testScores;

    // Define methods for the class

    // One special methods for a class is called a constructor
    // A constructor is responsible for initializingthe data in a class
    // (data should never be uninitialized - the starting value needs to be known)

    // a constructor method is special because:
    //
    //   1. it has no return type; not even void
    //   2. it has the same name as the Class
    //   3. it may or may not receive parameters (initializers)
    //      ( a constructor with no parameters is called a default constructor)
    //   4. Usually public 

    // Define a constructor to initialize our data with values 
    //          specified by the user

    // As the class Designer YOU decide what you need to properly initialize objects of the class
    // YOU decide how constructors you need or how users of the class can initialize your objects
    //
    // Default value is a values used when the real value is not known
    //
    // Do we want to allow an object with default values?
    //       Does it make sense to have a default student name and default scores? 
    //         No - Don't code a default ctor to initialize with default values
    //         Yes - Code a 0-arg ctor to assign default values : public Student
    //
    // Do we want to allow storing the student name with scores?
    //    Yes - Code a 1-arg ctor that takes the name and assigns it studentName
    //                                       and assigns an empty list to testScores
    //
    // Do we want to allow storing test scores without a name?
    //    No - Don't code a 1-arg ctor that takes only the scores: public Student(List<int> scores)

/********************************************************************************************
 * Constructors - Allow user to create object and initialize them
 *******************************************************************************************/

<<<<<<< HEAD
    public Student(string theName)  // 1-arg ctor to accept a name only
=======
    public Student(string theName) // 1-arg ctor to accept a name only
>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
    {
        studentName = theName; // Assign the name passed to the ctor to our studentName
        testScores = new List<double>(); // Define and assign an empty List to testscores
    }

    public Student(string name, List<double> scores) // 2-arg constructor
        // two parameters used to initialize an object
    {
        studentName = name; // Set the class data to the data passed in from the user
        testScores = scores; // Set the class data to the data passed in from the user
    }

    /********************************************************************************************
<<<<<<< HEAD
     * Getter and Setters to allow access to our private data
     *
     * Getters and Setters are special methods to allow a class, controlled access to the data
     * 
     * Getters - return the value in our data members
     * Setters - allow the changing of data members
=======
     * Getters and Setters to allow access to our private data
     *
     * Getters and Setters are special methods to allow a class controlled access to the data
     *
     * Getters - return the value in our data members
     * Setters = allow the changing of data members
>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
     *
     * By convention: Getters are named GetVariableName
     *                Setters are named SetVariableName
     *
<<<<<<< HEAD
     * Most IDEs will generate standard Getters and Setters for any data already defined in the class
     *******************************************************************************************/

    public string GetStudentName()
    {
        return studentName; // return the value in this private data member
    }

    public List<double> GetTestScores()
    {
        return testScores; // return the value in this private data member
    }

    public void SetStudentName(string name)
    {
        studentName = name;
    }

    public void SetTestScores(List<double> scores)
    {
        testScores = scores;
    }

    /********************************************************************************************
     * Methods to manipulate the class
=======
     * Most IDEs will generate standard Getters & Setters for any data already defined in the class
>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
     *******************************************************************************************/

    public string GetStudentName()
    {
        return studentName;  // return the value in this private data member
    }

    public List<double> GetTestScores()
    {
        return testScores; // return the value in this private data member
    }

    public void SetStudentName(string newName)
    {
        studentName = newName;
    }

    public void SetTestScores(List<double> newScores)
    {
        testScores = newScores;
    }


/********************************************************************************************
 * Methods to manipulate the class
 *******************************************************************************************/
    
    // We need to provide a ToString() method to return a string representation of the class data
<<<<<<< HEAD
    // override - indicates you are providing a method that overrides standard C# behavior
    //            the word override is optional
    // ToString() should return a string representation of the data in the class
    //            and accept no parameters
    
    public override string ToString()
    {
        // Define a variable to hold a return value
        string theData = "";

        theData = $"Name: {studentName}";
        theData += $" Scores:";
=======
    // override - indicates you are a providing a method that overrides standard C# behavior
    //            the word override is optional
    // toString() should return a string representation of the data in the class
    //            and accept no parameters
    public override string ToString()
    {
        // Define a variable to hold the return value
        string theData = "";

        theData =  $"Name: {studentName}";   // Start with the student name in a string
        theData += " Scores: ";
>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
        foreach (double aScore in testScores)
        {
            theData += aScore + " ";
        }
<<<<<<< HEAD

        // return the variable with the result
        return  theData;
    }

=======
        
        // return the variable with the result
        return theData;
    }


>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
    // We need a method to allow the user to add scores to our testScores List
    // Every method requires a method signature and a body
    // Method signature:   access  return
    //                       type   type   MethodName(parameters)
    // Method body: inside { } following method signature
    public void AddScore(double score) // Accept a score and return nothing
    {
        testScores.Add(score);
    }

    // Allow the user to get the sum of the scores
    // We need a method to add up the scores and return
    public double SumOfScores() // No args needed as we have access to all the data we need in class
    {
        // Define a variable to hold what we returning
        double sum = 0;
        
        // Two ways we can do this:
        //   1. Use a foreach loop
        //   2. See if there is method for List that do the sum for us
        //      (There seems to be a method we could use, but it looks complicated)
        
        // We will use a foreach loop
        foreach (double scores in testScores)
        {
            sum = sum + scores;  // sum += scores is OK too
        }

        // return the variable with the result
        return sum;
    }
    
    // Method compute average score for user
    public double AvgOfScores()
    {
        // To round a double value to decimal places use Math.Round(value, 3-decimal-places)
<<<<<<< HEAD
        return Math.Round(SumOfScores() / testScores.Count, 5); // Using a class method inside another class method
=======
        return Math.Round(SumOfScores() / testScores.Count, 2); // Using a class method inside another class method
>>>>>>> ad70399443e00d1247ad54b48b8a395977610f27
    }
    
    // Provide a method to display our data
    // (Console.WriteLine() doesn't know how to do it)
    public void ShowStudent()
    {
        Console.WriteLine("\nName: " + studentName);
        Console.Write("Scores: ");

        foreach (double score in testScores)
        {
            Console.Write(score + " ");  // Display on same line
        }
    }
    
}