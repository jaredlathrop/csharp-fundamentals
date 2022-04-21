namespace myfirstapplication;

/*
 What is abstract
this modifier is used to indicate an object being modified has a missing or
incomplete implementation. it can be used with classes, methods, properties,
 , indexes and events
Abstract classes are intended to be a parent or base class. They can't be
instantiated on their own. Members marked as abstract must be implemented by
non-asbtract classes that are children of the abstract class.

An abstract class cannot be instantiated. abstract cancontrain both abstract and
non-abstract methods, properties, indexers, and events. Abstract members can not be
declared in a non-abstract class.

The abstract keyword is used when creating an abstract class. An abstrand class
class may provide implementations for all interface members. We will cover inter
faces later in this lesson
You can notmodify an abstract class with the sealed modifier due to them having
contradicting meanings. The sealed modifer prevents a class from being
inherited and teh abstracy modifier requires a class to be inherited.

Abstract Methods
Using the abstract modifier with a method indicates that it does
not contain an implementaiton. When you use abstract at this level, it
implicitly becomes a virtual method. Meaning that you don't use the keyword
virtual with an abstract method.
When creating abstract methods, you do not include the method body. This
means you terminate it with a semi colon instead of using curly braces.
You also cannot use the static and virtual modifiers with abstract methods

What is an interface?
An interface contains definitions for a group of related functionalities that
a non-abstract class or a struct must implement.
Coding standard suggests prefixing your interfaces with the letter I. A class can
implement multiple interfaces, but only extend one class. Interfaces members
are public by default. So you odnt have to use an access modifier when creating.
By using interfaces you can include behavior from multiple sources in a class.
This is important becasue the language doesn't support multiple inheritance of classes.
In addition you must use an interface if you want to simulate inheritance for structs, because
they can't inherit from another struct or class.
 */



// Abstract Modifier and interfaces


public interface ILesson13Interface
{
    int Miles { get; }
    int ConvertMilesToYards();
} // end interface



internal abstract class Lesson13Base : ILesson13Interface
{
    protected int num;

    // abstract properties
    protected abstract int Inches { get; }
    protected abstract int Feet { get; }

    // implemented from interface
    public abstract int Miles { get; }

    // Constructor
    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    //  Creating Abstract Methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();

    // implemented from interface
    public abstract int ConvertMilesToYards();



} // end class




// Our Derived class will implimenet our abstract class members.
internal class Lesson13Derived : Lesson13Base
{
    // implementing abstract properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;
    // Implementing interface
    public override int Miles { get; } = 1760;

    public Lesson13Derived(int val)
    : base(val) { }


    // implementing abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    } // end method
    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    } // end method

    // Implementing interface method
    public override int ConvertMilesToYards()
    {
        return num * Miles;
    }

} // end class