namespace myfirstapplication;

internal class Lesson10
{
    /*
     What is encapusulation
    The process of wrapping data and the code into a single unit. We can create
    a full encapsulated class by making all fields private
    Benefits, makes it easy to model real world entities, control the way data is
    accessed or modified, makes the class easy to use for clients, increase
    reusablity, aids the flexibility of design

    properties
    A member that provides flexible mechanism to read, write, or compute the value
    of the privat efield. They act as public data members, but are special method that
    can be called accessors. Properties enable a class to expose a public way of setting
    and getting values, while hiding implementation.

    property accessors.
    The body of a get accessor is similar to a method, it must return a value of the
    property type. The execution of the get accessor is the same
    as reading the value of the field. When you are returning avalue from a private field
    the get accessor and optimizations are enabled,, which allows the acessor
    to be inlined by the compiler so therei s no method-call overhead. when we look at
    polymporhism, we will discuss how this nline of the accessor changes.

    The set and init accessors
    The set accessor resemebles a void return type method. it uses implicit parameter
    called value, whose type is propertyy
    init- same as set but you can only use it in the constructor or by using an
    object-intializer

    Auto-Implemented Properties
    These kind of properties make property declaration more concise. This
    is especially true when no additional logic is required in the porperty
    accessors. When you create an auto - implemented property the compiler creates
    a private anonymous field that can be accessed through the get and set properties

    Expression body definitions
    you can implement properties as expression-bodied members. This consists of
    use the => symbol followed by the expression to assign or retrieve from
    the property.

    Properties Conclusion
    Properties can have all the current access modifies. Properties
    may also be marked as static using the static keyword. This allows the property
    to be called at any time.
    The accessors themselves can also have modifiers applied to them. You can have
    public get, but a private set. This has a similar affect as using init, but you can
    still change it within the class.

    Using This keyword
    The keyword this refers to the current instance of the class
    This includes field or the obect itself the use of the
    keyword is found most often in conjuction with a parameterized constructor.
    If the parameters in a constructor match the names of the fields it is initailzing
    the this keyword allows the compiler to know which value is which. The keyword
    this can't be used in static classes.

    A constuctor can invoke anothe constuctor using the this keyword. IT can be used with orwithout parameters,
    and any parameters in the constructor can be passed into the expression.
    By using the keyword this to pass info from 1 constructor to antoher, we can
    also establish default values as well.
     
     */


    private string _firstName;
    private string _address;
    protected int zipcode;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    // auto-implemented property with init keyword
    public string LastName { get; init; }

    // auto-implemented property with a default value
    public int Id { get; set; } = 1000;

    // property with private set
    public long Phone { get; private set; }

    // Expression bodied member property
    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public int ZipCode
    {
        get => zipcode;
        set => zipcode = value;
    }

    // default constructor
    public Lesson10()
        :this("John", "Doe", 67205){ }
       
    // Constructor using this with variables
    public Lesson10(string firstName, string lastName, int zipcode)
    {
        this._firstName = firstName;
        LastName = lastName;
        this.zipcode = zipcode;
    }

    /*
     This method shows how you can change a private set property
    but not a property with int
     */

    private void ShowLastAndPhone()
    {
        // LastName = "Jon";
        Phone = 123456;
    }
} // end class
