
namespace myfirstapplication;

/*
 What are arrays
Multilpe variabels of the same type can be stored in a data structure of an array
you declare an array by specifying the type of elements. If you want to store
different types in an array, that array must be of type object.
An array utilizes brackets [] in it's declaration. Array can be single-dimensional
multidimensioanl or jagged. The length of eachd imension and the number
of each dimension are established when the array instane is created. These
values cannot be changed during the lifetime of the instance.
Default values of numeri array elements is zero, while reference elements is null

Arrays are zero indexed this means the first element in the array is in position 0
Arrays are reference types that derive from the abstract
base class ARray. All arrays implement the Ilist and IEnumerable interfaces
that are part of the .NET runtim. Single dimensional arrays
also implement <T> and IEnumerable <T> interfaces

You can use foreach loop to iterate through an array. you can also use a nested
for loop for a more styles iteratyion through multi-dimensional array
or jagged array.

Jagged array
Considered an array of arrayys. this type can have different sizes for different dimesntions. This
is done by defining the numer of rows int hte first dimension. IF the columns are
provided, then it is no longer considered a jagged array.
 */


internal class Lesson14
{
    public void SingleIntArray()
    {
        int[] intArray = { 2, 5, 34, 56, 28, 32 };

        foreach (int item in intArray)
        {
            Console.WriteLine(item);
        }
         
    } // end method

    public void SingleHouseArray()
    {
        House[] houseArray = new House[3];
        houseArray[0] = new House("concrete", "steel");
        houseArray[1] = new House();
        houseArray[2] = new House("dirt", "bamboo", "green", 4);

        foreach(House house in houseArray)
        {
            Console.WriteLine($"House roof in the collection is {house.RoofType}");
        }

    }

    // multi dimensional array
    public void MultiIntArray()
    {
        int[,] sampleInt = new int[2, 2];
        sampleInt[0, 0] = 2;
        sampleInt[0, 1] = 4;
        sampleInt[1, 0] = 6;
        sampleInt[1, 1] = 8;

        foreach(int item in sampleInt)
        {
            Console.Write($"{item}, ");
        }
    }// end method

 

    public void MultiString()
    {
        string[,] sampleString = { { "happy", "coding", "day" }, { "sad", "deploy", "bugs" } };

        for(int i = 0; i < sampleString.GetLength(0); i++)
        {
            for(int k = 0; k < sampleString.GetLength(1); k++)
            {
                Console.WriteLine(sampleString[i, k]);
            }
        }
    } // end method


    //jagged array
    public void JaggedArraySample()
    {
        int[][] sampleArray = new int[3][];
        sampleArray[0] = new int[] { 2, 4 };
        sampleArray[1] = new int[] { 6, 8, 10 };
        sampleArray[2] = new int[] { 12, 14, 16, 18 };
        foreach(int[] items in sampleArray)
        {
            Console.WriteLine();
            foreach(int item in items)
            {
                Console.WriteLine($"{item}");
            }
        }
    }


} // end class
