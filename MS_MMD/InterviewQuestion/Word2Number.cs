using System;
using System.Collections.Generic;

namespace InterviewQuestion
{
    public class Word2Number
    {
        Dictionary<string, long> multiplierArr = new Dictionary<string, long> { { "hundred", 100 }, { "thousand", 1000 }, { "lakh", 100000 }, { "million", 1000000 }, { "billion", 1000000000 }, { "trillion", 1000000000000 } };

        Dictionary<string, int> unitArr = new Dictionary<string, int> {
        {"one",1},
        {"two",2},
        {"three",3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven",7},
        {"eight",8},
        {"nine",9},
        {"ten", 10},
        {"eleven", 11},
        {"twelve",12},
        {"thirteen", 13},
        {"forteen", 14},
        {"fifteen", 15},
	    {"twenty", 20},{"thirty", 30},
        {"forty", 40},
        {"fifty", 50}};

        /// <summary>
        /// Translate Word to Number
        /// </summary>
        /// <param name="numberWord">Number in word string</param>
        /// <returns>long</returns>
        public long TranslateWord2Number(string numberWord)
        {
            if (string.IsNullOrWhiteSpace(numberWord))
            {
                return 0;
            }
            string[] numberWordArr = numberWord.ToLower().Split(" ");
            return GetNumber(numberWordArr, numberWordArr.Length - 1);
            
        }

        private long GetNumber(string[] str, int endIndex)
        {
            long multiplier = 1;
            long result = 0;

            while (endIndex >= 0)
            {
                string currNumberStr = str[endIndex];

                string tempCurrNumberStr = currNumberStr.Replace("teen", "").Replace("ty", "");

                if (!unitArr.ContainsKey(currNumberStr) && !multiplierArr.ContainsKey(currNumberStr) && unitArr.ContainsKey(tempCurrNumberStr))
                {
                    result += (currNumberStr.Contains("teen") ? (unitArr[tempCurrNumberStr] + 10) : (unitArr[tempCurrNumberStr] * 10)) * multiplier;
                }

                else if (unitArr.ContainsKey(currNumberStr))
                {
                    result += unitArr[currNumberStr] * multiplier;

                }
                else if (multiplierArr.ContainsKey(currNumberStr))
                {
                    if (multiplier > multiplierArr[currNumberStr])
                    {
                        return result + GetNumber(str, endIndex) * multiplier;
                    }
                    else
                    {
                        multiplier = multiplierArr[currNumberStr];
                    }
                }

                endIndex--;
            }

            if (result == 0)
            {
                result = multiplier;
            }

            return result;
        }
    }
    
}
