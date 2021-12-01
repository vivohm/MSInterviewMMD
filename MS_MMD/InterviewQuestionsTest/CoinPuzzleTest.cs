using InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InterviewQuestionsTest
{
    public class CoinPuzzleTest
    {
        [Theory]
        [InlineData(@"1 2 3 4, 
                      8 7 6 5,
                      9 10 11 12,
                      16 15 14 13", 36)]

        [InlineData(@"5 10 16, 
                      20 1 0,
                      2 60 70", 90)]
        public void GetMaxCoin_Test(string strMatrix, long expectedOutput)
        {
            var result = RunMaxCoinTest(strMatrix);
            Assert.Equal(result, expectedOutput);
        }

        private int RunMaxCoinTest(string strMatrix)
        {
            string[] strRows = strMatrix.Split(",");
            List<List<int>> matrix = new List<List<int>>();
            foreach (string strRow in strRows)
            {
                matrix.Add(strRow.TrimEnd().Split(' ').ToList().Where(q => !string.IsNullOrWhiteSpace(q)).Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            CoinPuzzle puzzle = new CoinPuzzle();
            return puzzle.GetMaxCoin(matrix);
        }
        
    }
}
