namespace CarLotLab;

class Program
{
    
    static void Main(string[] args)
    {
        
        Car car1 = new Car("BMW", "325i", 2006, 15000M);
        Car car2 = new Car("Ford", "EcoSport", 2020, 20000M);
        Car car3 = new Car("Tesla", "Model S", 2025, 80000M);
        UsedCar usedCar1= new UsedCar("BMW", "325i", 2006, 15000M, 10000);
        UsedCar usedCar2= new UsedCar("Ford", "EcoSport", 2020, 20000M, 1000);
        UsedCar usedCar3 = new UsedCar("Tesla", "Model S", 2025, 80000M, 500);
        
        Car.AddCar(car1);
        Car.AddCar(car2);
        Car.AddCar(car3);
        Car.AddCar(usedCar1);
        Car.AddCar(usedCar2);
        Car.AddCar(usedCar3);

        GeneralPurpose.AddSeperator("ListCars Test");
        
        Car.ListCars(Car.cars);

        GeneralPurpose.AddSeperator("BuyCar Test");
        
        Console.WriteLine("What Car would you like to buy? (Please use the index listed for the car)");
        
        int userInput = int.Parse(Console.ReadLine());
        
        Car.BuyCar(userInput);

        Car.ListCars(Car.ownedCars);
        
        Car.RemoveCar(userInput);

        GeneralPurpose.AddSeperator("AdminMode Test");
        
        Car.AdminMode();
        
        // Car.BuyBack();

    } // End of Main()
    
} // End of Program class