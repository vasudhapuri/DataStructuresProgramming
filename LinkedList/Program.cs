using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //add elements to LL
            LinkedList<String> ll = new LinkedList<String>();
            ll.AddLast("naima");
            ll.AddLast("sania");
            ll.AddLast("bini");
           var node1= ll.AddLast("honey");
            ll.AddLast("preeti");
            Console.WriteLine("all elements in linked list are");
            foreach (var element in ll)
                Console.WriteLine(element);
            ll.AddFirst("Kavya");
            ll.AddBefore(node1, "Shaina");
            Console.WriteLine();
            foreach (var element in ll)
                Console.WriteLine(element);
            var node2 = ll.AddLast("Vanya");
            var node3 = "Supriya";
            ll.AddBefore(node2, node3);
            Console.WriteLine();
            foreach (var element in ll)
                Console.WriteLine(element);


            //removing elements
            ll.Remove(node3);
            ll.RemoveFirst();
            ll.Remove("naima");
            Console.WriteLine();
            foreach (var element in ll)
                Console.WriteLine(element);

            //availability of element
            Console.WriteLine();
            Console.WriteLine(ll.Contains("preeti"));  

        }
    }
}
