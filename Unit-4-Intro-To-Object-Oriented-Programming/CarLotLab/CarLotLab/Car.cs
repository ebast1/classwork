using System.Net;

namespace CarLotLab;

public class Car
{

    public static List<Car> cars = new List<Car>();
    
    public static List<Car> ownedCars = new List<Car>();
    
    private string _make;   // private data starting with _'s
    private string _model;
    private int _year;
    private decimal _price;

    public string Make 
    {
        get { return _make; }
        set { _make = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Car() // Default car ctor that takes no args and has default values
    {
        _make = "";
        _model = "";
        _year = 0;
        _price = 0;
    }

    public Car(string make, string model, int year, decimal price) // ctor that takes all four args
    {
        _make = make;
        _model = model;
        _year = year;
        _price = price;
    }

    
    public override string ToString()
    {
        return $"Car: {_make}\tModel: {_model}\tYear: {_year}\tPrice: {_price}";
    }

    public static void AddCar(Car car)
    {
        cars.Add(car);
    }

    public static void AddCar(UsedCar usedCar)
    {
        cars.Add(usedCar);
    }

    public static void BuyCar(int index)
    {
        Console.WriteLine($"You have bought this car: {cars[index]}");
        if (cars[index] is UsedCar)
        {
            ownedCars.Add(cars[index]);
        }
        else
        {
            ownedCars.Add(cars[index]);
        }
    }

    public static void ListCars(List<Car> list)
    {
        foreach (var car in list)
        {
            Console.WriteLine($"{car} is at index {list.IndexOf(car)}");
        }
    }

    public static void RemoveCar(int index)
    {
        cars.RemoveAt(index);
    }

    public static void BuyBack()
    {
        Car.ListCars(ownedCars);
        
        Console.WriteLine("Which car would you like to sell? (Please use the index listed for the car)");
        int userInput = int.Parse(Console.ReadLine());

        Console.WriteLine("How many miles did you drive the car?");
        int miles = int.Parse(Console.ReadLine());

        if (miles >= 0)
        {
            
        }
        
        Console.WriteLine($"You have sold this car back to the lot: {ownedCars[userInput]}");
        cars.Add(ownedCars[userInput]);
    }

    public static void AdminMode()
    {
        Car.ListCars(cars);
        
        Console.WriteLine("\nWhat Car would you like to remove from the lot? (Please enter the index of the car)");
        
        int userInput = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"You have removed this car from the lot : {cars[userInput]}");
        
        cars.RemoveAt(userInput);
    }
    
}

public class UsedCar : Car
{

    private double _mileage;

    public double Mileage
    {
        get { return _mileage; }
        set { _mileage = value; }
    }

    public UsedCar() : base() // Default UsedCar ctor, with base Car ctor default values as well
    {
        _mileage = 0;
    }

    public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
    {
        _mileage = mileage;
    }

    public override string ToString()
    {
        return $"Car: {Make}\tModel: {Model}\tYear: {Year}\tPrice: {Price}\tMileage: {Mileage}";
    }
    
}