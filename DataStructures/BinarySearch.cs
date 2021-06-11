using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 19, 21, 67, 78, 88, 100 };
            Console.WriteLine("Enter num to be searched");
            int num = int.Parse(Console.ReadLine());
            int result = binarysearch(num, arr);
            if (result == -1)
                Console.WriteLine("element not found ");
            else
                Console.WriteLine("element found at " + result + " position");

        }

        public static int binarysearch(int n, int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (n == arr[mid])
                    return mid;
                else if (n > arr[mid])
                { l = mid + 1; }
                else if (n < arr[mid])
                { r = mid - 1; }

            }
            return -1;



        }
    }
    }

