using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};
            // TODO: Create the list
            List<string> strList = new List<string>(10);

            // TODO: Add some elements to the list from an existing array
            strList.AddRange(comedians);

            // TODO: Add individual items
            strList.Add("Random comedian one");
            strList.Add("Random comedian two");

            // TODO: Examine the Count and Capacity
            Console.WriteLine($"Count and Capacity: {strList.Count}, {strList.Capacity}");

            // TODO: Enumerate the items in the list with a foreach loop
            PrintList(strList);

            // TODO: Access any item by its index
            Console.WriteLine($"Item value: {strList[4]}");

            // TODO: Remove items from the list
            strList.RemoveAt(7);
            PrintList(strList);

            // TODO: Sort the list content
            strList.Sort();

            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item


            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list


            // TODO: Use the Find function to search through items


            // TODO: The FindAll function can find multiple items


            // TODO: Use TrueForAll to see if a given condition is true for all elements

        }

        static void PrintList(List<string> theList)
        {
            foreach (string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
