using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 4, 1, 5, 3 };
            Program p = new Program();
            int[] arr2= p.insertionsort(arr);
            foreach(int ele in arr2)
            {
                Console.Write(ele+" ");
            }

        }



        public int[] insertionsort(int[] arr)
        {
            for (int i=0;i<arr.Length;i++)
            {
                int hole_pos = i;
                int value = arr[i];
                while (hole_pos>0&& value<arr[hole_pos-1])
                {
                    arr[hole_pos] = arr[hole_pos - 1];
                    hole_pos = hole_pos - 1;

                }
                arr[hole_pos] = value;
            }
            return arr;
        }
        
    }
}
