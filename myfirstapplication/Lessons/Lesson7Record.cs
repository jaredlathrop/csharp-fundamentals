namespace myfirstapplication;

// A record is a reference type that provides built-in functionality for
// encapsulating data
internal record Person(string firstname, string lastname);
/*
 A record struct is a value type with similar functionality as a record class
 */

public record struct Resolution(int width, int height)
{
    public void CalculateRate()
    {
        Console.WriteLine(width * height);
    }
} 
