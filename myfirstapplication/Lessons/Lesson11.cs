namespace myfirstapplication;

public class Polygon
{
    /*
     What is inheritance
    Inheritance allows you to create new classes that reuse, extend and modift hte behavior
    defined in other classes. In C# the parent class, is called the base class,
    and the child class is called the derived class. A derived class can only have
    1 direct base class

    What is the base keyword?
    The base keyword is used to access members of the base class from the
    derived class. There are 2 implementations - call a method on the base class
    that has been overridden & specify which base class constructor to call when
    creating instancses of the subclass
    you can't use the base keyword in static classes. 

     */

    // properties
    protected int NumberofSides { get; set; }
    /*
     Base constructor. if a derived class does not implement
    a base class constructor explicitly, the base constructor
    is called implicitly.
     */

    public Polygon()
    {
        NumberofSides = 1;
    }

    /* This constructor will be accessed from the child class 
    using the base in its constructor
     */
    public Polygon(int sides)
    {
        NumberofSides = sides;
    }

    // the method
    internal double CalcInteriorAngle()
    {
        return (NumberofSides - 2) * 180 / NumberofSides;
    }
} // end class

// Square is the derived (child) classs
public class Square : Polygon
{
    public Square()
        :base(4)
    {
        // NumberofSides = 4;
    }
} // end class

public class Triangle : Polygon
{
    public Triangle()
        :base(3)
    {
        // NumberofSides = 3;
    }
}

