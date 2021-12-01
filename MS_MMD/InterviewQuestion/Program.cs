using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Word2Number();
            ShiftNode();
            GetMaxCoinFromPuzzel();
        }

        static void GetMaxCoinFromPuzzel()
        {
            Console.Write("Input space seperated n and m value: ");
            string[] nXm = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nXm[0]);
            int m = Convert.ToInt32(nXm[1]);
            List<List<int>> matrix = new List<List<int>>();

            Console.WriteLine("Input each of seperated by space: ");
            
            for (int i = 0; i < m; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            CoinPuzzle puzzle = new CoinPuzzle();
            int max = puzzle.GetMaxCoin(matrix);
            Console.WriteLine($"\nMax coins can be collected: {max} from given matrix");
            Console.ReadLine();

        }

        static void Word2Number()
        {
            Word2Number wtn = new Word2Number();
            Console.Write("Input number in word: ");
            string word = Console.ReadLine();
            var num = wtn.TranslateWord2Number(word);
            Console.WriteLine($"\nInput word: {word}\nOutput: {num}");
            Console.ReadLine();

        }
        static void ShiftNode()
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
