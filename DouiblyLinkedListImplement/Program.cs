using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouiblyLinkedListImplement
{

   public class Node
    {
       public Node prev;
       public Node Next;
       public int value;

       public Node(int val)
        {
             prev = null;
             Next = null;
             value = val;
        }

    }

    public class LinkedList

    {
        int data;
        Node head;
        public LinkedList()
        {
            
            head = null;

        }
        public void AddNode(int data)
        {

            Node n = new Node(data);
            n.value = data;
            n.Next = head;
            head.prev = n;
            head = n;

        }

       

    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddNode(10);
            ll.AddNode(20);
            ll.AddNode(30);
        }
    }
}
