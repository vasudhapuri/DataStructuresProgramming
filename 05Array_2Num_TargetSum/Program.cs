using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Array_2Num_TargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass m = new myclass();
            //foreach (var ele in m.TargetSum(new int[] { 1, 3, 5, 8, 9 }, 10))
            //  Console.WriteLine(ele);
            foreach (var ele in m.TargetSum_Ht(new int[] { 1, 3, 7, 8, 9 }, 8))
            Console.WriteLine(ele);



        }
    }

    class myclass
    {
        //using multiple loops (more time complexity)
               public int[] TargetSum(int[] Array, int target)
        {

            if (Array.Length==0)
            {
                Console.WriteLine("no element in array");
            }
            for(int i=0;i<Array.Length-1; i++)
            {
                int f = Array[i];
                for (int j=i+1;j<Array.Length;j++)
                {
                    int s = Array[j];
                    if (f+s==target)
                    {

                        return new int[] { f, s };
                            
                    }
                }
            }
            return new int[0];
        }

        //using hashtable
        public int[] TargetSum_Ht(int[] Array, int target)
        {

            HashSet<int> ht = new HashSet<int>();
            foreach (int ele in Array)
            {
                int y = target - ele;
                if (ht.Contains(y))
                    return new int[] { ele, y };
                else 
                    ht.Add(ele);
            }
            return new int[0];
        }


        }
            
        }
    