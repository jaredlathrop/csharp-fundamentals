namespace myfirstapplication;

/*
 Exception handeling helps yo deal with unexpected or exceptional
situations that occur when a program is running. Exception handling uses
the try catch & finally keywords to attempt to do actions, handle failures,
and cleanup resourcess.

The try block
The try block is usde to seperate code that might be affected by an exception
A try block requires 1 or more catch block or a finally block, or both

The catch block
This block can specify an exception type. You can call the mexception filters
Each exception type should derive from system.Exception

The finally block
This block enables you to clean up actions that are performed in the try block
This block always executes regarless of whether the try block exectures, or
a catch executes
The finally block can be used for releasing resources such as
database connection and graphic handles without waiting on the garabage collector
in the runtim

 */

internal class Lesson17
{
    // throw
    public void MyThrowExample(House house)
    {
        if(house == null)
        {
            throw new NullReferenceException("House object is null");
        }
        else
        {
            Console.WriteLine(house.DoorColor);
        }
    }


    public void MyExceptionExample(House house)
    {
        try
        {
            Console.WriteLine($"The house door color is {house.DoorColor}");
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine($"Null reference was thrown: {ex.Message}");
        }

    }


    // try/catch/finally
    public void MyArrayException()
    {
        string[] names = { "David", "Matt", "Jody" };
        string[] values = { "257", "425", "385" };

        try
        {
            byte beta = byte.Parse(values[1]);
            Console.WriteLine(beta);
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Please provide at least 1 arg: {ex.Message}");
        }
        catch(FormatException fe)
        {
            Console.WriteLine($" That is not a number: {fe.Message}");
        }
        catch(OverflowException ov)
        {
            Console.WriteLine($"You have given more than a byte: {ov.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block has been executed");
        }

    }
} // end class


