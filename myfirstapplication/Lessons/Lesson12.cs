namespace myfirstapplication;

/*
 What is polymorphism?
it means many forms. Objects of a child class may be treated as objects of
a base class in places such as method parameters and collections or arrays
When this happens the objects declared type is no longer identical to it's
runtime type

the 4 keywords of polymorphism
* virtual - a keyword used on a parent class to allow it's methods to be 
overridden by a child class
* Override - a keyword used on a child class to override a parent class so
it can define its own behavior
* Sealed - a keyword sued on a child class to stop virtual inheritance from 
additional derived classes
* New - a keyword used on a child class to allow it to define members of the
parent class that doesn't participate in virtual inovation

When you apply the virtual keyword to a property, the virtual get accessor
cannot be inlined like a regular property. This is becasue the comipler does
not know at compile0time which accessor may be actually called at runtime.

Method Overloading
Methods like constructors can be overloaded. this concept is also an aspect
of polymorphism. You can redfine a method in more than one form. Method overloading
can be done in different ways:
Number of parameters, data types of parameters, order of parameters.

Using base in methods
There may be times where your derived class override a base class method and still
needs to run the base method code. This is wehre you can use the keyword
base + themethodsname to run the base method code along side
the override method code
 */


// Base class with a method declared virtual for overriding
public class Fruit
{
    public virtual void EatFruit()
    {
        Console.WriteLine("I eat fruit.");
    }

    public void EatFruit(int quantity)
    {
        Console.WriteLine($"I eat {quantity} portions of fruit.");
    }

} // end class



public class Apple : Fruit
{
    public override void EatFruit()
    {
        base.EatFruit();
        Console.WriteLine("I eat apples");
    }
} // end class