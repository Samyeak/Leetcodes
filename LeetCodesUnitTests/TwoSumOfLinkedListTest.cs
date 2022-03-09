using NUnit.Framework;
using LeetCodes.Problems;

namespace LeetCodesUnitTests
{
    [TestFixture]
    public class TwoSumOfLinkedListTest
    {
        [Test]
        public void ExecuteBruteforce()
        {
            ListNode listOne = new ListNode
            {
                val = 2,
                next = new ListNode
                {
                    val = 4,
                    next = new ListNode
                    {
                        val = 3
                    }
                }
            };

            ListNode listTwo = new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 6,
                    next = new ListNode
                    {
                        val = 4
                    }
                }
            };

            ListNode expectedOutput = new ListNode
            {
                val = 7,
                next = new ListNode
                {
                    val = 0,
                    next = new ListNode
                    {
                        val = 8
                    }
                }
            };
            var output = TwoSumOfLinkedList.ExecuteBruteforce(listOne, listTwo);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
