using System;

namespace LinearSearchAlgo
{
    class Program
    {
        static int search(int[] arr, int n, int x)
        {
            for  (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 10, 30, 15 };
            int x = 30;
            int n = arr.Length;

            if (search(arr, n, x) > 0)
                Console.WriteLine(x + " is present at index " + search(arr, n, x));
            else
                Console.WriteLine(x + " is not present in the array.");
        }
    }
}
