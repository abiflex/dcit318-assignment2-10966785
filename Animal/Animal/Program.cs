using System;

// The based class we were asked to create is Animal
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

//  A derived class 'Dog' that overrides the MakeSound() method to print "Bark".


public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

//  Another derived class 'Cat' that overrides the MakeSound() method to print "Meow"

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// The main method class
public class Program
{
    static void Main(string[] args)
    {
        // Here we created instances of Animal, Dog, and Cat
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Over here, we called the MakeSound() method on each instance
        animal.MakeSound(); 
        dog.MakeSound(); 
        cat.MakeSound(); 
    }
}