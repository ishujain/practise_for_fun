using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class LinkedList_DeleteDuplicate
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



        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head)
        {
            var temp = head;
            while (temp != null && temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    if (temp.next.next == null)
                    {
                        temp.next = null;

                    }
                    else
                        temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return head;
        }

        static void RemoveME_Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = removeDuplicates(llist.head);

                //PrintSinglyLinkedList(llist1, " ", textWriter);
                Console.WriteLine();
            }
        }
    }
}