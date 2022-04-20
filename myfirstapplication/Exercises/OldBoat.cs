namespace myfirstapplication;

internal class OldBoat : Boats
{

    public int Age
    {
        get => Age;
        set => Age = value;
    }

    // 1st construcor
    public OldBoat(string shape, string wood, int size, int age)
    {
        Age = age;

    }

    //2nd Constructor
    public OldBoat(string shape, string wood, int age)
        :this(shape, wood, 50, age) { }

    //third Constructor
    public OldBoat()
        :this("Round", "Maple", 50) { }

    
    /* EXERCISE 12 PROBLEM 4 In your child class of Boat, using the overridekeyword create a method
    that has the same name as the virtual method from Boat. Add a Console
    WriteLine that provides a different message from the Boat.
    */

    /* public override void SailRaise()
    { 
        Console.WriteLine("The old boat has raised it's tattered sails");
    } */
}
