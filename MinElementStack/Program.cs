using System;
using System.Collections;
using System.Collections.Generic;


namespace MinElementStack
{
    class Program
    {
        Stack<int> s = new Stack<int>();
        Stack<int> min_stack = new Stack<int>();
        static void Main(string[] args)
        {
            Program s = new Program();
            s.push(3);
            s.push(5);
            s.MinElement();
            s.push(2);
            s.push(1);
            s.MinElement();
            s.pop();
            s.MinElement();
            s.pop();
            s.MinElement();
        }

        public  void push(int x)
        {
            if (min_stack.Count == 0 || x < min_stack.Peek())
            {
                s.Push(x);
                min_stack.Push(x);
                Console.WriteLine("num inserted is " + x);
            }
            //else if (min_stack.Peek() > x)
            //{
            //    s.Push(x);
            //    min_stack.Push(x);
            //    Console.WriteLine("num insetres is " + x);

            //}
            else
            {
                s.Push(x);
                Console.WriteLine("num inserted is " + x);
            }
        }
        public void pop()
        {
            if (s.Peek() == min_stack.Peek())
            {
                int ele = s.Pop();
                min_stack.Pop();
                Console.WriteLine("element removed is " + ele);

            }
            else
            {
                int ele=s.Pop();
                Console.WriteLine("element removed is " + ele);
            }
            
        }
        public void MinElement()
        {
            int min_ele = min_stack.Peek();
            Console.WriteLine("minimum element in stack is " + min_ele);



        }
    }
}
