using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input singly link list seperated by space: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            Console.Write("Input number(k) for list to be rotated: ");
            int k = Convert.ToInt32(Console.ReadLine().Trim());
            
            SinglyLinkList singlyLinkList = arr.ToSinglyLinkList();

            var newHeadNode = singlyLinkList.ShiftNode(singlyLinkList.Head, k);

            List<int> output = newHeadNode.ToList();

            Console.WriteLine($"\nInput List: {string.Join(' ', arr)}\nK: {k}\nOutput: {string.Join(' ', output)}");
            Console.ReadLine();
        }
    }
}
