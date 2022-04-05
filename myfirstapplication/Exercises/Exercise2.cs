
namespace myfirstapplication;

public class Exercise2
{
    // Problem 1
    public void Problem1(string arg1)
    {
        Console.WriteLine(arg1.Trim() + " - Trim");
        Console.WriteLine(arg1.ToLower() + " - ToLower");
        Console.WriteLine(arg1.Contains("tow") + " - Contains");
        Console.WriteLine(arg1.Length + " - Length");
        Console.WriteLine(arg1.IndexOf('C') + " - IndexOf");
    }
    //problem 2
    public void Problem2()
    {
        char var1 = '\u00b6';
        Console.WriteLine(var1);
    }
    // problem 3
    public void Problem3()
    {
        Console.WriteLine("Jack and Jill \nwent up the hill \nto fetch a pail of " +
            "water. \nJack fell down and broke his crown \nand Jill came tumbling after.");
    }

    // problem 4
    public string Problem4()
    {
        string name = "Jared";
        string favoriteMovie = "Harry Potter";
        string favoriteSnack = "popcorn";
        string favoriteDrink = "water";
        return $"My name is {name}, I love to eat {favoriteSnack} and drink {favoriteDrink} while" +
            $" watching {favoriteMovie}!";
    }
}

