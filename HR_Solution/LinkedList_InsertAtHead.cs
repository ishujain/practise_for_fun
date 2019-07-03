using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class LinkedList_InsertAtHead
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

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    //textWriter.Write(sep);
                    Console.WriteLine(sep);
                }
            }
        }

        // Complete the insertNodeAtTail function below.

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
        /// insertNodeAtHead
        /// </summary>
        /// <param name="llist"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            var newNode = new SinglyLinkedListNode(data);
            if (llist == null)
            {
                return newNode;
            }
            else
            {
                newNode.next = llist;
            }
            return newNode;
        }


        static void RemoveMe_Main(string[] args)
        {

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                //SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;

            }
            PrintSinglyLinkedList(llist.head, "\n");
        }
    }
}

