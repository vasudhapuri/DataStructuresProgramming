using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RemoveDuplicatesFromSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddNode(3);
            ll.AddNode(3);
            ll.AddNode(4);
            ll.AddNode(2);
            ll.AddNode(2);
            ll.AddNode(1);
            ll.AddNode(1);
            ll.AddNode(1);          
            
            
            ll.PrintNodes();
            ll.RemoveDuplicates();
            Console.WriteLine();
            ll.PrintNodes();
        }
    }

    public class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
            next = null;

        }

    }
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }

        public void AddNode(int data)
        {
            Node n = new Node(data);
            n.value = data;
            n.next = head;
            head = n;
        }

        public void PrintNodes()
        {

            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;

            }
        }

        public void RemoveDuplicates()
        {

             var c = head;
            if (c == null)
            {
                Console.WriteLine("Linked Lit is empty");
                return;
            }

            var n = c.next;
               
            while (n != null) 
            {
                if (c.value == n.value)
                {
                   
                    n = n.next;
                    

                }

                else
                {
                   
                    c.next = n;
                    c = n;
                    if (n!=null)
                    n = n.next;
                   
                }
            }

        }
    }
}

        


