namespace Day_1_Student_Class_Example;

class Program
{
    
    // This is an application program
    // It instantiates and used objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Instantiate (define) a Student class object
        // A class is data type
        // Define an object of a class like any other variable with a slight difference
        
        // data-type name = initializer;  int sum = 0; 
        
        // a class is instantiated with the new keyword
        //          is initialized with one of its constructors
        // className name = new className(initializers);
        
        // We need to be sure we have all the data we want to store in out object
        // Before we instatiate the object
        List<int> scores = new List<int>();
        scores.Add(100);
        scores.Add(90);
        scores.Add(80);

        // Instantiate a Student using the data we want to store in the Student object
        Student aStudent = new Student("Frank", scores);
        
        // Display the Student object we created
        // Console.WriteLine() does not know how to discplat an object of our class
        Console.WriteLine("aStudent: " + aStudent);
        
        // Use the Student class method to display Student class object
        //
        // object.method() <------ object oriented notations
        aStudent.ShowStudent();
    }
}