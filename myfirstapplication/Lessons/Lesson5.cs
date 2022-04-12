/*
    What are Delegates?
    before we look at the lambda expression, we must learn about delegates
    . A delegate is a type the represents refrences to methods with methods
with a specific paramater declaration and return type. delegates are used to
pass methods as arguments in other methods.
Instantiating a delegate
When you instantiate a delegate, you can associate its instance with any method
that is compatible by its signature and return type. you can call a method through
the delegate instance.
Built in generic delegates
Func delegate- can have 0 to 16 parameters of diferent types with an out parameter
return. Func<int, int>
Action delegate - like the func delegate, but with no return type
Predicate delegate
Anonymous methods

Lamda Expression
a lambda expression is used to create an anonymous function. This type of function
can be passed around like a variable or a parameter in a method call. it
utilizes the lamda declaration operator in order to separate the lamdas paramater
list from its bod. The left side is oyu input parameters while the right side
is either:
Expression Lamda = an expression on the right side returns the result of the expresion
Statement lamda - resembles an expression lamda except that its statement is
enclosed using curly braces.
 
 Switch expression
The switch expression arms are sperated by commas, with each arm containg:
a pattern, optional case guard, the => token (lamda), and the expression

Relational Patterns
Beginning in C# 9 you use a relational pattern to compare an expression result with a constant.
with this pattern you can use any of the relational operators (<, >, <=, =>). The right
side represents the constant expression. The constant can be of an integer,
floating-point, char, or enum type.

Logical Patterns
Beginning in C# 0, yuo can use the not, and, and or pattern combinations
not - pattern matches an expression when the negated pattern doesn't match
the expression.
and - pattern matches an expression when both patterns match the
expression
or - pattern matches an expression when either pattern matches the expression

 */



namespace myfirstapplication;

internal class Lesson5
{
    // Delegate
    public delegate void Del(string message);

    /*
    is operator checks if the result of an expression is compatible with
    another type.
    */
    public void IsOperatorEx(int able)
    {
        object bravo = able;
        Console.WriteLine(bravo is int);
        Console.WriteLine(bravo is long);
    } // end method

    /*
     Create a method for delegate example, see above the IsOperatorEx.
    */
    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    } // emd method

    // Method for Func Delegate
    public int Sum(int beta)
    {
        return beta * 2;
    } // end method

    // Lamda using func delegate
    public void LamdaSquare()
    {
        Func<int, int> square = able => able * able;
        Console.WriteLine(square(4));
    } // end method

    // lamda using the action delegate
    public void LamdaGreeting()
    {
        Action<string> greet = name =>
        {
            string greeting = $"Hello {name}! We are learning.";
            Console.WriteLine(greeting);
        };
        greet("Lamda");
    } // end method

    // Basic Switch
    public string BasicSwitch(string able)
    {
        switch (able)
        {
            case "blue":
                return "Favorite color is blue.";
            case "red":
                return "favorite color is red.";
            case "green":
                return "favorite color is green";
            default:
                return "Not sure what my favorite color is.";

        }
    }// end method

    // Switch expression based on the BasicSwitch() method above
    public string FavoriteColor(string charlie)
    {
        string result = charlie switch
        {
            "blue" => "favorite color is blue",
            "red" => "favorite color is red",
            "green" => "favorite color is green",
            _ => "Not sure what my favorite color is."
        };
        return result;
    } // end method

    // Relational pattern compares an expression result with a constant
    public void DrinkSize(int size)
    {
        string result = size switch
        {
            <= 20 => "small",
            <= 32 => "Big Q",
            <= 40 => "Large",
            <= 50 => "X-Large",
            _ => "We do not have that size."
        };
        Console.WriteLine(result);
    } // end method

    //Logical Patern and matches an expression when both match the expression
    public void TemperatureGuide(double temp)
    {
        string result = temp switch
        {
            < -10.0 and < 0 => "Negative Cold",
            >= 0 and < 32.0 => "Freezing cold",
            >= 32.0 and < 49.0 => "Chilly",
            >= 49.0 and < 60.0 => "Nice",
            >= 60.0 and < 90.0 => "Warm",
            >= 90.0 and < 105.0 => "Very Hot",
            _ => "Unkown"
        };
        Console.WriteLine(result);
    }

    // Logicl patten or matches an expression when either matches expression
    public void NumberChoice(int able)
    {
        string result = able switch
        {
            1 or 2 => $"{able} is 1 or 2.",
            3 or 4 => $"{able} is 3 or 4",
            5 => $"{able is 5}",
            _ => $"{able} is not on the list."
        };
        Console.WriteLine(result);
    }

} // end class


