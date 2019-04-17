using System;


namespace Q2
{
    public class Solution
    {
        public static int MaximalSquare(char[][] matrix)
        {

            var max = 0;
            var x = matrix.Length;
            var y = 0;
            if (x != 0)
                y = matrix[0].Length;
            var result = new int[x, y];

            for (int i = 0; i < x; i++)

                if (matrix[i][0] == '1')
                {
                    max = 1;
                    result[i, 0] = 1;
                }
                else
                {
                    result[i, 0] = 0;
                }
            for (int j = 0; j < y; j++)
                if (matrix[0][j] == '1')
                {
                    max = 1;
                    result[0, j] = 1;
                }
                else
                {
                    result[0, j] = 0;
                }

            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j < y; j++)
                {
                    if (matrix[i][j] == '0')
                    {
                        result[i, j] = 0;
                    }
                    else
                    {
                        result[i, j] = 1;
                        var min = Math.Min(result[i - 1, j], result[i, j - 1]);

                        if (result[i - min, j - min] != 0)
                        {
                            result[i, j] = min + 1;


                            if (result[i, j] > max)
                            {
                                max = result[i, j];
                            }
                        }

                        else
                        {
                            result[i, j] = min;
                            if (result[i, j] > max)
                            {
                                max = result[i, j];
                            }
                        }
                    }
                }
            }
            return max*max;
        }
    }
}
