namespace myfirstapplication;

public class Exercise4 {
    /* Problem 1. Write a method that takes 2 string arguments and a void return type. Using
     and if-else statement, compare two strings to each other. Using a Console.
    writeline statement, print out the results of whether the strings are equal.
    provide a commen inside the method that says what strings you used during
    testing.

    for test 1 i used dog for arg1 and cat for arg2, this triggered the else statement
    for test 2 i used cat for arg1 and cat for arg2, this triggered the if statement
    */
    public void Problem1(string arg1, string arg2)
    {
        if (arg1 == arg2)
        {
            Console.WriteLine("Arguments 1 & 2 are the same");
        }
        else
        {
            Console.WriteLine("Arguments 1 & 2 aren't the same");
        }
    } // end method

    /*
        Write a method that will take 1 char argument and a string return type.
    using a switch and the table below, return the description. if the value
    doesn't match the grade ,return the default mesaage, "Not a valid grade".
    E-Excellent, V-VeryGood, G-Good, A-Average, F-Fail
    */
    public void Problem2(string arg1)
    {
        switch (arg1)
        {
            case "E":
                Console.WriteLine("E - Excellent!");
                break;
            case "V":
                Console.WriteLine("V - Very Good");
                break;
            case "G":
                Console.WriteLine("G - Good");
                break;
            case "A":
                Console.WriteLine("A - Average");
                break;
            case "F":
                Console.WriteLine("F - Fail");
                break;
            default:
                Console.WriteLine("Not a valid grade");
                break;
        }
    } // end method

    /*
     Write a method that takes no arguments and a void return type.
    using an iteration statement, display all the numbers divisble by 3 from 0
    to 30 Utilize a modulus to obtain your results 
     */

    public void Problem3()
    {
        for (int alpha = 0; alpha <= 30; alpha++)
        {
            if ((alpha % 3) == 0)
            {
                Console.WriteLine(alpha);
            }
        }
    }

    /*
     Question 4 
     */


} // end class


