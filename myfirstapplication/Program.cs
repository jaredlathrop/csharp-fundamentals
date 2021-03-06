using myfirstapplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
// Lessson1Example();
// Exercise1output();
// Lessycise2output();
// Lesson3Example();
// BottlesOfBeerSong();
// ExerciseThreeOutput();
// LessonFourOutput();
// Exercise4Output();
// Lesson5Output();
// Exercise5output();
// Lesson6output();
// Lesson7Example();
// Lesson8Example();
// Exercise8Out();
// Lesson9Ex();
// Lesson10Ex();
// ouseUpdate();
// HorseOutput();
// BoatOutput();
// Lesson11Out();
// Lesson12Out();
// Lesson13Out();
// Lesson14out();
// Lesson15out();
// Lesson16Out();
Lesson17Out();

void Lesson17Out()
{
    Lesson17 myLesson17 = new Lesson17();
    House testHouse = null;
    // myLesson17.MyThrowExample(testHouse);
    // myLesson17.MyExceptionExample(testHouse);
    // myLesson17.MyArrayException();

    Exercise17 myExercise17 = new Exercise17();
    // myExercise17.Problem1(5, 0);
    Horse testHorse = null;
    myExercise17.Problem2(testHorse);
}

void Lesson16Out()
{
    Lesson16 myLesson16 = new Lesson16();
    // myLesson16.MyListExample();
    // myLesson16.MyDictEx();

    Exercise16 myExercise16 = new Exercise16();
    myExercise16.MyHorse();
    myExercise16.MovieDict();
}

void Lesson15out()
{
    Lesson15 myLesson15 = new Lesson15();
    // myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCream.Chocolate);
    Console.WriteLine(flavor);
    myLesson15.TupleEx();
    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    Console.WriteLine($"Answers are {val1}, {val2}, {val3}");

    Exercise15 myExercise15 = new Exercise15();
    string movie = myExercise15.MyFavoriteMovies(favoriteMovies.Batman);
    
}
 
void Lesson14out()
{
    Lesson14 myLesson14 = new Lesson14();
    //myLesson14.SingleHouseArray();
    //myLesson14.SingleIntArray();
    //myLesson14.MultiIntArray();
    //myLesson14.MultiString();
    // myLesson14.JaggedArraySample();
    Exercise14 myExercise14 = new Exercise14();
    myExercise14.IceCreamFlavors();
    myExercise14.FootballScore();
}


void Lesson13Out()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Convereting feet to inches: {total1}");
    Console.WriteLine($"Converting yards to feet: {total2}");
    Console.WriteLine($"Converting miles to yards: {total3}");

    Duck myExercise13 = new Duck(3);
    myExercise13.Eat();
    myExercise13.Fly();
}

void Lesson12Out()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    Apple myApple = new Apple();
    myApple.EatFruit();
    Condo myCondo = new Condo();
    myCondo.DoorOpenClose();
    myCondo.Maintenance();
    Console.WriteLine(myCondo.DoorColor);
    Console.WriteLine(myCondo.WindowSize);
}


void Lesson11Out()
{
    Square square = new Square();
    double total = square.CalcInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalcInteriorAngle();
    Console.WriteLine(total2);
}

void BoatOutput()
{
    Boats myBoat = new Boats();
    Console.WriteLine(myBoat.woodType);
    myBoat.SailRaise("oak");
}

void HorseOutput()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.HorseGender);
    myHorse.HorseTrot();
    myHorse.HorseTrot("white");

    Colt myColt = new Colt();
    myColt.HorseTrot();
}

void HouseUpdate()
{
    // Calling default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}

void Lesson10Ex()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal Property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling auto-property
    Console.WriteLine(myLesson10.Id);
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id);

    // Expression body property
    myLesson10.Address = "123 Main st.";
    Console.WriteLine(myLesson10.Address);

    // Second Constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 67037);
    Console.WriteLine(myOther10.ZipCode);



}


