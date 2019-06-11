using Common;
using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class HasCycleTests
    {
        [Fact]
        public void HasCycle_FromLeetCode1()
        {
            var root = new ListNode(3);
            var cyclicNode = new ListNode(2);
            root.next = cyclicNode;
            cyclicNode.next = new ListNode(0);
            cyclicNode.next.next = new ListNode(4);
            cyclicNode.next.next.next = cyclicNode;

            var result = HasCycleImplementation.HasCycle(root);

            result.Should().BeTrue();
        }

        [Fact]
        public void HasCycle_FromLeetCode2()
        {
            var root = new ListNode(1);
            root.next = new ListNode(2);
            root.next.next = root;

            var result = HasCycleImplementation.HasCycle(root);

            result.Should().BeTrue();
        }

        [Fact]
        public void HasCycle_FromLeetCode3()
        {
            var root = new ListNode(1);
            root.next = new ListNode(2);

            var result = HasCycleImplementation.HasCycle(root);

            result.Should().BeFalse();
        }
    }
}
