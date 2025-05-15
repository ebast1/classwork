namespace CarLotLab;

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