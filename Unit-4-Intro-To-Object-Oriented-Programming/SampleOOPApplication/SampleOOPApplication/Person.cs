namespace SampleOOPApplication;

/***************************************************
 *     This class will represent a Person
 *
 *  Attributes : Name
 *               Height
 *               Weight
 *               Age
 *               Gender
 *               EyeColor
 *               HairColor
 */


public class Person
{ 
    /*
    *   Instance Variables identify attributes unique to an object of a class
    */

    private string _name;            // C# coding convention says that, private variables start with _
    private int    _heightInInches;
    private double _weightInPounds;
    private int    _age;
    private string _gender;
    private string _eyeColor;
    private string _hairColor;

    /***********************
     *     Properties
     **********************/
    
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int HeightInInches
    {
        get => _heightInInches;
        set => _heightInInches = value;
    }

    public double WeightInPounds
    {
        get => _weightInPounds;
        set => _weightInPounds = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Gender
    {
        get => _gender;
        set => _gender = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string EyeColor
    {
        get => _eyeColor;
        set => _eyeColor = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string HairColor
    {
        get => _hairColor;
        set => _hairColor = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    /**********************
     *     Constructors
     **********************/

    public Person(string name, int heightInInches, double weightInPounds, int age, string gender, string eyeColor, string hairColor)
    {
        _name = name;
        _heightInInches = heightInInches;
        _weightInPounds = weightInPounds;
        _age = age;
        _gender = gender;
        _eyeColor = eyeColor;
        _hairColor = hairColor;
    }
    
    /******************************************************************
     *             Method Overrides for default behaviors
     ******************************************************************/

    public override bool Equals(object? obj)
    {
        return base.Equals(obj); // performs default b
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Name} {HeightInInches} inches {Gender} {Age} years old";
    }
    
    
    
} // End of Person class