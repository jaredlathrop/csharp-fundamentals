namespace myfirstapplication;

/*
 What is enum
used to declase an enumeration, a distint type that has a set of named constants
called an enumerator list. Typically it is best to define an enum directly
within the namespace, much ike you would a class. This would allow all classes
to utilize. You can however decalre an enum within a class or struct

BY default the enum type is int

Enums can use initializers to override the defaule values:


Casting Enum
A vairable of an enum type can be assigned any value within the range of the
underlying type. The underlying type specifies how much storage is allocated for each
enum. You will need to use an explicit cast to convert from enum to an integral type.

USing an enum in switches
Enums are really good when used with switches. Because the enut is a set of named constants,
in order to have accuracy in a switch statement, you can narrow down the choices

Tuples provide a syntax for grouping multiple data elements in a lightweight data
structure. You can provide the types and an optional field name. The group is
done using parenthesis with each type seperated by a comma. When assigning
literals to a tuple, they also are wrapped in parenthesis and seperated by
a comma.

Use case for tuples
one of the most common use cases for tuples is a method return. Instead of defining
out method parameters, you can group method results in results in a tuple return

 */
 /*
  Enums can be created either within a clarr or struct, or in the namespace
  */
 public enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri}
public enum IceCream { Vanilla, Chocolate, Strawberry, RockyRoad}

internal class Lesson15
{
    public void EnumExample()
    {
        Console.WriteLine(Day.Mon); // displays value
        Console.WriteLine((double)Day.Tue); // displays number value
    } // end method

    public string FavoriteIceCream(IceCream flavors)
    {
        // enum using a swithc expression to narrow down choices. 
        string message = flavors switch
        {
            IceCream.Vanilla => $"My favorite is {IceCream.Vanilla}",
            IceCream.Chocolate => $"My favorite is {IceCream.Chocolate}",
            IceCream.Strawberry => $"My favorite is {IceCream.Strawberry}",
            _ => $"My favorite is {IceCream.RockyRoad}"
        };
        return message;
    } // end method

    // Tuples are a group of types using parenthesis and seperated using a comma
    public void TupleEx()
    {
        (double, int) able = (2.3, 5);
        Console.WriteLine($"Tuple with elements {able.Item1} and {able.Item2}");
        (double value, double value2) beta = (3.3, 5.4);
        Console.WriteLine($"Tuple with elements {beta.value} and {beta.value2}");
    }

    // Using a tuple to return multiple results in a method
    public (int able, int beta, int delta) TupleReturnExample(int value1, int value2)
    {
        int alpha, bravo, charlie;
        if(value1 >= 10 || value2 <= 50)
        {
            alpha = ++value1;
            bravo = ++value2;
            charlie = alpha + bravo;
        } else
        {
            alpha = 1;
            bravo = 2;
            charlie = 3;

        }
        return (alpha, bravo, charlie);
    }


} // end class

