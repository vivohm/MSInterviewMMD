using InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InterviewQuestionsTest
{
    public class LinkListQuestionTest
    {
        [Theory]
        [InlineData("1 2 3 4 5 6", 1, "6 1 2 3 4 5")]
        [InlineData("1 2 3 4 5 6", 2, "5 6 1 2 3 4")]
        [InlineData("1 2 3 4 5 6", 3, "4 5 6 1 2 3")]
        [InlineData("1 2 3 4 5 6", 4, "3 4 5 6 1 2")]
        [InlineData("1 2 3 4 5 6", 5, "2 3 4 5 6 1")]
        [InlineData("1 2 3 4 5 6", 6, "1 2 3 4 5 6")]
        public void Positve_Within_Range_Shift_kth_From_Tail_Test(string input, int k, string expectedOutput)
        {
            var newHeadNode = RunShiftNodeTest(input, k);
            Assert.Equal(string.Join(" ", newHeadNode.ToList()), expectedOutput);
        }

        [Theory]
        [InlineData("1 2 3 4 5 6", -1, "2 3 4 5 6 1")]
        [InlineData("1 2 3 4 5 6", -2, "3 4 5 6 1 2")]
        [InlineData("1 2 3 4 5 6", -3, "4 5 6 1 2 3")]
        [InlineData("1 2 3 4 5 6", -4, "5 6 1 2 3 4")]
        [InlineData("1 2 3 4 5 6", -5, "6 1 2 3 4 5")]
        [InlineData("1 2 3 4 5 6", -6, "1 2 3 4 5 6")]
        public void Negative_Within_Range_Shift_kth_From_head_Test(string input, int k, string expectedOutput)
        {
            var newHeadNode = RunShiftNodeTest(input, k);
            Assert.Equal(string.Join(" ", newHeadNode.ToList()), expectedOutput);
        }

        [Theory]
        [InlineData("1 2 3 4 5 6", 0, "1 2 3 4 5 6")]
        public void Zero_Make_No_Shift_Test(string input, int k, string expectedOutput)
        {
            var newHeadNode = RunShiftNodeTest(input, k);
            Assert.Equal(string.Join(" ", newHeadNode.ToList()), expectedOutput);
        }

        [Theory]
        [InlineData("1 2 3 4 5 6", 7, "6 1 2 3 4 5")]
        [InlineData("1 2 3 4 5 6", 8, "5 6 1 2 3 4")]
        [InlineData("1 2 3 4 5 6", 9, "4 5 6 1 2 3")]
        [InlineData("1 2 3 4 5 6", 10, "3 4 5 6 1 2")]
        [InlineData("1 2 3 4 5 6", 11, "2 3 4 5 6 1")]
        [InlineData("1 2 3 4 5 6", 12, "1 2 3 4 5 6")]
        public void Positve_Out_Of_Range_Shift_Mod_kth_From_Tail_Test(string input, int k, string expectedOutput)
        {
            var newHeadNode = RunShiftNodeTest(input, k);
            Assert.Equal(string.Join(" ", newHeadNode), expectedOutput);
        }

        [Theory]
        [InlineData("1 2 3 4 5 6", -7, "2 3 4 5 6 1")]
        [InlineData("1 2 3 4 5 6", -8, "3 4 5 6 1 2")]
        [InlineData("1 2 3 4 5 6", -9, "4 5 6 1 2 3")]
        [InlineData("1 2 3 4 5 6", -10, "5 6 1 2 3 4")]
        [InlineData("1 2 3 4 5 6", -11, "6 1 2 3 4 5")]
        [InlineData("1 2 3 4 5 6", -12, "1 2 3 4 5 6")]
        public void Negative_Out_Of_Range_Shift_Mod_kth_From_Head_Test(string input, int k, string expectedOutput)
        {
            var newHeadNode = RunShiftNodeTest(input, k);
            Assert.Equal(string.Join(" ", newHeadNode.ToList()), expectedOutput);
        }

        [Fact]
        public void Null_List_Test()
        {
            SinglyLinkList singlyLinkList = new SinglyLinkList();
            var newHeadNode = singlyLinkList.ShiftNode(singlyLinkList.Head, 1);
            Assert.Null(newHeadNode);
        }

        private List<int> RunShiftNodeTest(string input, int k)
        {
            var arr = input.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            SinglyLinkList singlyLinkList = arr.ToSinglyLinkList();
            return singlyLinkList.ShiftNode(singlyLinkList.Head, k).ToList();
        }
    }
}
