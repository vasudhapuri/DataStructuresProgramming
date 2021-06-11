using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementQUsingStack_DeQCostly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue m = new MyQueue();
            m.Enqueue(1);
            m.Enqueue(6);
            m.Enqueue(9);
            int removed_element = m.Dequeue();
            Console.WriteLine("removed element is "+ removed_element);
        }

       public class MyQueue
       {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            public void Enqueue(int data)
        {
            s1.Push(data);
        }

        public int Dequeue()
        {

                if(s1.Count==0)
                {
                    Console.WriteLine("stack empty");
                    return -1;
                }
                
                else {
                    while (s1.Count != 0)
                        s2.Push(s1.Pop());
                    return s2.Pop();
                    while (s2.Count != 0)
                        s1.Push(s2.Pop());

                }
        }
    }

   


    }
}
