/*
 Constructors methods and more

Intro to properties
A property is a member tha provides a flexible mechanism to read, write, or compute the value
of a private field. They act as public data members but are actually special medthods
called accessors.
Properties enable a class to expose a public way of setting and getting values,
while hiding implementation. The get property is used to return the value while the
set property is used to assign a new value
This is also a basic concept of encaspulation, but we are not fully covering properties here,
later we'll go deeper into encapsulation

Method Parameters
Up to this point, we have been writing parameters with methos, these parameters are passed to the called
method by value. that value can be changed
in the method, but that change is not retained outside the method.
we cam change this behavior using method parameters. the following can be used when
declaring method parameters.
* params - specifies this parameter may take a variable number of arguments
* in- specifies this parameter is passed by reference but is only read by the called method
* ref - specifies this parameter is passed by reference and may be read or written by the called
* method
Delegates

A delegates ia type that represents references to methods wtih a particular
parameter list and return type. when you instantiate a delegate, you can associate its instance with any method
with a compatible signature and return type. you can invoke (call_ the method through the delegate instance

Delegate types are sealed and cannot be derived from. it is also not possible to derivce
custom classes from delegate. because the instantiated delegated is an object,
it can bes passed as a parameter, or assigned to a property. This allows a method to accept a
delegate as aparameter, and call the delegate at some later time.
This is known as asynchronous callback, and is a common method of notifying a caller
when a long process has completed

Combining Delegates
Delegates have the ability to supporty multicast. This means a delegate can target more than one method
Invoking a delegate will call all methods that are assigned in the order they are added
Only delegates of the same type can be combined

Using + or += will combine delegate instances
Using - or -= will remove delegate instances.



 */


namespace myfirstapplication;

internal class Lesson6
{
    // Delegates
    public delegate void TryOn(string type);
    public delegate void TryOnAnotherHat(string type);


    // private class variables
    private string _hatType;
    private int _hatSize;

    // properties
    public string HatType
    {
        get { return _hatType; }
        set { _hatType = value; }
    } // end method

    public int HatSize
    {
        get { return _hatSize; }
        set { _hatSize = value; }
    } // end method

    // Default Constructor
    public Lesson6()
    {
        // Console.WriteLine("Hello Lesson 6");
        TryOnAnotherHat tryHat = TryOnHat;
        TryALagerHat("Fadora", 7, tryHat);
    } // end method

    // Constructor with 1 parameter
    public Lesson6(int value)
    {
        Console.WriteLine($"Contructor = {value}");
     } // end method

    // Constructor with 2 variables
    public Lesson6(string type, int size)
    {
        _hatType = type;
        _hatSize = size;
    } // end method

    // The in parameter modifier is passed by reference. The argument can not
    // be modified as it as read-only
    public void InExample(in int value)
    {
        int total = value + 5;
        Console.WriteLine($"In value + 5 = {total}");
    } // end method

    // the ref parameter modifier is passed by reference. The value changed in
    // the method affects the called variable
    public void RefExample(ref int value)
    {
        value += 5;
        Console.WriteLine($"RefExample = {value}");
    } // end method

    // the out parameter modifier is passed by reference. the out variable passed
    // in does not have to be initialized.
    public void OutExample(out int value)
    {
        value = 42;
    }

    // method for delegates
    public void TryOnHat(string message)
    {
        Console.WriteLine($"TryOnHat - {message}");

    }

    public void TryALagerHat(string type, int oldSize, TryOnAnotherHat anotherHat)
    {
        anotherHat($"I tried on a {type} hat at size {++oldSize}");
    }

}// end class

