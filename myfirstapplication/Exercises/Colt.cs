namespace myfirstapplication;

internal class Colt : Horse
{
    /*
     Create a child classbased on your Horseobject. Include onechild attribute asanauto property.
    Create 3 constructors. The first constructorshould have4parameters with 3of them fromHorse and
    your child property. Using the keyword :base(),you will put the four horse parametersin
    theparenthesis. In the body of the constructor you will assign your childparameter to your property.
    The second constructorshould have 2parameters, 2 based on the horse and 1 from your child.
    Using the :this()keyword, you will pass 2 of the parent attributes and your child
    attributeinformation to the first constructor.Include default values to
    represent the 2 remaining horse parameters.For the last constructor,
    you will create the default constructor. Using the :this()keyword,
    you will pass 2default valuesin that will pass to the 2ndconstructor.
    Also include in the class, your method for your child class.
    */

    //auto property
    public int ColtWeight { get; init; }

    // 1st constructor
    public Colt(string horseColor, string horseGender, int horseHeight, int horseWeight)
        : base(horseColor, horseGender, horseHeight)
    { 
        ColtWeight = horseWeight;
    }

    // 2nd Construcotr
    public Colt(string horseColor, string horseGender, int horseWeight)
        :this(horseColor, horseGender, 60, horseWeight) { }

    // Default constructor
    public Colt()
        :this("White", "Male", 200) { }

    /*
    EXERCISE 12 PROBLEM 2. In your child class of Horse, using the overridekeyword create a method
    that has the same name as the virtual method from Horse. Add a Console
    WriteLine that provides a different message from the Horse
     */

    // using override keyword to provide a different message using HorseTrot()
    public override void HorseTrot()
    {
        Console.WriteLine("The colt is trotting.");
    }
}
