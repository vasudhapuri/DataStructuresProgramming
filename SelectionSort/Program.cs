using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 20,12,10,15,2 };
            int[] arr2 = selectionsort(arr);
            foreach(int element in arr2)
                Console.Write(element+ " ");
        }


        public static int[] selectionsort(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 2;i++)
            {
                int min_pos = i;
                
                    for (int j = i + 1; j <= arr.Length - 1; j++)
                    {
                        if (arr[min_pos] > arr[j])
                        {
                            min_pos = j;

                        }
                        int temp = arr[min_pos];
                        arr[min_pos] = arr[i];
                        arr[i] = temp;
                    }

                    
                }
            return arr;
        }

            


        }
    }

