namespace myfirstapplication;

public class Exercise3
{
    /* 
    Write a method that takes 1 int argument and an int return type. Utilize the 
    modulus operator to complete this task. Assign the data values below to their
    own variables. Use the Console.WriteLine statement on the first 4 variables
    listed below and calculate the modulus with the passed in argument parameter.
    Using the last variable below, calculate the modulus with the passed in argument
    paramete return it.
    a. 15, b. 456, c. 23, d. 89, e. 245
    */

    public int Question1(int arg)
    {
        int myArg = arg;
        int able = 15, beta = 456, charlie = 23, delta = 89, echo = 345;
        Console.WriteLine(able % myArg);
        Console.WriteLine(beta % myArg);
        Console.WriteLine(charlie % myArg);
        Console.WriteLine(delta % myArg);
        return echo % myArg;
    } // end method



    /* 
    Write a method that takes no arguments and a void return type. Utilizing
    the math problem in this task, fill in any missing pieces to get the output.
    10 + 32 * 12 / 3. Write a Console.WriteLine to solve each output.
    a. output 138, b. output 168, c. output 131
    */

    public void Question2()
    {
        Console.WriteLine(10 + 32 * 12 / 3); //138
        Console.WriteLine((10 + 32) * 12 / 3); // 168
        Console.WriteLine((10 + 32 * 12) / 3); // 131
        
    } // end method



    /* 
    Write a method that takes two short type arguments and a void return type.
    Using compound assignement operators, use the first argument parameter as the
    left operand to geth teh result. Print each using a Console.WriteLine statment.
    a. +=
    b. /=
    c. *=
    d. %=
    */
    public void Question3(short arg1, short arg2)
    {
        // a. +=
        arg1 += arg2;
        Console.WriteLine(arg1);
        // b. /=
        arg1 /= arg2;
        Console.WriteLine(arg1);
        // c. *=
        arg1 *= arg2;
        Console.WriteLine(arg1);
        // d. %=
        arg1 %= arg2;
        Console.WriteLine(arg1);


    }// end method

    /*
    Write a method that takes two bool type arguments and a void return type.
    Using boolean logical operators &, |, ^, and || to complete this task. Use
    a console.WrtieLine statement to calculate each result using the operators.
    The second argument is the left operand. Use the below values when testing
    your method. Using comments, provide your output results inside the method
    after your statements

    a. arg1 = true, arg2 = false
    b. arg1 = false, arg2 = false
    c. arg1 = true, arg2 = true
    d. arg1 = false, arg2 = true
    */

    public void Question4(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);
        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);

    } // end method
    

} // end class
