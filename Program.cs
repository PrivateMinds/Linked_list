using System;
using static Linked_list.LinkedListHelpers;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate<string> sList = new RemoveDuplicate<string>();

            //Adds data to the list  
            sList.addNode("E");
            sList.addNode("B");
            sList.addNode("E");
            sList.addNode("E");
            sList.addNode("B");
            sList.addNode("A");
            sList.addNode("B");

            Console.WriteLine("Originals list: ");
            sList.display();

            //Removes duplicate nodes  
            sList.removeDuplicate();

            Console.WriteLine("List after removing duplicates: ");
            sList.display();
        }
    }
}
