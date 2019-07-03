using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class LinkedList_MergeSortedLists
    {


        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }

        // Complete the mergeLists function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        /// <summary>
        /// RECURSIVE
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        /// 
        //Node MergeLists(Node a, Node b)
        //{
        //    if (a == null)
        //    {
        //        return b;
        //    }
        //    else if (b == null)
        //    {
        //        return a;
        //    }

        //    if (a.data < b.data)
        //    {
        //        a.next = MergeLists(a.next, b);
        //        return a;
        //    }
        //    else
        //    {
        //        b.next = MergeLists(a, b.next);
        //        return b;
        //    }
        //}


        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var temp1 = head1;
            var temp2 = head2;
            bool flag = true;
            SinglyLinkedListNode temp = null;
            SinglyLinkedListNode sortedList = null;
            while (flag)
            {
                if (temp1.data >= temp2.data)
                {
                    if (temp == null)
                    {
                        temp = new SinglyLinkedListNode(temp2.data);
                        sortedList = temp;
                        temp2 = temp2.next;

                    }
                    else
                    {
                        temp.next = temp2;
                        temp = temp.next;
                        temp.data = temp2.data;
                        temp2 = temp2.next;
                    }

                }
                else if (temp2.data > temp1.data)
                {
                    if (temp == null)
                    {
                        temp = new SinglyLinkedListNode(temp1.data);
                        sortedList = temp;
                        temp1 = temp1.next;
                    }
                    else
                    {
                        temp.next = temp1;
                        temp = temp.next;
                        temp.data = temp1.data;
                        temp1 = temp1.next;
                    }
                }
                if (temp1 == null)
                {
                    temp.next = temp2;
                    flag = false;
                }
                else if (temp2 == null)
                {
                    temp.next = temp1;
                    flag = false;
                }
            }

            return sortedList;
        }


        static void RemoveMe_Main(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                //SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);
                SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

                PrintSinglyLinkedList(llist3, " ");
                Console.WriteLine();
            }
        }
    }

}
