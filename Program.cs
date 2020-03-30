using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics;

namespace Selection_Insertion_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the selection sort
            int[] array1 = { 20, 6, 12, 8, 3, 19, 25, 15 };
            Console.WriteLine("array1 before sorting:");
            Display(array1);
            //selection sort
            SelectionSort(array1);
            Console.WriteLine("\narray1 after Selection sorting:");
            Display(array1);

            //test the insertion sort algorithm
            int[] array2 = { 20, 6, 12, 8, 3, 19, 25, 15 };
            Console.WriteLine("\n\n\narray2 before sorting;");
            Display(array2);
            //insertionSort
            InsertionSort(array2);
            Console.WriteLine("\narray2 After insertion sorting");
            Display(array2);

            Console.ReadLine();
        }
        static void Display(int[] array)
        {
            foreach (int x in array)
            {
                Console.WriteLine($"{x} ");

            }
            Console.WriteLine();
        }
        //selection sort:
        //1.start at pointer index 1 set to 0 
        // 2.search for the min value from  i to end
        //3.swap minvalue with value at i
        // 4, increment i and repeat previous steps 
        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                // int minValue = array[i];

                for (int j = i; j < n; j++)//search for min
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                // swap at minIndex with value at i
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;

            }

        }
        static void InsertionSort(int [] array)
        {
            int n = array.Length;
            //outer loop moves the pointer index
            for (int i = 1; i< n; i++)
            {
                int j = i;

                int temp = array[i];

                while(j>0 && temp < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] =temp;
            }
        }

    }
}

//insertion sort
//divide the array into 2 parts the left and the right part
//the left begings with ones element at array[0]
//the right starts out eith the rest of the elementd
// start pointer at index i at 1
//the idea is to insert the value at i into the left part while 
// keeping the left always sorted 
//we move elements from the right side to the left at their sorted
//positions
//repeat process in the right part


    //outer loop moves the pointer index from 1 to end
    