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
			int n = arr.Count;
			int m = arr[0].Count;
			int?[,] visitedList = new int?[n, m];
			return GetMaxCoin(arr, 0, 0, arr.Count, arr[0].Count, 0, visitedList);
		}

		private int GetMaxCoin(List<List<int>> arr, int row, int col, int colLen, int rowLen, int sum, int?[,] visitedList)
		{
			if (col < 0 || col >= colLen || row >= rowLen)
			{
				return sum;
			}

			if (row == rowLen - 1)
			{
				return sum + arr[row][col];
			}

			// Return max value from visited list if it's max is already calculated adding previous sum 
			if (visitedList[row, col] != null)
			{
				return sum + visitedList[row, col].Value;
			}

			int downCount = GetMaxCoin(arr, row + 1, col, colLen, rowLen, sum + arr[row][col], visitedList);
			int leftDigCount = GetMaxCoin(arr, row + 1, col + 1, colLen, rowLen, sum + arr[row][col], visitedList);
			int rightDigCount = GetMaxCoin(arr, row + 1, col - 1, colLen, rowLen, sum + arr[row][col], visitedList);

			int max = Math.Max(Math.Max(downCount, leftDigCount), rightDigCount);

			// Add max value to visited list subtracting previous sum 
			visitedList[row, col] = max - sum;

			if (row == 0 && col < colLen - 1)
			{
				max = Math.Max(GetMaxCoin(arr, row, col + 1, colLen, rowLen, sum, visitedList), max);
			}

			return max;
		}

	}

}
