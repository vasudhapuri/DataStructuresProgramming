using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ImplementqusingStack_EnQCostly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue m = new MyQueue();
            m.enqueue(2);
            m.enqueue(4);
            m.enqueue(6);
            m.enqueue(11);
            Console.WriteLine("element removed is "+ m.dequeue());
        }

        public class MyQueue
            {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2=  new Stack<int>();
            public void enqueue(int data)
            {

                
                if(s1.Count==0)
                {
                    s1.Push(data);

                }
                else
                
                {
                    while(s1.Count!=0)
                    s2.Push(s1.Pop());

                    s1.Push(data);

                    while(s2.Count!=0)
                    s1.Push(s2.Pop());

                }                             


            }
            public int dequeue()
            {
                if (s1.Count==0)
                {
                    Console.WriteLine("stack empty");
                    return -1;
                }
                else
                {
                    return s1.Pop();
                }
            }

            }

    }
}