void Lesson9Ex()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // access modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
 
}

void Exercise8Out()
{
    Exercise8 myExercise8 = new Exercise8();
    myExercise8.FeetToInches(3);
    Exercise8.LengthXWidth(4, 5);
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    Console.WriteLine(Lesson8.DaysPerMonth);
    Console.WriteLine(Lesson8Static.CelsiustoFaren(30.1));
    Lesson8.DayCount = 10;
    myLesson8.CalcHours();
    Lesson8.CalculateDayCount();
    myLesson8.CalcHoursV2();

}


void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly struct
    Student myStudent = new Student(10, "Jared");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastname);

    Resolution res = new Resolution(1800, 1920);
    res.CalculateRate();
    Console.WriteLine(res);
}

void Lesson6output()
{
    // default constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6.TryOn theHat = myLesson6.TryOnHat;
    theHat($"I tried on a {myLesson6.HatType} hat that was size {myLesson6.HatSize}");

    //constructor with parameter
    Lesson6 myOther6 = new Lesson6(24);

    // constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // method parameter modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine($"out using variable charlie - {charlie}");

    // Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;
    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHate;
    multiHat = hangTheHat + theNewHat;
}

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

// MyLocalFunction();

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

// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimEx();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsEx("Dog");
    myLesson2.MyExChar();
    Console.WriteLine(myLesson2.myEscapeEx());
    myLesson2.MyJoinesStrings("CSharp", "rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void Exercise2output()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.Problem1("EXERCISE two Lab");
    myExercise2.Problem2();
    myExercise2.Problem3();
    Console.WriteLine(myExercise2.Problem4());
}

void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckOperator(14);
    // myLesson3.BasicCheckedEx2();
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBoolean(true, false);
    // myLesson3.BasicCompoundExample(10, 20, 30);
    // myLesson3.BasicRelationalExample("Tom", "Tom");
    myLesson3.BasicIncrementDecrement();
}

void BottlesOfBeerSong()
{
    BottlesOfBeer myBottlesOfBeer = new BottlesOfBeer();
    myBottlesOfBeer.LetaSing();
}

void ExerciseThreeOutput()
{
    Exercise3 myExercie3 = new Exercise3();
    myExercie3.Question1(5);
    myExercie3.Question2();
    myExercie3.Question3(10, 5);
    myExercie3.Question4(false, true);
}

void LessonFourOutput()
{
    Lesson4 myLesson4 = new Lesson4();
    myLesson4.BasicIfElse(12);
    myLesson4.BasicIfElseChain(10);
    myLesson4.BasicAndOrCondition(18, 28);
    Console.WriteLine(myLesson4.BasicTernaryEx(25));
    myLesson4.BasicSwitchEx(3);
    myLesson4.BasicWhileEx();
    myLesson4.BasicDoEx();
    myLesson4.BasicForStatement();
    myLesson4.BasicForEachEx();
    myLesson4.BasicJumpStatement();
}

void Exercise4Output()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.Problem1("cat", "cat");
    myExercise4.Problem2("A");
    myExercise4.Problem3();
}

void Lesson5Output()
{
    Lesson5 myLesson5 = new Lesson5();
    myLesson5.IsOperatorEx(15);
    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello CSharp");


    // func delegate
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"func delegate example = {add(23)}");

    // Lamda expression
    myLesson5.LamdaSquare();
    myLesson5.LamdaGreeting();

    // Switch expression
    Console.WriteLine(myLesson5.FavoriteColor("red"));
    myLesson5.DrinkSize(32);


    // Logical patterns
    myLesson5.NumberChoice(2);
    myLesson5.TemperatureGuide(45);
}

void Exercise5output()
{
    Exercise5 myExercise5 = new Exercise5();
    Console.WriteLine(myExercise5.Problem2("A"));
    myExercise5.Problem3(5);
}