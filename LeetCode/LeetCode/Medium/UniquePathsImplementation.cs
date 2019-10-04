namespace LeetCode.Medium
{
    public static class UniquePathsImplementation
    {
        public static int UniquePaths(int m, int n)
        {
            if (m == 0 && n == 0)
                return 0;
            var matrix = new int[m + 1, n + 1];
            matrix[0, 1] = 1;
            for (var i = 1; i < matrix.GetLength(0); i++)
            {
                for (var j = 1; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }

            return matrix[m, n];
        }
    }
}