using myfirstapplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// The below statements calls the function
// single line comment
// HouseExample();

/*
 Multi line comment
The below statements is a local function. Local functions are
inside of members and are private by default. this mens that they are
specific to that member and can only be called inside
that member.
*/

// Lesson Examples
Lessson1Example();
Exercise1output();

// void HouseExample()
// {
    // House myHouse = new House();
    // myHouse.DoorOpenClose();
// }

/* This is my function 
 for C# Intro Lab Exercise
*/

void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning new stuff everyday");
}

MyLocalFunction();

// Lesson one value types


void Lessson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntergralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}


void Exercise1output()
{
    Exercise1 myExercise = new Exercise1();
    myExercise.Problem1();
    myExercise.Problem2(15, 17, 5);
    myExercise.Problem3(15.55D, 19.9999F, 98765432L);
    myExercise.Problem4();
}
