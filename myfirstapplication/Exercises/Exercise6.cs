namespace myfirstapplication;

public class Exercise6
{

    /* Question 1. Write a constructor for you exercise file that takes 2 parameters. The first parameter
     should have an int type and a variable name of showSize. The 2nd parameter should have
     a string type and a variable name of shoeType. Create a private class variable for these types
    and use an underscore when defining them. Inside the constructor, associate the class
    variable with the constructor parameters
     */
    private int _showSize;
    private string _shoeType;
    public Exercise6(int size, string type)
    {
        _showSize = size;
        _shoeType = type;
    } // end method 

    /* Question 2. Write the properties for the class variabels defined in exercise1.
     Ensure they are labeled as public and are spelled using a capital letter.
     */
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    /*
     Write a delegate that takes a string parameter. This delegate should be named TryOn.
    Write a method that takes a string arguent and void return type. in the method body include a console
    writeline statement that will print the message. Test you delegate in program.cs
    to ensure it's working, use a multi-line comment on your exercise6 and provide the information
    you used to test the delegate
    */
    
    public delegate void TryOn(string type);
    public void TryShoe(string message)
    {
        Console.WriteLine(message);
    }

    /* What I used to test.
     void Exercise6Output()
    {
           Exercise6 theShoes = new Exercise6(9, "Nike");
           Exercise6.TryOn newShoe = theShoe.TryOnShoe;
           newShoe($"My size {theShoe.ShowSize} shoe was made by {theShoe.ShoeType}");
    }
     */



} // end class 
