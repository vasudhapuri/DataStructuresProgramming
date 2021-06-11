using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 1, 5, 3, 7, 2 };
            int[] arr2=quicksort(arr, 0, arr.Length-1);
            foreach(int ele in arr2)
                Console.WriteLine(arr2);
        }

        public static int[] quicksort(int[] arr, int start, int end) //start=start index, end= end index

        {

            if (start > end)
                return arr;
            else
            {
                int pivot = start;
                int left = start + 1;
                int right = end;

                while (left <= right)
                {
                    if (arr[left] > arr[pivot] && arr[right] < arr[pivot])
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                    if (arr[left] <= arr[pivot])
                    {
                        left = left + 1;
                    }
                    if (arr[right] >= arr[pivot])
                    {
                        right = right - 1;
                    }
                }

                int temp1 = arr[pivot];
                arr[pivot] = arr[right];
                arr[right] = temp1;

                quicksort(arr, start, right - 1);
                quicksort(arr, right + 1, end);
                return arr;

            }
        }
       
    }
}
