namespace myfirstapplication;

/*
 Change the type from class to struct. Change the name of the sturct from Exercie7
to employee. The filename should not be changed. Create 2 struct variables.
the first one will be an int named _id. The second should be string and be named
_name. Create a constructor that takes 2 arguments, first being int, second being string.
The struct variables should be assigned to the constructor parameters. Create
properties for these 2 variables.
 */


internal struct Employee
{
    private int _id;
    private string _name;
    
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    }
}

/*
 Create a record based on your boat object from OOP lesson. In your record body,
include the boat method that you defined. This record can be in the same file as
you exercise1. Just put the code under it like seen in the lecture. test your record
to ensure its working correctly.
 */
internal record Boat(string raise)
{
    public void RaiseSail()
    {
        Console.WriteLine(raise);
    }
}
