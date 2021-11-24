using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    public static class Extensions
    {
        public static List<int> ToList(this Node headNode)
        {
            List<int> output = new List<int>();

            Node head = headNode;

            while (head != null)
            {
                output.Add(head.value);
                head = head.next;
            }

            return output;
        }

        public static SinglyLinkList ToSinglyLinkList(this List<int> arr)
        {
            Node head = null;
            Node currNode = null;

            foreach (int i in arr)
            {
                Node newNode = new Node(i);

                if (head == null)
                {
                    head = newNode;
                    currNode = head;
                }
                else
                {
                    currNode.next = newNode;
                    currNode = newNode;
                }
            }

            SinglyLinkList singlyLinkList = new SinglyLinkList { Head = head };

            return singlyLinkList;
        }
    }
}
