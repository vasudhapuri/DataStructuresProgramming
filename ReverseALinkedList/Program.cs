using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedList
{

    public class Node
    {
        public string value;
        public Node next;

        public Node(string val)
        {
            value = val;
            next = null;
        }

    }

    public class LinkedList
    {
        Node head;
        public LinkedList()
        {
            head = null;
        }

        public void AddNodeToStart(string data)
        {
            Node node = new Node(data);
            node.value = data;
            node.next = head;
            head = node;
        }
        public void PrintNodes()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }

            public void ReverseNodes()
            {
                Node prev = null;
                Node current = head;
                Node temp = head.next;
                while (current != null)
                {
                current.next = prev;
                prev = current;
                current = temp;
                if(temp!=null)
                    temp = temp.next;
                }
            head = prev;
            PrintNodes();

            }

    }
    class Program
    {

         
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddNodeToStart("Sukanya");
            ll.AddNodeToStart("Nisha");
            ll.AddNodeToStart("Kavya");
            ll.AddNodeToStart("Prisha");
            ll.AddNodeToStart("Mini");

            ll.PrintNodes();
            Console.WriteLine();
            ll.ReverseNodes();
            
            //ll.PrintNodes();

        }
    }
}
