namespace myfirstapplication;

internal class Boats
{
    /*
       Create a class based on your boat object. Include your attributes as auto properties.
    Create 3 constructors. The first constructor should have parameters equal to your properties.
    Assign each parameter to your properties. The second constructorshould have 2 parameters.
    Using the :this()keyword, you will pass your information to the first constructor.
    This includes the 2 parameters and default values. For the last constructor,
    you will createthe default constructor. Using the :this()keyword, you will
    pass 2 default valuesin that will pass to the 2ndconstructor.
    Also include in the class, your method for boat.
     */

    // properties
    public string hullShape;
    public string woodType;
    public int length;

    public string HullShape
    {
        get => hullShape;
        set => hullShape = value;
    }

    public string WoodType
    {
        get => woodType;
        set => woodType = value;
    }

    public int Length
    {
        get => length;
        set => length = value;
    }


    // first constructor
    public Boats(string shape, string wood, int size)
    {
        hullShape = shape;
        woodType = wood;
        length = size;
    }

    // second constructor
    public Boats(string hullShape, string woodType)
        :this(hullShape, woodType, 100) { }


    // third constructor
    public Boats()
        : this("V-Shape", "Oak Wood") { }

    // method
    public void SailRaise()
    {
        Console.WriteLine($"The {woodType} boat with a {hullShape} hull has raised" +
            $"it's sails");       
    }

} // end class
