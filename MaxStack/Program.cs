using System;
using System.Collections.Generic;

namespace MaxStack
{
    class Program
    {
        static void Main(string[] args)
        {
            mystack s = new mystack();
            s.push(3);
            s.push(5);
            s.maxele();
            s.push(7);
            s.push(19);
            s.maxele();
            s.pop();
            s.maxele();
            s.pop();

        }
    }

        public class mystack
        {
            Stack<int> s = new Stack<int>();
            Stack<int> max_stack = new Stack<int>();
            public void push(int x)
            {

                if (max_stack.Count == 0 || (x > max_stack.Peek()))
                {
                    s.Push(x);
                    max_stack.Push(x);
                    Console.WriteLine("element pushed is " + x);

                }
                else
                {
                    s.Push(x);
                    Console.WriteLine("element pushed is " + x);

                }
            }

            public void pop()
            {
                if (max_stack.Peek() == s.Peek())
                {
                    int ele = s.Pop();
                    max_stack.Pop();
                    Console.WriteLine("Element popped is " + ele);
                }
                else
                {
                    int ele = s.Pop();
                    Console.WriteLine("Element popped is " + ele);

                }

            }

            public void maxele()
            {
                int max = max_stack.Peek();
                Console.WriteLine("maximum element is " + max);


            }


        }
    }

