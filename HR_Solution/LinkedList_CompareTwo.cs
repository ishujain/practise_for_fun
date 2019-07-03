using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class LinkedList_CompareTwo
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

        // Complete the CompareLists function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var temp1 = head1;
            var temp2 = head2;
            int count1 = 0, count2 = 0;
            bool flag = true;
            while (flag)
            {
                if (count1 != count2)
                {
                    return false;
                }
                else
                {
                    count1 += 1;
                    count2 += 1;
                }
                if (temp1.data != temp2.data)
                {
                    return false;
                }
                temp1 = temp1.next;
                if (temp1 != null)
                {
                    count1 += 1;
                }
                temp2 = temp2.next;
                if (temp2 != null)
                {
                    count2 += 1;
                }
                if (temp1 == null && temp2 == null)
                {
                    return true;
                }
            }
            if (count1 != count2)
            {
                return false;
            }
            return true;
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

                bool result = CompareLists(llist1.head, llist2.head);

                Console.WriteLine((result ? 1 : 0));
            }
        }
    }
}