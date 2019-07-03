using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class LinkedList_InsertAtPosition
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
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    //textWriter.Write(sep);
                    Console.WriteLine(sep);
                }
            }
        }


        /// <summary>
        /// insertNodeAtHead
        /// </summary>
        /// <param name="llist"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            var newNode = new SinglyLinkedListNode(data);
            var temp = head;
            for (int i = 0; temp != null; i++)
            {
                if (i == position - 1)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
            return head;
        }

        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {
            var temp = head;
            if (head.next == null)
            {
                head = null;
                return head;
            }
            if (position == 0)
            {
                return head.next;
            }
            for (int i = 0; temp != null; i++)
            {
                if (i == position - 1 )
                {
                    var m = temp.next.next;
                    temp.next = null;
                    temp.next = m;
                    break;
                }
                temp = temp.next;
            }
            return head;

        }

        static void RemoveMe_Main(string[] args)
        {

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            //int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist_head, " ");
        }
    }
}

