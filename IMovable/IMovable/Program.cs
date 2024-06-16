using System;

// Interface defined
public interface IMovable
{
    void Move();
}

// Class implementing the interface
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class implementing the interface
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call the Move() method on each instance
        car.Move(); // Output: Car is moving
        bicycle.Move(); // Output: Bicycle is moving
    }
}