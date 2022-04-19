namespace myfirstapplication;

internal class Exercise8
{
    /*
     Write a constant at the class level. The constant should be Foot with a
    value of 12 to represent number of inches in a foot. Write a method that
    takes 1 parameter and a void return type. this method will convert feet
    to inches. The formula that you would use will be the parameter * Foot. Your
    parameter will represent the number of feet to convert to inches. Using
    a console writeline statment, print the results. Test your method using the
    number three to see if you get thirty-six.
     */

    public const int Foot = 12; // 12 inches in a foot

    public void FeetToInches(int value)
    {
        int total = value * Foot;
        Console.WriteLine(total);
    }


    /*
     Write a static method that takes 2 int parameters and a void return type.
    This method will be use to calculate the length and width of a rectangle or
    square. This formula is length x width. The first parameter should represent
    the length and the second parameter should be width. Using a console.writeline
    statement, print the results. Test your method and add what you used to test
    as a comment.
     */

    public static void LengthXWidth(int length, int width)
    {
        int total = length * width;
        Console.WriteLine(total);
    }

    /* what i used to test:
     Exercise8.LengthXWidth(4, 5);
    output: 20
    */
} // end class
