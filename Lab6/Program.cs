using System;

class Car
{
    public string manufacturer;
    public string model;
    public string color;
    public int year;

    
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Manufacturer: " + manufacturer);
    }

    
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    
    public void Repaint(string newColor)
    {
        string oldcolor = color;
        color = newColor;
        Console.WriteLine("your " + oldcolor + " " + year + " " + manufacturer + " " + model + " has been repainted to " + color + ".");
    }
    public void Repair(int price)
    {
        Console.WriteLine("your " + color + " " + year + " " + manufacturer + " " + model + " was repaired for $" + price );
    }
}

class Program
{
    static void Main()
    {
        
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;
        myCar.manufacturer = "Honda";

        myCar.Display(); 

        
        myCar.Start();

        
        myCar.Drive(50);

        
        string description = myCar.GetDescription();
        Console.WriteLine(description);

        
        myCar.Repaint("red");
        myCar.Repair(1000);
        
    }
}
