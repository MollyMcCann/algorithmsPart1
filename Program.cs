using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace LinkedList_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDoublyLinkedList list1 = new MyDoublyLinkedList();
            MyDoublyLinkedList list2 = new MyDoublyLinkedList();

            list1.AddLast("Mike");
            list1.AddLast("James");
            list1.AddLast("Robert");
            list1.AddLast("Kyle");
            list1.AddLast("Tim");

            list2.AddLast("Sandra");
            list2.AddLast("Michelle");
            list2.AddLast("Karen");
            //display both lists
            Console.WriteLine("list1:");
            Display(list1);
            Console.WriteLine("list2:");
            Display(list2);
            // add more here you are missing a lot
            Console.ReadLine();

            //apply the merge
            MyDoublyLinkedList list = MyDoublyLinkedList.Merge(list1, list2);


        }
        static void Display(MyDoublyLinkedList list)
        {
            foreach(object data in list)
            {
                Console.Write($"{data} -->");
            }
            Console.WriteLine("null");
        }

        public static bool Update(object oldData,object newData)
        {
            //get node that holds oldData
            //if found set its Data to newData,Return true
            //otherwise return false
            //use find method
            
        }
    }
}


///homework
///add a method Update (object olddata, object new data)
///this method search for a node with the given old data and replace it with new data
///otherwise return false if  not found or choose to throw and exception if not found
///
//add a methor rotate(int count)// left to right in circular motion  as many times as indecated by ther count