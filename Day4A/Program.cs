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
            // Create an ArrayList of strings
            ArrayList list = new ArrayList();

            // Add some items to the list
            list.Add("apple");
            Console.WriteLine("Apple added");
            list.Add("banana");
            Console.WriteLine("banana added");
            list.Add("cherry");
            Console.WriteLine("cherry added");
            list.Add("date");
            Console.WriteLine("date added");

            // Read (Retrieve) an item from the list
            Console.WriteLine("The second item in the list is: " + list[1]);

            // Update an item in the list
            list[2] = "orange";
            Console.WriteLine("The third item in the list is now: " + list[2]);

            // Delete an item from the list
            list.RemoveAt(0);
            Console.WriteLine("The first item in the list has been removed.");

            // Print all items in the list
            Console.WriteLine("Here are all the items in the list:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
