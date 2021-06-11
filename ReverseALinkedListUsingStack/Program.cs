using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedListUsingStack
{

    public class Node
    {
        public char value;
        public Node next;

        public Node (char val)
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
        public void AddNode(char data)
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

        public void ReverseNodes()
        {
            Stack<char> s = new Stack<char>();
            Node temp = head;
            while(temp!=null)
            {
                s.Push(temp.value);
                temp = temp.next;
              

            }
            while(s.Count!=0)
            {
                Console.WriteLine(s.Peek());
                char c = s.Pop();
                Console.WriteLine(c);
            }
        
          

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddNode('o');
            ll.AddNode('l');
            ll.AddNode('l');
            ll.AddNode('e');
            ll.AddNode('h');
            ll.PrintNodes();
            Console.WriteLine();
            ll.ReverseNodes();

        }
    }
}
