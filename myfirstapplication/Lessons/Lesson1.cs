namespace myfirstapplication;

/*
 This class goes over value types
*/
internal class Lesson1
{
    // Integral signed

    // sbyte range -128 to 127
    sbyte mySByte = 2;

    public void SByteMinMax()
    {
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValue);
    }

    // short range -32, 768 to 32, 767
    short myShort = 6;

    public void ShortMinMax()
    {
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
    }

    // int range -2, 147, 483, 648 to 2, 147, 483, 647
    int myInt = 25685;
    public void IntMinMax()
    {
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
    }
    // long range -9, 223, 372, 036, 854, 775, 808, to
    // 9, 223, 372, 036, 854, 775, 807
    long myLong = 123456789L;

    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }

    // Integral Unsigned

    // byte range 0 - 255
    byte myByte = 4;
    public void ByteMinMax()
    {
        Console.WriteLine(Byte.MinValue);
        Console.WriteLine(Byte.MaxValue);
    }

    // ushort range 0 - 65, 545
    ushort myUShort = 42;
    public void UShortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }

    // uint range 0 -4, 294, 967, 295
    uint myUInt = 4532U;
    public void UIntMinMax()
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }

    // ulong range 0 - 18, 446, 744, 073, 709 =, 551, 615
    ulong myUlong = 948372UL;
    public void ULongMinMax()
    {
        Console.WriteLine(UInt64.MinValue);
        Console.WriteLine(UInt64.MaxValue);
    }


    // Floating POint / Real Numbers
    // float range 3.4E +- 38

    float myFloat = -123.6589F;

    public void FloatMinMax()
    {
        Console.WriteLine(Single.MinValue);
        Console.WriteLine(Single.MaxValue);
    }

    // double range 1.7E +/- 308
    double myDouble = 12.34D;

    public void DoubleMinMax()
    {
        Console.WriteLine(Double.MinValue);
        Console.WriteLine(Double.MaxValue);
    }

    // decimal range -7.9228E + 24to 7.9228E + 24

    decimal myDecimal = 13.23M;

    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }


    /*
     Decimal This type of interer literal is what we would normally use also known
    as base ten, numbers 0-9. Int value = 26
    Hexadecimal this type is base16 that uses 0x or 0X prefix
    Base16 is numbers 0-9 as well as A-F which represent 0-15
    int value2- 0x1a; // the value of 26
    Binary
    This type is base2, uses prefix 0b or 0B
    Base2 is 0 & 1
    int value3 - ob11010; the value of 26

    The suffix
    is used because al intergral types are considered intergers and all
    floating-point numbers
    are considerd double.
    The compiler can't tell the difference between an int and a long, so by
    using a I or L at
    he end of the literal, you
    signal to the compiler that the value is of type long. We
    Also use suffixes for other types uncluding floating
    point types.

    Scientifix Notation
    Can be utiliezed in literal using the letter e, this represents the
    power of 10

    Digit Seperator
    We can add a _ to make numbers easier to read, similar to python

     
     */

    // Integral Literals
    public void IntergralExample()
    {
        // values of 26
        int value1 = 26; // decimal
        int value2 = 0x1a; //hexadecimal
        int value3 = 0b11010; //binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // Scientific Notation
    double alpha = 6.26E-22;

    // Underscores
    long beta = 1_834_432L;

    /*
     Numberic Conversions
    Integral Conversions are implicit when the type can represent every possible value.
    Explicist is required for everyting else.
    When you cast from a floting-point number to an
    integral type, the fraction portion
    is truncated and not rounded.  There is a class called System.Convert that
    provides methods that round while converting
    All integral types can be implicitly converted to decimal, but from decinmal to other
    types is explicit

    Implicit Conversion
    This basically means that a smaller datat type can be converted
    to a larger data type. 
    */


    // explicit casting is where fractions are truncated and not rounded
    // you have to provide permission to cast from a higher number
    // to a lower type
    public void ConvertFloatToInt()
    {
        int converted = (int)myFloat;
        Console.WriteLine(converted);
    }

    // Implicit cast requires no direct permission
    public void LongFromInt()
    {
        long someValue = myInt;
        Console.WriteLine(someValue);
    }


}

