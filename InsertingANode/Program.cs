using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingANode
{
    public class Node
    {
        public int value;
        public Node Next;
        public Node(int val)
        {
            value = val;
            Next = null;
        }
    }

    //linked list class- with AddNode and PrintLinkedList methods
    public class LinkedList
    {
        Node head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        //inserting at start
        public void AddNodeToStart(int data)
        {
            Node node = new Node(data);
            //node.value = data;
            node.Next = head;
            head = node;
            count++;
        }

        public void PrintLinkedList()
        {

            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.Next;
            }


        }

        // insert node at end
        public void InsertNodeAtEnd(int data)
        {

            Node n = new Node(data);
            Node temp = head;
            while(temp.Next!=null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Next = null;

        }
        //insert node at position 2
        public void InsertAtMiddle(int data)
        {
            int c = 0;
            Node temp = head;
            Node n = new Node(data);
                while (c!=1)
            {
                temp = temp.Next;
                c++;
               
            }
            n.Next = temp.Next;
            temp.Next = n;
            
        }

    }


    // class with main method where elements are added in linked list
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddNodeToStart(53);
            ll.AddNodeToStart(17);
            ll.AddNodeToStart(10);
            ll.InsertNodeAtEnd(100);
            ll.InsertAtMiddle(102);


            ll.PrintLinkedList();

        }
    }
}
