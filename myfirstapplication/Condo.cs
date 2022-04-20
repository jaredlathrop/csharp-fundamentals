namespace myfirstapplication;

internal class Condo : House
{
    private string _balcony;

    public string Balcony
    {
        get { return _balcony; }
        set { _balcony = value; }
    } // end property


    public Condo()
        : this("second floor") { }


    public Condo(string balcony)
        : this("concrete", "steel", "blue", 45, balcony) { }

    public Condo(string foundation, string roofType, string doorColor,
        int windowSize, string balcony)
        : base(foundation, roofType, doorColor, windowSize)
    {
        _balcony = balcony;
    }

    public override void DoorOpenClose()
    {
        Console.WriteLine($"The {DoorColor} door is creeking at the condo");
    }

    public void Maintenance()
    {
        Console.WriteLine($"Fixing the {_balcony} on apartment 2");
    }
    



} // end class

