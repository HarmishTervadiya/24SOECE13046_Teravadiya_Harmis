using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P10
    {
        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            int row = 0, col = M - 1;

            while (row < N && col >= 0)
            {
                int current = mat[row, col];

                if (current == X)
                    return 1;
                else if (current > X)
                    col--;
                else
                    row++;
            }

            return 0;
        }

        // Example usage
        public static void Main()
        {
            int[,] mat1 = {
            {3, 30, 38},
            {44, 52, 54},
            {57, 60, 69}
        };
            int result1 = matSearch(mat1, 3, 3, 62);  // Output: 0
            Console.WriteLine(result1);

            int[,] mat2 = {
            {18, 21, 27, 38, 55, 67}
        };
            int result2 = matSearch(mat2, 1, 6, 55);  // Output: 1
            Console.WriteLine(result2);
        }
    }
}
