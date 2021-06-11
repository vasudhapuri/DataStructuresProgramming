using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChkIfLinkedListIsCircular
{
    class Program
    {

        

            static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
        
            var v1=ll.AddNode(11);
            ll.AddNode(15);            
           ll.AddNode(64);            
            var v2=ll.AddNode(28);
            ll.AddNode(41);
            ll.AddNode(22);
          ll.AddNode(99);
            v1.next = v2;

           ll.Printhead();
            ll.HasLoop();

        }
    }


    //start of node class
    public class Node
        {
        public Node next;
        public int value;


        public Node(int val)
    {
        value = val;
        next = null;
    }
        }
    //end of node class

    //start of Linked list class
    public class LinkedList
    {
       public Node head;
        public LinkedList()
            {
            head= null;
            }
    public Node AddNode(int data)
    {
        Node n = new Node(data);
            n.value = data;
            n.next = head;
            head = n;
            return n;

    }
        public void Printhead()
        {
            Console.WriteLine(head.value);

        }

        //function to check if linked list has loop
        public void HasLoop()
        {
            var p = head;
            var q = head;

            do
            {
                p = p.next;
                q = q.next.next;
            }
            while (p != q);
          
            Console.WriteLine(  "linked list has a loop");
            q = head;
            while(p!=q)
            {
                p = p.next;
                q = q.next;
            }
            Console.WriteLine("node intersection start point is at "+p.value);

        }

        
    }

}
