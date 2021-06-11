using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkeeistImplementation
{
    //node class- with value and head 

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
            while(current!=null)
            {
                Console.WriteLine(current.value);
                current = current.Next;
            }
            Console.WriteLine("count of nodes is "+count);

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
            ll.AddNodeToStart(23);
            ll.AddNodeToStart(33);
            ll.AddNodeToStart(13);
            ll.PrintLinkedList();

        }
    }
}
   