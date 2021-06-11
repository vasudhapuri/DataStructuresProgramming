using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = { 4, 5, 6, 1, 3, 7, 2, 9 };
           int[] arr2= mergesort(arr);
            foreach( int element in arr2)
                Console.Write(element+" ");

        }

        public static int[] mergesort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;
            else
            {
                int mid = arr.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[arr.Length - mid];

                for (int i = 0; i < mid; i++)
                    left[i] = arr[i];
                for (int j = mid; j < (arr.Length); j++)
                    right[j-mid] = arr[j];

                mergesort(left); //recursive call for right array to slice it
                mergesort(right); // recusrsive fn call for right array to slice it
                merge(left, right, arr);
            }
            return arr;
        }

        public static int[] merge(int[] left, int[] right, int[] arr)
        {
            int elements_in_left = left.Length;
            int elements_in_right = right.Length;
            int i = 0;
            int j = 0;
            int k = 0;

            while(i< elements_in_left &&j<elements_in_right)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    k = k + 1;
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    k = k + 1;
                    j = j + 1;
                }

            }

            while (i<elements_in_left)
            {
                arr[k] = left[i];
                    k = k + 1;
                    i = i + 1;
            }

            while (j<elements_in_right)
            {
                arr[k] = right[j];
                k = k + 1;
                j = j + 1;

            }
            return arr;
            }

        }
    }


