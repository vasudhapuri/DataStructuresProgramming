using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 19, 21, 67, 78, 88, 100 };
            int[] arr2=bubblesort(arr);
           foreach (int ele in arr2)
                Console.Write(ele+" ");

            
            
        }


        public static int[] bubblesort(int[] arr)
        {
            for (int itr = 0; itr <arr.Length;itr++)//if 6 elements=> then 5 iterations are needed since first element will be by default sorted
            {
                for (int c = 0; c < arr.Length - 1; c++)  //if 6 elements=> means till 5 index=>means comparison till index 4=> ie. till c=4 bcoz if c=5 then c+1 will be out of array bounds
                {
                    if (arr[c] > arr[c + 1])
                    {
                        int temp = arr[c];
                        arr[c] =arr[c + 1];
                        arr[c + 1] = temp;
                    }

                    
                 }
                        
            }
            return arr;
        }
            
    }
}
