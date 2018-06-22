using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class ReverseListTests
    {
        [Fact]
        public void ReverseList_FromLeetCode_ShouldReturnReversedList()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            var expectedResult = new ListNode(3);
            expectedResult.next = new ListNode(2);
            expectedResult.next.next = new ListNode(1);

            var result = ReverseListImplementation.ReverseList(node);

            Assert.True(result.Equals(expectedResult) && expectedResult.Equals(result));
        }

        [Fact]
        public void ReverseList_EmptyList_ShouldReturnNull()
        {
            ListNode node = null;

            var result = ReverseListImplementation.ReverseList(node);

            Assert.Null(result);
        }

        [Fact]
        public void ReverseList_OneNodeList_ShouldReturnOneNodeList()
        {
            var node = new ListNode(5);

            var result = ReverseListImplementation.ReverseList(node);

            Assert.Equal(5, result.val);
            Assert.Null(result.next);
        }
    }
}
