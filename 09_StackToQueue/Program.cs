using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StackToQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            Stack s2 = new Stack();
            Queue s3 = new Queue();
            s1.Push("niharika");
            s1.Push(21);
            s1.Push('c');
            s1.Push(33);

            while (s1.Count != 0
                )
            {
                s2.Push(s1.Pop());
            }
            while (s2.Count!=0)
            {
                s3.Enqueue(s2.Pop());

            }

            Console.WriteLine("first element to come out of queue is " + s3.Peek()); 
           

        }
    }
}
