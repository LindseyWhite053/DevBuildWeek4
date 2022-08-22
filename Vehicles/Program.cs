Sedan mycar = new Sedan(4, "Blue", true, 4);


RaceCar myracecar = new RaceCar(4, "Red", 400);


// Polymorphism - calling the correct version of the method 
Vehicle something;
something = mycar;
something.Drive();

something = myracecar;
something.Drive();



class Vehicle
{
    public int WheelCount;
    public string Color;

    public Vehicle(int _wheelCount, string _color)
    {
        WheelCount = _wheelCount;
        Color = _color;
    }

    //virtual means you can override it in derived classes
    public virtual void Drive()
    {
        Console.WriteLine("I am driving");
    }
}

class Sedan : Vehicle
{
    public bool HasHatchBack;
    public int DoorCount;

    public Sedan (int _SedanWheelCount, string _SedanColor, bool _hasHatchBack, int _doorCount) 
        : base (_SedanWheelCount, _SedanColor)
    {
        HasHatchBack = _hasHatchBack;
        DoorCount = _doorCount;
    }

    public override void Drive()
    {
        Console.WriteLine("I am driving speed limit!");
    }

}

class RaceCar : Vehicle
{
    public int EngineSize;

    public RaceCar(int _WheelCount, string _Color, int _EngineSize)
        : base(_WheelCount, _Color)
    {
        EngineSize = _EngineSize;
    }

    public override void Drive()
    {
        Console.WriteLine("I am driving really fast!");
    }
}