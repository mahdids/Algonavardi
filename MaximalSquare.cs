public class Solution {
    public int MaximalSquare(char[][] matrix) {
       if (matrix.Length == 0 || matrix[0].Length == 0)
            return 0;
        var max = 0;
        var x = matrix.Length;
        var y = matrix[0].Length;
        var result = new int[x + 1, y + 1];

        for (int i = 1; i < x + 1; i++)
        {
            for (int j = 1; j < y + 1; j++)
            {
                if (matrix[i - 1][j - 1] != '0')
                {
                    var min = Math.Min(Math.Min(result[i - 1, j], result[i, j - 1]), result[i - 1, j - 1]);
                    result[i, j] = min + 1;
                    if (result[i, j] > max)
                        max = result[i, j];
                }
            }
        }
        return max * max;
    }
}
