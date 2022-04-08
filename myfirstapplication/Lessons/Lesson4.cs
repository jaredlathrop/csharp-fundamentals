namespace myfirstapplication;
/* 
Selections Statements - The kind of statment causes the program control to be
transferred to a specific flow based on where a condition is true

if statement
An if statment identifies which statment to run based on a boolean expression.
The statment can also incluse an else statement. An else will only run when the
condtion is not met. you can chain if/else statments together when you have
multiple condionts that can be evalutaed. When you have multiple conditions that
related, you can also join them using the && or }} boolean logical operators

ternary operator
This operator is a substitute for an if-else style statment. This type of operator
is suited for single t/f type statements. This type of operator takes 3 operands

The switch statement
This statment lets your branch execution based on a selection of possible values.
It is a much cleaner version of an if-else chain. The keyword case is used to represent
the possible values. A default can be achieved using the keyword 'default'.
Once a value is selected and its code executed, we need a away to leave the switch.
The jump statement called break is used for this purpose.
if you have a method that has return type, the 'return' keyword along with the
type required can be used in place of a break.
 
 The While statement
This statement exeutes a statement or block of code while an expression is true.
Because of the way the expression is evaluated before any statement
or block, the loop executes zero or more times.
It depends on 3 key factos: Initializaiton, condition, increment/decrement

The do statement
This staement executes a statement or block of code while an expression is treu
Because of the way the expression is evaluated after any statemnt or block, the
loop execture one or more time.

The for statement
This statement executes a statement or bock of code while an expression is true
This type of loop can contain 0 or more key factors: initializiont, condition,
increment/decrement. defining none of the key factors can result in an infintie
loop

 The foreach statement
The statement executes a statement or block of code for each element of certain
types. In this specific lesson, that can be of a sequence or collection. This statement
uses the keyword 'in' for its definition
 
 Jump statement
These statement allow you to do something after the code is executed
Break - End the execution of the body of an iteration or switch statement
continue - statement forgoes the remaining statements below it and starts the next
iteration
goto - statement transfers execution to anothe label within the statement
return - statement exits the method and must return an expression of the methods
return type
throw - statement throws an exception to indicate an error
 
 */


internal class Lesson4
{
    // basic if statement
    public void BasicIfStatement(int val)
    {
        Console.WriteLine("Before if Statement");
        if (val > 10)
        {
            Console.WriteLine($"Our {val} was greated than 10");
        }
        Console.WriteLine("After if statement");
    } // end method

    // basic if else statement
    public void BasicIfElse(int able)
    {
        if (able >= 15)
        {
            Console.WriteLine($"{able} is greater than or equal to 15");
        }
        else
        {
            Console.WriteLine($"{able} is less than 15");
        }
    } // end method

    public void BasicIfElseChain(int beta)
    {
        if(beta == 10)
        {
            Console.WriteLine($"Our {beta} is 10");
        }
        else if(beta == 20)
        {
            Console.WriteLine($"Our {beta} is 20");
        }
        else
        {
            Console.WriteLine($"{beta} is not 10 or 20");
        }
    } // end method

    // basic if with boolean logical operators
    public void BasicAndOrCondition(int charlie, int delta)
    {
        if(charlie > 15 && delta < 30)
        {
            Console.WriteLine($"{charlie} and {delta}");
        }
        if(charlie == 18 || delta < 25)
        {
            Console.WriteLine($"{charlie} or {delta}");
        }
    } // end method

    // Ternary Operator
    public bool BasicTernaryEx(int echo)
    {
        return (echo > 30) ? true : false; 
    }

    // Switch
    public void BasicSwitchEx(int punky)
    {
        switch (punky)
        {
            case 1:
            case 2:
                Console.WriteLine($"{punky} is case 1 or 2");
                break;
            case 3:
                Console.WriteLine($"{punky} is case 3");
                break;
            case 4:
                Console.WriteLine($"{punky} is case 4");
                break;
            default:
                Console.WriteLine($"{punky} was not in the list");
                break;
        } // end method
    }

    // While statement
    public void BasicWhileEx()
    {
        int fox = 0; // initializtion
        while(fox < 10)
        {
            Console.WriteLine($"Number = {fox}");
            fox++; // increment
        }
    } // end method

    // do statement
    public void BasicDoEx()
    {
        int hotel = 0; // initializtion
        do
        {
            Console.WriteLine($"Do number {hotel}");
            hotel++; // increment

        } while (hotel < 13); //condition


    } // end method


    // for statement
    public void BasicForStatement()
    {
        for(int tiger = 0; tiger < 12; tiger++)
        {
            Console.WriteLine($"For number = {tiger}");
        }
    } // end method

    // foreach
    public void BasicForEachEx()
    {
        foreach(char word in "Something")
        {
            Console.WriteLine($"Char value = {word}");
        }
    } // end method

    // jump statements
    public void BasicJumpStatement()
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 2)
            {
                Console.WriteLine($"The {i} was skipped");
                continue;
            }
            if (i == 4)
            {
                Console.WriteLine($"The loop breaks at {i}");
                break;
            }
            Console.WriteLine($"Number = {i}");
        }
    } // emd method




} // end class