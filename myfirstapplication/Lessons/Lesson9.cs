
namespace myfirstapplication;
internal class Lesson9
{
    /*
     Only 1 access modifier is allowed for any given member or type.
     The only exceptions are when you use protected internal or private
     protected. Thse modifier are not allowedi n namespaces, which have
     no access restriction.

    What is an assembly
    An assembly is a .dll or .exe created by compiling or more .cs files in a single
    compilation.

    Access modifiers
    Public access modifier- Applies to types and members. It is most permissive
    of access levels. There is no restriction with this modifier

    Private- is the least permissive of access leves. Members using the private are
    accessible only with in the body of the class or struct in which they are declared
    Nested types in the same body can also access the same private members

    Protected and internal
    Internal- type or member can be accessed by any code in the assembly, but not from
    other assemblys
    the protected modifier- member can be accessed only by code in the same class, or
    derived from the same class (child class).

    protected internal
    Can be accessed by any code in the assembly, or a derived from another assmebly. This
    means that if a child class ifr om another assembly, it can still access member
    information within this modifier

    private protected
    Member can be accessed by types derived from the class that are declared within
    its containing assembly
     */




    private int _value = 10;

    /*
     Private access modifier can only be seen within the class struct or nested type
     */
    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     Protected access modifier can only be seen within the type or a child(derived
    class)
     */

    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected");
    }

    // internal access modifier can be seen with in the assembly but not other
    // assemblys

    internal void SampleInternal()
    {
        Console.WriteLine("This method is internal");
    }

    /*
     Protected internal can be seen within the assembly or child(derived) class
    from another assembly.
     */

    protected internal void SampleProtectedInternal()
    {
        Console.WriteLine("This method is protected internal");
    }

    /*
     Private protected can be seen only within the class and child(derived) class
    from within the assembly
     */
    private protected void SamplePrivateProtected()
    {
        Console.WriteLine("This method is private protected");
    }

    public class Nested
    {
        public Nested(Lesson9 parent)
        {
            Console.WriteLine($"The value is {parent._value}");
        }

    } // end nested class



} // end class

