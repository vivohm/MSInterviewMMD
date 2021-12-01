using InterviewQuestion;
using Xunit;

namespace InterviewQuestionsTest
{
    public class Word2NumberTest
    {
        [Theory]
        [InlineData("forty thousand two hundred million", 40200000000)]
        [InlineData("one thousand six hundred and forty two", 1642)]
        public void Word2Number_Test(string word, long expectedOutput)
        {
            var word2Number = new Word2Number();
            var result  = word2Number.TranslateWord2Number(word);
            Assert.Equal(result, expectedOutput);
        }
        
    }
}
