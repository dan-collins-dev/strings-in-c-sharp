/* 
    Purpose of Project: Dig into strings

    Note to self from Documentation:

        String objects are immutable: they can't be changed after they're created. 
        All of the String methods and C# operators that appear to modify a string
        actually return the results in a new string object.

        string "modification" is actually a new string creation, you must use 
        caution when you create references to strings. If you create a reference to
        a string, and then "modify" the original string, the reference continues 
        to point to the original object instead of the new object that was created 
        when the string was modified.

 */
using System;

namespace c_sharp_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFriendsName = "Troy";

            // concatenation
            Console.WriteLine("Hello " + myFriendsName!);

            // interpolation 
            Console.WriteLine($"Hello {myFriendsName}!");

            string otherFriendsName = "Abed";

            // verbatim literal with string interpolation
            string message = @$"
                                {myFriendsName} and {otherFriendsName} in the morrrrrning!";

            Console.WriteLine(message);

            // Using the string object method to concatenate message above
            string concatWithStringMethod = 
                String.Concat(myFriendsName, " and ", otherFriendsName, " in the morrrrrning!");
            
            Console.WriteLine(concatWithStringMethod);
        }
    }
}
