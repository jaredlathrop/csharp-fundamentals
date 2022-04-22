namespace myfirstapplication;

/*
 1.Write a method that has no parameters and a no return type. Create a List<T>
ofyourHorse objects. When creating your list, utilize all the constructors you
created with your Horse class. Using a foreach loop, printout the results of your
collectionusing a Console WriteLine statement.

2.Write a method that has no parameters and noreturn type. Using only the data
you used when building your favorite movies from exercise 15, create a Dictionary
collection that takes an int key and string value. When adding Dictionary elements
,pick an int value as the key and use the favorite movies data as the string.
Using a foreach loop, print out the results of your collection using a Console
WriteLine statement.

 */

public class Exercise16
{
    public void MyHorse()
    {
        // creating list from horse
        List<Horse> horseObj = new List<Horse>();
        // creating the constructors
        horseObj.Add(new Horse()); 
        horseObj.Add(new Horse("Black", "female"));
        horseObj.Add(new Horse("Brown", "Male"));

        // for each to write out the horses.
        foreach (Horse item in horseObj)
        {
            Console.WriteLine(item);
        } // end method
        /* the output keeps printing out myfirstapplication.horse and I can't 
         figure out why.
        */
    }
    public void MovieDict()
    {
        // creating dictionary
        Dictionary<int, string> movies = new Dictionary<int, string>();
        // adding movies from Exercise15 to dictionary
        movies.Add(10, "Harry Potter");
        movies.Add(20, "Before I fall");
        movies.Add(30, "Batman");

        // For each statement so we can make the console.writline that prints results
        foreach (KeyValuePair<int, string> movie in movies)
        {
            // Console.Writeline using interpolation to write the key and the value
            Console.WriteLine($"Key: {movie.Key} Value: {movie.Value}");
        }


        }
    }


 // end class