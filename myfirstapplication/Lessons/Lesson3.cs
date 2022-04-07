/* Over flow checking
 Checked
The keyword us used to explicitly enable overlow checking for aritmetic
operators and conversions. By default if an expression contains only constant
value, a compiler error will produce an expression produces a value outsie the range
Non-constant value will not detect the overflow. overflow checking can be enabled by compiler
options, enviroment conf, or using the checked keyword. It can be used as en expression
or a block to detect the overflow produced by non constant values at runtime.
Both of these types can raise an overflow exception

Unchecked
This keyword is usede to suppress the overflow checking of arithmetic operators and
conversions. if the expression produces a value that is outside the range of the total,
the overflow is not flagged. Like checked, this is specific to constant values as non-constant
values are unchecked by default.

 Arithmitic Operators
Operators work with operands of numeric types. They can be divided into two types:
Unary and Binary. Here are some commmon ones(b or binary, u of unary)
addition - (a + b) - binary
subrtation - (a - b) - binary
multiply - (a * b) binary
division - a / b) - binary
modulus - (a % b) - binary
increment - (a++) - unary
decrement - (--b) - unary
plus - (+a) - unary
minus - (-b) - unary

Boolean Logical Operators
These operators perform logical operations with bool operands.
The bool keyword type is an alias of System. Boolean is T/F.
They can be broken into 3 categories- Unary, Binary where both operands are always compared,
and binary where the right operand is evalutaed only if necessary
! - unary - resuly becomes the opposite of other logical operatins.
& - binary - Logial AND operator, results true if both operrands evalue true
^ - Binary - logical exclusive OR opertor, Result true if one operand is true and one is false
| - binary - Logical OR operator, results true if either operrands evaluate true
&& - binary - conditional logical AND operator, Result true if both operands evalute to true
If the left operand is false, the right is not evalutated
|| - binary - Conditional logical OR operator, result true if either opperand evaluates to true,
if the left opperand is true, the right is not evaluated

Compound Assignement Operators
This type is made up of arithmetic, boolean, and bitwise operators. These kind utilize
one of the operands instead of assigning the evaluation to a new variable
+=, (c += a), same as c = c + a
-=, (c -= a), same as c = c - a
*=, (c*= a), same as c = c * a
/=, (c /= a), same as c = c / a
%=, (c %=a), sames as c =  c % a
&=, (c &= a), same as c = c & a
|=, (c |= a), same as c = c | a
^=, (c ^= a), same as c = c ^ a
??=, (c ??= a), same as c = ?? a

Relational Opertors
These operators check the relationship between two variables
== equal to
!= not equal to
>, <, >=, <=


Increment and Decreement
Increment
This operator increases by 1. There are 2 forms post and pre
(post)++ - post increment is the value computed then the increments
++(pre) - is where the value is incremented then the result is computed.
Decrement is the opposite

*/






namespace myfirstapplication;


internal class Lesson3
{
    // Check, this keyword will produce an error if the values exceed max or
    // min capacity 2147483647
    public void BasicCheckOperator(int val)
    {
        int total = checked(2147483647 + val);
        Console.WriteLine(total);

    } // end method


    public void BasicCheckedEx2()
    {
        int able = 10;
        checked
        {
            int total = 2147483647 + able;
            Console.WriteLine(total);
        }
    }// end method


    // Uncheck will remove the exception from constant values
    public void BasicUncheckedExample()
    {
        int total = unchecked(Int32.MaxValue + 10);
        Console.WriteLine(total);
    } // end method


    // Arithmetic Operator

    // add, subrtract, multipl, divide
    public void BasicMath()
    {
        int able = 20, beta = 10;
        int addTotal = able + beta;
        int subtractTotal = able - beta;
        int multiplyTotal = able * beta;
        int divideTotal = able / beta;

        Console.WriteLine($"Addition = {addTotal}, Subtraction = {subtractTotal}");
        Console.WriteLine($"Multiplication = {multiplyTotal}, Division = {divideTotal}");
    } // end method

    // Modulus Operator
    public void BasicModulus(int beta)
    {
        int total = 10 % beta;
        Console.WriteLine(total);

        Console.WriteLine(+24);
        Console.WriteLine(-345);
    } // end method


    // Boolean Logical Operators
    public void BasicBoolean(bool charlie, bool delta)
    {
        //AND
        Console.WriteLine(charlie & delta);
        //OR
        Console.WriteLine(charlie | delta);
        // Exlusive OR
        Console.WriteLine(charlie ^ delta);
        // &&
        Console.WriteLine(23 > 10 && 23 < 10);
        // ||
        Console.WriteLine(23 > 10 || 23 < 10);
    } // end method

    // Compound Assignement opertators
    public void BasicCompoundExample(int val1, int val2, int val3)
    {
        // Addition
        val1 += val2;
        Console.WriteLine(val1);

        // Follows Pemdas, heres an example including multiplication and pemdas
        val2 *= (val3 + 1);
        Console.WriteLine(val2);
    } // end method


    // Relational Operators
    public void BasicRelationalExample(string name, string beta)
    {
        Console.WriteLine(name == beta);
        Console.WriteLine(name != beta);

    } // end method


    // Increment and Decrement
    public void BasicIncrementDecrement()
    {
        int alpha = 11, beta = 16;
        alpha++; // post
        Console.WriteLine(alpha);
        ++alpha; // pre
        Console.WriteLine(alpha);

        beta--; //post
        Console.WriteLine(beta);
        --beta; // pre
        Console.WriteLine(beta);
    }

} // end class
