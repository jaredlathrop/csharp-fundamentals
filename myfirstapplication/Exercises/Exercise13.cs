namespace myfirstapplication;

/*
1.In your Exercise13.cs file, change your class to an Interfaceand name it
IMovement.This interface will have 1 property. The property will an int and
called Speed. It will have a get and init.

2.Under the interface you will
create an Abstract class called WaterBirds. This abstract class will implement
the IMovement interface. The interface property should be implemented in the
Abstract class as an abstract property. Create two abstract methods for the
abstract class that is related to WaterBirds. Create a constructor that will
take an int parameter and be assigned to the Speed property.

3.Under the Abstract class Waterbirds, create a derived class that will extend
the WaterBird class. Implement the abstract methods and property.Use Console
Writeline statements in your methods that provide information related to the
methods. One of them should use an Interpolation string and consume the
Speed property.Create a constructorthat will take an int parameter and use
the :base()to pass that int value back to the base Abstract class.

 */

// creating interface
public interface IMovement
{
    //interface property with get and init
    int Speed { get; init; }

} // end interface



// making the abstract class
internal abstract class WaterBirds : IMovement 
{
    // implementing property from interface
    public abstract int Speed { get; init; }

    // creating 2 abstract methods
    public abstract void Eat();
    public abstract void Fly();

    // creating constructor with int parameter assigned to the Speed property
    public WaterBirds(int speed)
    {
        this.Speed = speed;
    } // end constructor

} // end abstract class

// Creating derived class from Waterbirds
internal class Duck : WaterBirds
{
    //implementing a property and setting a default value for speed
    public override int Speed { get; init; } = 25;

    // implementing the method Fly
    public override void Fly()
    {
        Console.WriteLine($"The duck dives at {Speed} mph.");
    }
    // implementing the method eat
    public override void Eat()
    {
        Console.WriteLine("The duck is eating.");
    }

    // using :base to pass int value back to the base of the abstract class
    public Duck(int val)
    :base(val) { }
}