using System;

namespace LeetCode.Medium
{
    public static class FindKthLargestImplementation
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            return QuickSort(nums, 0, nums.Length - 1, nums.Length - k);
        }

        private static int QuickSort(int[] nums, int start, int pivot, int kth)
        {
            var j = start - 1;
            for (var i = start; i < pivot; i++)
            {
                if (nums[i] < nums[pivot])
                {
                    j++;
                    Swap(nums, i, j);
                }
            }

            j++;
            Swap(nums, j, pivot);
            if (j == kth)
                return nums[j];
            if (kth < j)
                return QuickSort(nums, start, j - 1, kth);

            return QuickSort(nums, j + 1, pivot, kth);
        }

        private static void Swap(int[] nums, int first, int second)
        {
            var temp = nums[first];
            nums[first] = nums[second];
            nums[second] = temp;
        }
    }
}