
namespace myfirstapplication;

// Exerice 5 Expressions and Pattern Matching

public class Exercise5
{
    /*
     Problem 1: Write a method that takes 2 int parameters and an int return type
    using the formula below from Ohm's law, determine the voltage. the first method
    parameter will represent current and the second parameter will represent resistance
    using the func<int, int, int? and a lambda experssion, determing the voltage
    calculation and return the value. a. voltage = current x resistance.
     */

    public int Problem1(int current1, int resistance1)
    {
        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        int value = voltage(current1, resistance1);
        return value;
    }

    /*
     Problem 2 Write a method that will take 1 char parameter and a string return type.
    Using a switch expression and teh table below, return the description.
    If the value does not match the grade, return the default message. "not a
    valid grade e - excellent, v- very good, g-good, a-average, f-fail.
     */

    public string Problem2(string able)
    {
        string result = able switch
        {
            "E" => "Excellent",
            "V" => "Very Good",
            "G" => "Good",
            "A" => "Average",
            "F" => "Failt",
            _ => "Not a valid grade",
        }; return result;

    } // end method

    /* Write a method that takes 1 argument a void return type. Using a relational
     pattern and switch expression, determine a size of popcorn based on the table
    below and using a console.writeline, print the popcorn size
    */

    public void Problem3(int size)

    {
        string result = size switch
        {
            > 0 and <= 3 => "Microwave bag",
            > 3 and <= 16 => "Movie snack",
            > 16 and <= 32 => "Movie cup",
            > 32 and <= 64 => "Movie tub",
            _ => "We don't have that size"
        };
        Console.WriteLine(result);
    }
 
} // End class