using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary of string keys and int values
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Add some items to the dictionary
            dict.Add("apple", 1);
            Console.WriteLine("apple added");
            dict.Add("banana", 2);
            Console.WriteLine("banana added");
            dict.Add("cherry", 3);
            Console.WriteLine("cherry added");
            dict.Add("date", 4);
            Console.WriteLine("dates added");

            // Read (Retrieve) an item from the dictionary
            Console.WriteLine("The value for 'banana' is: " + dict["banana"]);

            // Update an item in the dictionary
            dict["cherry"] = 5;
            Console.WriteLine("The value for 'cherry' is now: " + dict["cherry"]);

            // Delete an item from the dictionary
            dict.Remove("apple");
            Console.WriteLine("The item 'apple' has been removed.");

            
            // Print all items in the dictionary
            Console.WriteLine("Here are all the items in the dictionary:");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
