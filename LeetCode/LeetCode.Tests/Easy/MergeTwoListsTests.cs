using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class MergeTwoListsTests
    {
        [Fact]
        public void MergeTwoLists_FromLeetCode_ShouldReturnMerged()
        {
            var firstLinkedList = ListNode.CreateList(new int[] { 1, 2, 4 });
            var secondLinkedList = ListNode.CreateList(new int[] { 1, 3, 4 });
            var expectedLinkedList = ListNode.CreateList(new int[] { 1, 1, 2, 3, 4, 4 });

            var result = MergeTwoListsImplementation.MergeTwoLists(firstLinkedList, secondLinkedList);

            Assert.True(result.Equals(expectedLinkedList) && expectedLinkedList.Equals(result));
        }

        [Fact]
        public void MergeTwoLists_DifferentLength_ShouldReturnMerged()
        {
            var firstLinkedList = ListNode.CreateList(new int[] { 2, 8, 11, 15 });
            var secondLinkedList = ListNode.CreateList(new int[] { 1, 3, 4, 12, 14, 17 });
            var expectedLinkedList = ListNode.CreateList(new int[] { 1, 2, 3, 4, 8, 11, 12, 14, 15, 17 });

            var result = MergeTwoListsImplementation.MergeTwoLists(firstLinkedList, secondLinkedList);

            Assert.True(result.Equals(expectedLinkedList) && expectedLinkedList.Equals(result));
        }

        [Fact]
        public void MergeTwoLists_EmptyTree_ShouldReturnMerged()
        {
            var firstLinkedList = ListNode.CreateList(new int[] { 1, 2, 4 });
            var secondLinkedList = ListNode.CreateList(null);
            var expectedLinkedList = ListNode.CreateList(new int[] { 1, 2, 4 });

            var result = MergeTwoListsImplementation.MergeTwoLists(firstLinkedList, secondLinkedList);

            Assert.True(result.Equals(expectedLinkedList) && expectedLinkedList.Equals(result));
        }
    }
}
