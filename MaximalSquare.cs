  public class Solution
    {
        public static int MaximalSquare(char[][] matrix)
        {

            var max = 0;
            var x = matrix.Length;
            var y = 0;
            if (x != 0)
                y = matrix[0].Length;
            var result = new int[x + 1, y + 1];

            for (int i = 1; i < x + 1; i++)
                for (int j = 1; j < y + 1; j++)
                    if (matrix[i - 1][j - 1] == '0')
                        result[i, j] = 0;
                    else
                    {
                        result[i, j] = 1;
                        var min = Math.Min(Math.Min(result[i - 1, j], result[i, j - 1]), result[i - 1, j - 1]);
                        result[i, j] = min + 1;

                        if (result[i, j] > max)
                            max = result[i, j];
                    }
            return max * max;
        }
    }
