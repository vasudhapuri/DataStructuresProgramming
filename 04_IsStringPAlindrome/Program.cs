using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IsStringPAlindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass c= new myclass();
            Console.WriteLine(c.ISPalindrome("madam"));  
            Console.WriteLine(c.ISPalindrome("Malayalam")); 
            Console.WriteLine(c.ISPalindrome("Nyaka")); 
            
        }
    }


    class myclass
    {
        public bool ISPalindrome(string str)
        {
            char[] arr=str.ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);

                if(str.Equals(s))
                return true;
                        else
                return false;



        }
    }

}
