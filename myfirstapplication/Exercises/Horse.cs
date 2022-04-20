namespace myfirstapplication;

internal class Horse
{
    /*
     Create a class based on your Horseobject. Include your attributes as auto properties.
    Create 3 constructors. The first constructor should have parameters equal to your properties.
    Assign each parameter to your properties. The second constructorshould have 2 parameters.
    Using the :this()keyword, you will pass your information to the first constructor.
    This includes the 2 parameters and default values. For the last constructor,
    you will createthe default constructor. Using the :this()keyword, you will
    pass 2 default valuesin that will pass to the 2ndconstructor.
    Also include in the class, your method for Horse.
     */

    // properties
    public string HorseColor { get; init; }
    public string HorseGender { get; init; }
    public int HorseHeight { get; init; }

    // 1st constructor
    public Horse(string horseColor, string horseGender, int horseHeight)
    {
        HorseColor = horseColor;
        HorseGender = horseGender;
        HorseHeight = horseHeight;
    }

    // 2nd constructor
    public Horse(string HorseColor, string HorseGender)
        :this(HorseColor, HorseGender, 60) { }

    // 3rd constructor
    public Horse()
        :this("Black", "Female") { }

    // method
    // Adding virtual for exerice 12.
    public virtual void HorseTrot()
    {
        Console.WriteLine($"My {HorseGender} horse is trotting");
    }


    /* EXERCISE 12. PROBLEM 1. InyourHorseclass, add the virtualkeyword to your method
        created in Lesson 10. Create a second versionof the same
        method and add a parameter.Include a Console WriteLine method
        in the new method that uses the parameter.This parameter needs
        to be based on one of your properties. */

    // method for exercise 12 with a a parameters
    public virtual void HorseTrot(string HorseColor)
    {
        // the console.writeline
        Console.WriteLine($"The {HorseColor} horse is trotting");
    }




} // end class
