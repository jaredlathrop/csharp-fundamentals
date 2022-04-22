namespace myfirstapplication;

/*
 A collection provides a more flexible way to group objects much like an array.
unlike arrays, collection can increase or decrease in size as needed. Some
collections even allow you to assign a ket for easier retrival later.
A collection is a class, so you must create an instance of the collection
before you can add elements to it.

Collection classes from the System.Collections namespace don't store elements
of a specific type but as objects. This allows you to store almost anything
in that collection.

To enforce type safety, you can use collection classes from the system.collection.
generic namespace to contain elements of only one data type.

What are non generic collections?
These collections can hold elements of mixed types. They are saved as an object
type rather than their specific type. Some of the classes from the System.
Collection namespaces consist of the following: ArrayList, Hashtable, Queue,
SortedList, Stack.
These are considered legacy collections. Microsoft recommends the use of
Generic Collections as they store elements of the same type.

Dictionary<Tkey, TValue - Represents a collection of key/value pairs that
                            are organized on the key.
List<T> - Represents a list of objects that can be accessed by index. Methods
            include in the collections allow for search, sort, modify.
Queue<T> - Represents a (FIFO) collection of objects. first in, first out
SortedList<TKey, TValue> - Similar to a dictionary, but are sorted by the
                    key based on the IComparer<T> implementation
Stack<T> - represents a (LIFO) collection of objects. Last in, first out

The dictionary<Tkey,Tvalue>
Represents a collection of key value pairs. it is generic version of the Hashtable.
The element type for retrieving values is TryGetValue<Tkey, Tvalue> which will
give you the ability to get the key and value



 */

internal class Lesson16
{
    public void MyListExample()
    {
        List<string> myStringList = new List<string>();
        myStringList.Add("Alpha");
        myStringList.Add("Bravo");
        myStringList.Add("Charlie");
        myStringList.Add("Delta");
        myStringList.Add("Echo");
        myStringList.Add("Foxtrot");

        // gets or sets the total number of elements
        Console.WriteLine($"Capacity is {myStringList.Capacity}");
        Console.WriteLine($"Total count is {myStringList.Count}");

        // Bool if list contains ?
        Console.WriteLine($"This list might contain {myStringList.Contains("Delta")}");

        // insert/remove
        myStringList.Insert(3, "Happy");
        myStringList.Remove("Happy");

        // iterate through the elements
        foreach(string item in myStringList)
        {
            Console.WriteLine(item);
        }
    }


    // This collection is based around key value pairs
    public void MyDictEx()
    {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
        phrases.Add(10, "Chasrp");
        phrases.Add(20, "Rocks");
        phrases.Add(30, "Happy");
        phrases.Add(40, "Friday");

        // get a single value using the TryGetValue
        string value;
        if(phrases.TryGetValue(20, out value))
        {
            Console.WriteLine($"For key 20, the value is {value}");
        }

        //iterate through list
        foreach(KeyValuePair<int, string> item in phrases)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

    }
} // end class


