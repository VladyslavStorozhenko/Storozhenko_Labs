using NUnit.Framework;
using BasicKnowledgeHomeworks;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject2
{
    public class TestGetIntegerFromList
    {
        [TestCase(new object[] { 1, 2, "a", 3, "b", 4 }, new object[] { 1, 2, 3, 4 })]
        [TestCase(new object[] { 1, 2, "a", "b", 0, 15 }, new object[] { 1, 2, 0, 15 })]
        [TestCase(new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 }, new object[] { 1, 2, 231 })]

        public void GetIntegerFromListTest(object[] input_list, object[] output_list)
        {
            var res = BasicKnowledgeHomeworks.BasicKnowledgeHomeworks.GetIntegerFromList(input_list.ToList());
            Assert.AreEqual(res, output_list.ToList());
        }
    }
    class Testfirst_non_repeating_letter
    {

        [TestCase("hEllO Helena", 'O')]
        [TestCase("", ' ')]
        [TestCase("wwOoRrlLdD", ' ')]
        public void First_non_repeating_letter_Test(string input_str, char output_char)
        {
            var res = BasicKnowledgeHomeworks.BasicKnowledgeHomeworks.first_non_repeating_letter(input_str);
            Assert.AreEqual(res, output_char);
        }
    }
    class TestDigitSum
    {
        [TestCase(222, 6)]
        [TestCase(132189, 6)]
        [TestCase(123123123, 9)]

        public void DigitalRootTest(int input, int output)
        {
            var res = BasicKnowledgeHomeworks.BasicKnowledgeHomeworks.DigitSum(input);
            Assert.AreEqual(res, output);
        }
    }
    class TestCountPairs
    {
        [TestCase(new int[] { 1, 3, 6, 2, 2, 0, 4, 5 }, 5, 4)]
        [TestCase(new int[] { }, 2, 0)]
        [TestCase(new int[] { 1, 1, 1, 1}, 2, 6)]

        public void NumberOfPairsTest(int[] input, int target, int output)
        {
            var res = BasicKnowledgeHomeworks.BasicKnowledgeHomeworks.CountPairs(input, target);
            Assert.AreEqual(res, output);
        }
    }
    class TestSortFriends
    {
        [TestCase("", "")]
        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        
        public void MeetingTest(string input_str, string output_str)
        {
            var res = BasicKnowledgeHomeworks.BasicKnowledgeHomeworks.SortFriends(input_str);
            Assert.AreEqual(res, output_str);
        }
    }
}