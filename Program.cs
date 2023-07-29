using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._33
{
    internal class Program
    {
        public static void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }

        public static int partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Elements");
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            quickSort(Arr, 0, n - 1);
            Console.WriteLine("After Quick Sort");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Console.ReadKey();
        }
    }
}
