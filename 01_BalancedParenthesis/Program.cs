using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            balanced b = new balanced();
            bool c = b.check_parenthesis(")[]}");
            Console.WriteLine(c);


        }
    }

    public class balanced
    {
        Stack<char> s = new Stack<char>();
        public bool check_parenthesis(String str)
        {

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    s.Push(c);
              
                if (c == ')')
                {
                    if (s.Count == 0)
                        return false;
                    if (s.Peek() == '(')
                        s.Pop();
                    else
                        return false;

                }
                else if (c == '}')
                {
                    if (s.Count == 0)
                        return false;
                    if (s.Peek() == '{')
                        s.Pop();
                    else 
                        return false;


                }

                else if (c == ']')
                {
                    if (s.Count == 0)
                        return false;
                    if (s.Peek() == '[')
                        s.Pop();
                    else return false;

                }
            }

            if (s.Count == 0)
                return true;
            else return false;
            
            

            }
        }
    }
