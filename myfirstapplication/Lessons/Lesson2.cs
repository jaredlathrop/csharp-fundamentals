namespace myfirstapplication;

/* A string is an object that represents a group of 
 characters in a sequence or collection of 
 Char objects. Strings are between double quotes.
A reference type is a type that sores ar eference to the
datat rather than data itself in a memory help.
strings are immutable meanin gthey can't be changed.

String methods.
The string objects lets you have access to me thods that allow you to do
different things with data. All have a reutrn type
trim = removes all leading and trailing white-space characters
equals = compares the string to a specified objects (T/F)
ToLower = changes to lowercase
ToUpper = changes to uppercase
Length = Returns length of string
Contains = to see if string exists
idexof = returns index position of the first occurrence of the specified
unicode character in the string

split = splits the string

 Char
The char type is an alias for System.Char and represnts UniCode UTF-16 character
There is no implicit conversions from other types to char/

String Concatenation
Concatenation is the combining of one string to the end of another.
You can utilize the + operator to achieve this. When you concatenate string literals and
constants, this process is done at compile time.. If you concatenate
variables, it is done at runtime

String Interpolation
utilizes the $ special character/ The interpolation string represents string literal
that contains interpolation expressions. When these expressions are resolved thay
are replacd by string representations of the expression result

It basically is a ype of string format that uses placeholder syntax, but instead
of an index number, you use the variable directly. 
 */

// this class goes over strings

internal class Lesson2
{
    string myString = "Hello World";

    // String Method - Trim()
    public void MyTrimEx()
    {
        // before trim
        string str = " Trim ";
        Console.WriteLine(str);
        // after trim
        string myTrim = str.Trim();
        Console.WriteLine(myTrim);
    }

    // String method - Equals()
    public void MyEqualsEx(string beta)
    {
        // This will be t/f, if the parameter is equal to world
        // will print True
        Console.WriteLine(beta.Equals("World"));
    }

    // String Method - ToUpper() & ToLower()
    public void MyUpperLowerEx()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }

    // String Method - Length()
    public int MyStringLength()
    // using return, notice how int is there instead of void
    { 
        return myString.Length;
    }

    // Char - Uses single quotes to identitfy
    public void MyExChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x00A9';
        Console.WriteLine(myChar);
        Console.WriteLine(copyright);
        Console.WriteLine(something);
    }

    // escape Sequences
    public string myEscapeEx()
    {
        return "That\'s a cool car. \tCan I \ndrive it sometime?";
    }

    // Concatenation - with 2 string parameters
    public void MyJoinesStrings(string value1, string value2)
    {
        Console.WriteLine(value1 + " " + value2);
    }

    // String Interpolation
    public string MyInterpolationExample(string food, int amount)
    {
        return $"My favorite food is {food} and I ate {amount} servings of it";
    }

    public void MyOtherInterpolation()
    {
        Console.WriteLine($"|{"Number", -10} | {"Order"}, 15");
    }

}

