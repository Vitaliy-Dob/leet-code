using Common;
using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class IsPalindromeTests
    {
        [Fact]
        public void IsPalindrome_ReturnsFalse()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);

            var result = IsPalindromeImplementation.IsPalindrome(head);

            result.Should().BeFalse();
        }

        [Fact]
        public void IsPalindrome_ReturnsTrue()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);

            var result = IsPalindromeImplementation.IsPalindrome(head);

            result.Should().BeTrue();
        }

        [Fact]
        public void IsPalindrome_ReturnsTrue2()
        {
            var head = new ListNode(1);           

            var result = IsPalindromeImplementation.IsPalindrome(head);

            result.Should().BeTrue();
        }

    }
}
