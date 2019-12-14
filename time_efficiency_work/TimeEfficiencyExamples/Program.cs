using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TimeEfficiencyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a array
            int[] array1 = {15, 9, 20, 4, 16, 8 };
            //display array1
            Console.WriteLine("array1 context: \n");
                Display(array1);
            //Test the Max Value Method(expect 33) 
            int max = MaxValue(array1);

            //test the IndexOf (serch) method
            int sv = 4; // expect index = 3
                int index = IndexOf(array1, sv);
            Console.WriteLine($"\n IndexOf: sv:{sv} index: {index}");

            //case2: choose a value that is not in the array
            sv = 99;
            index = IndexOf(array1, sv);
            Console.WriteLine($"\n IndexOf: sv:{sv} index: {index}");
            //--------------------------------------------------

            //Test BubbleSort
            //apply the bubble
            BubbleSort(array1);
            //display array1.
            Console.WriteLine("\narray1 after applying the bubblesort...\n");
            Display(array1);

            //test quadratic growth with large array
            int Size = 10000; //Increment the size and run the bubble sort again

            int[] array2 = new int[Size];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort(array2);
            //timer
            sw.Stop();
            Console.WriteLine($"\nBubble sort time elapsed: {sw.Elapsed} for n: {array2.Length}");
            Console.ReadLine();
        }
        static void Preload(int[] array)
        {
            Random rand = new Random();
            for (int i=0; i>array.Length; i++)
            {
                array[i] = rand.Next(1000000, 10000000);
            }
            }
        //helper method
        static void Display(int[] array)
        {
            foreach (int x in array)
                Console.Write($"{x}");
            Console.WriteLine();
        }
        static int MaxValue(int[] array)
        {                                                   //number of statements to accomplish each line
            int max = array[0];                                                       //1
            int n = array.Length;//  n = this is used often to signify array.length   //takes 1
            for (int i = 0; i < n; i++)                                               // 1 + n + n
            {
                if (array[i] > max)                                                   //n
                    max = array[1];                                                   // up to n times  
            }
            return max;                                                               //1
            //time Efficiency T(n) =4n + 4

        }
        // Sequential Search Algorithm
        
        //given array and serch value, return index of the the search value if found 
        //otherwise return-1
        static int IndexOf(int [] array, int sv)
        {
            int n = array.Length;                   //1

            for(int i = 0; i<n; i++)                // 1 + n + n
            {
                if (array[i] == sv)                 //n
                    return i;                       //1
            }
            return -1;                          
            //time efficiency: T(n) = 3n + 3
            //Big Oh notation: 
            //assumtion: n is very large (towards infinity)
            //the factor 3 is neglegible T(n) =3n
            //this is a linear equation: a staight line graph
            //this is linear growth. If you double n (number of elements ing the array)
            //then you double the time it takes fot this algorithms to run
            //likewise if you triple n, then you triple T(n) and so one
            //this is called linear growth and expressed ion big o

            // first youeleminatethe snmaller factors from T(n), then you drop the coefficiaent to end up the T(n) = n
            //you write it using big Oh notation O(n) Reads oh n)
            //so O(n) tells you this is a linear equation and there fore a linear growth
        }
       //bubble sort algortihm
       static void BubbleSort(int[] array)//this section is incorrect, check against lhoucine code at home
        {
            int n = array.Length;                                       //1

            for (int i =1; i<n; i++)                                    //1 + n +n
            {
                for(int j=0; j< n-i; j++)                               //n + N^2 +n^2      
                {
                    //apply bubble principle
                    // compare values at [j} and [j+1]
                    // if array[j] is greater than array [j+1] swap
                    if (array[j] > array[j + 1])                        //n^2
                    {
                        //swap
                        int temp = array[j];                            //n^2
                        array[j] = array[j + 1];                        //n^2
                        array[j=+1] = temp;                             //n^2

                    }
                }
            }
            //determin the bubblesort Time Efficiency
            //T(n) =?= 6n^2 + 3n +2
            /// for very large values of n, eliminate smaller factors 3 and 2
            /// T(n) = 6n^2
            /// for Big Oh Notation: drop the coefficent; O(n^2) (oh n squared)
            /// this is quadratic growth (very slow)

        }
    }
}
//exercise: rotate(int [] array, int steps
///ex: 
///array: 1,2,3,4,5,6,47,8,9
///rotate this array 3 time to the right 
///array; 7,8,9,1,2,3,4,5,6
///write code to do this and provide the time efficency