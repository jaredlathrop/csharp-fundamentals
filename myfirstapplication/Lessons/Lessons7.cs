namespace myfirstapplication;

/* 
 What is a struct?
A value type that is typically used to encapsulate small groups of related variables,
such as part of a book. It should be used for lightwieght objects such as point,
rectangle, color, or group. This type uses the struct keyword and has
value semantics. That means a variable of this type contains an instance of the type,
rather than a reference to it. It is recommended you define immutable structure types
Structs can contain: constructors, constants, fields, properties, indexers, operators,
evants, and nested types. If several members are required, you should conisder using a
class.

Object.ToString method
This method represents the current object and reutrns the string
representation. All objects derive from system.object, so this method is one of a
handful of methods associated with System.Object
This method is a major formatting method that converts an object
to its string representation so it is suitable for display. Types will frequently
override this method to provide better information. This override is a concept
that will be cover in more detail in the polymorphism lesson later in the course.

Why use struct?
The reason you would use a struct instead ofa class is for memory. If you had
a list of 1000 point objects, you would eat up a lot of memory referencing each
object, but with a struct it would be less expensive

Read-Only Struct
Uou can use the readonly modifier to declare that struct type is immutable
All mmebers of readonly struct must be:
- Any field declaration must have the readonly modifier
- Any peoperty must be read-onlu including property styles we will cover
This guarentees taht no member of a readonly struct can modify that state.

 */

/*
 A struct is a value type while a class is a reference type. You should use a struct for small
objects that need to be memory dependent.
 */
internal struct Location
{
    private double _longitude, _latitude;

    // properties
    public double Latitude
    {
        get { return _latitude; }
        set { _latitude = value; }
    } // end method

    public double Longitude
    {
        get { return _longitude; }
        set { _longitude = value; }
    } // end method

    // Constructor
    public Location(double longitude, double latitude)
    {
        _longitude = longitude;
        _latitude = latitude;
    } // end method

    public override string ToString()
    {
        return $"{_longitude} {_latitude}";
    }

} // end struct

public readonly struct Student
{
    private readonly int _id;
    private readonly string _name;

    public int StudentId
    {
        get { return _id; }
        // set { _id = value; }
    }

    public string StudentName
    {
        get { return _name; }
        // set { _name = value; }
    }

    public Student(int studentId, string studentName)
    {
        _id = studentId;
        _name = studentName;
    }

} // end struct
