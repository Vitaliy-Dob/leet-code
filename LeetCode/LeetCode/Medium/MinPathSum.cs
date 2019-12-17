using System;

public static class MinPathSumImplementation
{
    public static int MinPathSum(int[][] grid)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (i == 0 && j == 0)
                    continue;
                else if (i == 0)
                    grid[i][j] += grid[i][j - 1];
                else if (j == 0)
                    grid[i][j] += grid[i - 1][j];
                else
                    grid[i][j] += Math.Min(grid[i][j - 1], grid[i - 1][j]);
            }
        }
        
        return grid[grid.Length - 1][grid[0].Length - 1];
    }
}