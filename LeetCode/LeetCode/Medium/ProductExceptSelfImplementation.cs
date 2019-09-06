namespace LeetCode.Medium
{
    public static class ProductExceptSelfImplementation
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;
            var prev = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result[i] = prev;
                prev = prev * nums[i];
            }

            prev = 1;

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = prev * result[i];
                prev = prev * nums[i];
            }

            return result;
        }
    }
}