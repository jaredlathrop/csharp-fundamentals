namespace myfirstapplication;

public class Exercise1
{
    // problem 1
    public void Problem1()
    {
        int value1 = 35;
        int value2 = 0b100011;
        int value3 = 0x23a;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }


    //problem 2
    public void Problem2(int myInt, byte myByte, short myShort)
    {
        // a from byte to int
        int converted = myByte;
        Console.WriteLine(converted);

        // b. from short to long
        long converted2 = myShort;
        Console.WriteLine(converted2);

        // c. int to float
        float converted3 = myInt;
        Console.WriteLine(converted3);

    }

    // problem 3

    public void Problem3(double ExDouble, float ExFloat, long ExLong)
    {
        // a. double to long
        long converted4 = (long)ExDouble;
        Console.WriteLine(converted4);
        // b. float to int
        int converted5 = (int)ExFloat;
        Console.WriteLine(converted5);
        // c. long to short
        short converted6 = (short)ExLong;
        Console.WriteLine(converted6);

    }
    // Problem 4
    float myFloat = 123456.987F;
    int myInt = -9516248;
    short myShort = 3500;
    long myLong = 988562486L;
    double myDouble = -19733.14895D;



    public void Problem4()
    {
        Console.WriteLine(myFloat);
        Console.WriteLine(myInt);
        Console.WriteLine(myShort);
        Console.WriteLine(myLong);
        Console.WriteLine(myDouble);
    }

}

