using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDelete
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
            Console.WriteLine("count of nodes is " + count);

            //print value at position 3
            int c = 0;
            Node temp = head;
            while (c != 3)
            {
                temp = temp.Next;
                c++;
            }
            Console.WriteLine("value at position 3 is " + temp.value);


        }


       

        public void DeleteNode()
        {
            //delete first node;
            //head = head.Next;
            // Console.WriteLine("count after deletion is"+ (count-1));

            //delete last node
            //Node temp = head;
            //while (temp.Next.Next != null)
            //{
            //    temp = temp.Next;

            //}
            //temp.Next = null; 

            //delete node with value 10
            //Node temp = head;
            //while(temp.Next.value!=10)
            //{
            //    temp = temp.Next;
            //}
            //temp.Next = temp.Next.Next;

            //delete node at position 3
            Node temp = head;
            int c=0;
            while(c!=2)
            {
                temp = temp.Next;
                c++;
            }

                temp.Next = temp.Next.Next;
                  

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
            ll.DeleteNode();
            ll.PrintLinkedList();

        }

    }
}
