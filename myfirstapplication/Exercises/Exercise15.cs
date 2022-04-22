namespace myfirstapplication;

/*
1.Above the class, write an enum called Favorite Movies. Add your own favorite movies
to the enum. Write a method that hasa string return type and an enum parameter.
This enum parameter will be your favorite movie enum. Write a switch expression
that takes the enum and prints out a string return. Use string interpolation in
your return message that includes the name of the movie chosen.

2.Write a method that takes an enum parameter. This enum will be your favorite
movie enum.The method will have a tuple return type(intnum, stringmovie).Using
an explicitintcaston one of your enum, assignthe value to an int variable. 
Createsecond variableof type string. Assign the same enum value you used and use the ToString()
at the end of it. Return both variables as a tuple.
See examplebelow for clarity.
a.Int value = (int)Enum.Value;
b.string something = Enum.Value.ToString();
*/

// creating enum
public enum favoriteMovies { HarryPotter, BeforeIFall, Batman}

internal class Exercise15
{
    // method with string return type.
    public string MyFavoriteMovies(favoriteMovies movie)
    {
        /* Writing a switch expression that takes the enum and prints astring return.
         Using interpolation to return the name of the movie chosen.
         */
        string message = movie switch
        {
            favoriteMovies.HarryPotter => $"My favorite movie is {favoriteMovies.HarryPotter}",
            favoriteMovies.Batman => $"My favorite movie is {favoriteMovies.Batman}",
            favoriteMovies.BeforeIFall => $"My favorite movie is {favoriteMovies.BeforeIFall}"
        };
        return message;
    }

    // Write a method that takes an enum parameter
    public (int num, string movie) MyMovies(favoriteMovies movie)
    {
        // method that returns a tuple.
        int val = (int)favoriteMovies.Batman;
        string val1 = movie.ToString();
        return (val, val1);
    }

} // end class