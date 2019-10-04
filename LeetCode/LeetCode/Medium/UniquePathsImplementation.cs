namespace LeetCode.Medium
{
    public static class UniquePathsImplementation
    {
        public static int UniquePaths(int m, int n)
        {
            if (m == 0 && n == 0)
                return 0;
            var matrix = new int[m, n];
            Go(matrix, 0, 0);
            return matrix[m - 1, n - 1];
        }

        public static void Go(int[,] matrix, int m, int n)
        {
            if (matrix.GetLength(0) - 1 < m || matrix.GetLength(1) - 1 < n)
                return;

            matrix[m, n] = 1 + matrix[m, n];
            Go(matrix,m + 1, n);
            Go(matrix, m, n + 1);
        }
    }
}