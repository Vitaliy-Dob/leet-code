using Common;
using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class GetIntersectionNodeTests
    {
        [Fact]
        public void Should_Return_Intersaction()
        {
            var intersaction = new ListNode(3);
            intersaction.next = new ListNode(4);

            var root1 = new ListNode(1);
            root1.next = new ListNode(2);
            root1.next.next = intersaction;

            var root2 = new ListNode(5);
            root2.next = new ListNode(6);
            root2.next.next = new ListNode(7);
            root2.next.next.next = intersaction;

            var result = GetIntersectionNodeImplementation.GetIntersectionNode(root1, root2);

            result.Should().Be(intersaction);
        }

        [Fact]
        public void Should_Return_Null()
        {
            var root1 = new ListNode(1);
            root1.next = new ListNode(2);
            var root2 = new ListNode(5);
            root2.next = new ListNode(6);

            var result = GetIntersectionNodeImplementation.GetIntersectionNode(root1, root2);

            result.Should().BeNull();
        }
    }
}
