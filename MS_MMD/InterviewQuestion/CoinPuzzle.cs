using System;
using System.Collections.Generic;

namespace InterviewQuestion
{
    public class CoinPuzzle
    {
		/// <summary>
		/// Get Max Coin
		/// </summary>
		/// <param name="arr">m x n mattrix</param>
		/// <returns>int</returns>
		public int GetMaxCoin(List<List<int>> arr)
		{
			return GetMaxCoin(arr, 0, 0, arr.Count, arr[0].Count, 0);
		}

		private int GetMaxCoin(List<List<int>> arr, int row, int col, int colLen, int rowLen, int sum)
		{
			if (col < 0 || col >= colLen || row >= rowLen)
			{
				return sum;
			}

			if (row == rowLen - 1)
			{
				return sum + arr[row][col];
			}

			int downCount = GetMaxCoin(arr, row + 1, col, colLen, rowLen, sum + arr[row][col]);
			int leftDigCount = GetMaxCoin(arr, row + 1, col + 1, colLen, rowLen, sum + arr[row][col]);
			int rightDigCount = GetMaxCoin(arr, row + 1, col - 1, colLen, rowLen, sum + arr[row][col]);

			int max = Math.Max(Math.Max(downCount, leftDigCount), rightDigCount);

			if (row == 0 && col < colLen - 1)
			{
				max = Math.Max(GetMaxCoin(arr, row, col + 1, colLen, rowLen, sum), max);
			}

			return max;
		}
	}
    
}
