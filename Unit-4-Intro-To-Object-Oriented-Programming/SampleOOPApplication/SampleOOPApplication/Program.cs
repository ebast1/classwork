namespace SampleOOPApplication;

class Program
{
    // Application Program should define abd manipulate objects
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person aPerson = new Person("John", 78, 250, 69, "Male", "Red", "Green");

        Console.WriteLine(aPerson.ToString());
    }
}