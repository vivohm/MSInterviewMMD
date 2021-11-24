using System;

namespace InterviewQuestion
{
    public class SinglyLinkList
    {
        public Node Head { get; set; }

        /// <summary>
        /// Shift Node function to rotate singly link list from give k
        /// </summary>
        /// <param name="head">The Node head.</param>
        /// <param name="k">The Integer by which list to be rotated</param>
        /// <returns></returns>
        public Node ShiftNode(Node head, int k)
        {
            if (k == 0 || head == null)
            {
                return head;
            }

            Node tail = head;
            Node currNode = head;
            int nodeLength = 1;

            // Get length of linklist
            while (tail.next != null)
            {
                nodeLength++;
                tail = tail.next;
            }

            // Get the offset for circular index
            int offset = Math.Abs(k) % nodeLength;

            // Get offset from last node incase of postive k
            if (k > 0)
            {
                offset = nodeLength - offset;
            }

            // Return head in case of 0 offset
            if (offset == 0)
            {
                return head;
            }

            for (int i = 1; i < offset; i++)
            {
                currNode = currNode.next;
            }

            tail.next = head;
            head = currNode.next;
            currNode.next = null;

            return head;
        }

    }
    
}
