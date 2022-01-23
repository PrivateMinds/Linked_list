using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


namespace Linked_list
{
   public static class LinkedListHelpers
    {
       
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        public class RemoveDuplicate<T>
        {
            //Represent the head and tail of the singly linked list  
            public Node<T> head = null;
            public Node<T> tail = null;
            int count = 0;

            //addNode() will add a new node to the list  
            public void addNode(T data)
            {
                //Create a new node  
                Node<T> newNode = new Node<T>(data);

                //Checks if the list is empty  
                if (head == null)
                {
                    //If list is empty, both head and tail will point to new node  
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    //newNode will be added after tail such that tail's next will point to newNode  
                    tail.next = newNode;
                    //newNode will become new tail of the list  
                    tail = newNode;
                }
            }

            //removeDuplicate() will remove duplicate nodes from the list  
            public void removeDuplicate()
            {
                //Node current will point to head  
                Node<T> current = head, index = null, temp = null;

                if (head == null)
                {
                    return;
                }
                else
                {
                    while (current != null)
                    {
                        //Node temp will point to previous node to index.  
                        temp = current;
                        //Index will point to node next to current  
                        index = current.next;

                        while (index != null)
                        {
                            
                            //If current node's data is equal to index node's data  
                            if (current.data.Equals(index.data))
                            {
                                count++;

                                //Here, index node is pointing to the node which is duplicate of current node  
                                //Skips the duplicate node by pointing to next node
                                if(count > 3)
                                {
                                    temp.next = index.next;
                                }
                                

                            }
                            else
                            {
                                //Temp will point to previous node of index.  
                                temp = index;
                            }
                            index = index.next;
                        }
                        current = current.next;
                    }
                }
            }

            //display() will display all the nodes present in the list  
            public void display()
            {
                //Node current will point to head  
                Node<T> current = head;
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                while (current != null)
                {
                    //Prints each node by incrementing pointer  
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }
    }
}
