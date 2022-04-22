
namespace myfirstapplication;

internal class Exercise17
{
    /*
     1.Write a method that has two int parameters and no return type. You will
    use a try/catch for this method. Create a division problem in the try block.
    The catch block will utilize the DivideByZeroException. Provide a Console
    WriteLine messagefor both the try block and the catch block. The one
    in the try block should display the answer to the division problem.
    The one in the catch block should have a message using Interpolation along with a variable.
    Messagesyntax. Test the method with different numbers, including 0 so
    you can ensure the catch executes.

    2.Write a method that has a horse parameter and no return type.
    Using and if statement, determine if your horse is null. If it is null,
    use the throw keyword and a message to indicate it is null. If the horse is
    not null, use a Console WriteLine statement to print out one of your horse
    properties
     */

    // creating method for problem 1 that has 2 int parameters
    public void Problem1(int par1, int par2)
    {
        // try block that has cnosole writline for divsion problem. 
        try
        {
            Console.WriteLine(par1 / par2);
        }

        // creating a catch using DivideByZero with interpolation that displays
        // a message via a console.writlline statement
        catch(DivideByZeroException exc)
        {
            Console.WriteLine($"You can't divide by 0: {exc.Message}");
            /*
             Output when enterint 0 as par2:
            You can't divide by 0: Attempted to divide by zero.
             */
        }
    } // end method

    // creating method with horse paramenter
    public void Problem2(Horse horse)
    {
        if (horse == null)
        {
            // creating the throw with NullReferenceException
            throw new NullReferenceException("The horse is null");
        }
        else
        {
            // To print horse properties
            Console.WriteLine(horse.HorseColor);
        }
        /*
         OUtput when setting testHorse to null:
         Unhandled exception. System.NullReferenceException: The horse is null
         
         at Program.<<Main>$>g__Lesson17Out|0_0() in /Users/jaredlathrop/My Repository
        /csharp-fundamentals/myfirstapplication/Program.cs:line 57
         at Program.<Main>$(String[] args) in /Users/jaredlathrop
        /My Repository/csharp-fundamentals/myfirstapplication
        /Program.cs:line 44
         */
    }



}

