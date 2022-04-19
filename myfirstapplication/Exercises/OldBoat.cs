namespace myfirstapplication;

internal class OldBoat : Boats
{

    public int Age
    {
        get => Age;
        set => Age = value;
    }

    // 1st construcor
    public OldBoat(string shape, string wood, int length, int age)
    {
        Age = age;
    }

    //2nd Constructor
    public OldBoat(string shape, string wood, int age)
        :this(shape, wood, 50, age) { }

    //third Constructor
    public OldBoat()
        :this("Round", "Maple", 250) { }


}
