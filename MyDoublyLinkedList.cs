using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Algorithm
{
    public class MyDoublyLinkedList
    {
        private LinkedListNode first;
        private LinkedListNode last;
        private int count;

        //contructors
        public MyDoublyLinkedList()
        {
            first = last = null;
            count = 0;
        }
        public MyDoublyLinkedList(object data)
        {
            LinkedListNode node = new LinkedListNode(data);
            first = last = node;
            count = 1;
        }
        //prpty
        public int Count { get { return this.count; } }
        //methods;
        public void AddFirst(object data)
        {
            LinkedListNode newnode = new LinkedListNode(data);
            if (count == 0)
                first = last = newnode;
            else
            {
                newnode.next = first;
                first.previous = newnode;
                first = newnode;
            }
            count++;

        }
        public void AddLast(object data)
        {
            LinkedListNode newnode = new LinkedListNode(data);
            if (count == 0)
                first = last = new LinkedListNode(data);
            else
            {
                last.next = newnode;
                newnode.previous = last;
                //new node is linked to the last node
                //make the last
            }
            count++;
        }
        //=============================
        //serch for node
        //public LinkedListNode Find(object data)
        //{
        //    //search for the node with given data
        //    //return null if not found
        //    return null;
        //}
        //===============delet or remove
        //commented out because we needed to use Find elsewhere
        public void RemoveFirst()
        {
            //remove first
            if (count == 0)
                throw new InvalidOperationException("this linked list is empty");
            if(count == 1)
            {
                first = last = null;

            }
            else
            {
                LinkedListNode temp = first.next;//save a fer to the current second node
                first.next = null;//remove link from current first node
                temp.previous = null;//remove link from second node to first node 
                //now the first node is completeled disconnedted from the second node
                //make the second node first
                first = temp;
            }
            //decrement count
            count--;
        }
        public void RemoveLast()
        {
            //remove last
            if(count==0)
                throw new InvalidOperationException("this linked list is empty");
            if (count == 1)
            {
                first = last = null;
            }
            else
            {
                LinkedListNode temp = last.previous;
                last.previous = null;
                temp.next = null;
                last = temp;
            }
            count--;
        }
        //search for a node given data returns the node that contains the given data
        public LinkedListNode Find(object data)
        {
            LinkedListNode temp = first;
            while(temp != null)
            {
                if (data.Equals(temp.data))
                    return temp;
                //next node
                temp = temp.next;
            }
            return null;//not found
        }
        //exercise
        //write a static method that merge two linked list into a single one
        public static MyDoublyLinkedList Merge(MyDoublyLinkedList list1 ,MyDoublyLinkedList list2)
        {
            //merge item form list1 then an item from list2 (will need two temps)f
            //example is list1 contains 1-.2-.3-.4-.5 and list 2 contains 10->20->30
            //then list should contain 1-> 10->2-2->3->30->4->5
            MyDoublyLinkedList list = new MyDoublyLinkedList();
            LinkedListNode temp1 = list1.first;
            LinkedListNode temp2 = list2.first;
            while(temp1 != null && temp2 != null)
            {
                list1.AddLast(temp1.data);
                list2.AddLast(temp2.data);

                temp1 = temp1.next;
                temp2 = temp2.next;
            }
            while(temp1 != null)
            {
                list.AddLast(temp1.data);
                temp1 = temp1.next;
                
            }
            while (temp2 != null)
            {
                list.AddLast(temp2.data);
                temp2 = temp2.next;

            }
            return list;
            //if data is string
            //list1: "Mike"--> "James"--."Robert"--> -->"Kyle-->"Tim"
            //list2: "Sandra"-->"Michelle"-->"Karen"
            //then
            //list = "Mike"--> "Sandra"-->"James"-->"Michelle"-->"Robert"-->"Karen"-->"Kyle"--> "Tim

        }
        public IEnumerator GetEnumerator()
        {
            LinkedListNode temp = first;
            while (temp != null)
            {
                yield return temp.data;


            }
        }

        public void Update(object oldData, object newData)
        {
            LinkedListNode node = Find(oldData);
            if(node != null)
            {
                //found
                //update
                node.data = newData;
                return true;

            }
            else
            {
                return false;
            }
            public void Rotate(int count)
            {
                //rotate the linked list from left to right in circular motion
                //count is the number of rotations don't make a circular linked list
                // save the last data
                object lastdata = last.data;
                //sequence through the linked list

                mylinkedlistnode tempNode = last;
                while(tempNode.previous != null)
                {
                    tempNode.data = tempNode.previous.data;
                    //move temp node
                    tempNode = tempNode.previous;
                }
                //updte the first node
                first.data = lastdata;
              
            }
        }
    }
}
