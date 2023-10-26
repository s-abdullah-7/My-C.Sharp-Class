namespace Arrays
{
    class Program
    {
        static int[,] Add2dArray(int[,] matrix, int[,] matrix1)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);


            int[,] matrix3 = new int[row, col];



            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = matrix[i, j] + matrix1[i, j];
                }
            }

            return matrix3;
        }

        static int[,] Substract2dArray(int[,] matrix, int[,] matrix1)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int[,] matrix3 = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = matrix[i, j] - matrix1[i, j];
                }
            }

            return matrix3;
        }

        static int[,] Multiply2dArray(int[,] matrix, int[,] matrix1)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int[,] matrix3 = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = matrix[i, j] * matrix1[i, j];
                }
            }

            return matrix3;
        }

        static void printArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrix2 = { { 5, 5, 5 }, { 5, 5, 5 } };

            

            int[,] addMatrix = Add2dArray(matrix, matrix2);
            int[,] subMatrix = Substract2dArray(matrix, matrix2);
            int[,] mulMatrix = Multiply2dArray(matrix, matrix2);


            printArray(addMatrix);

            printArray(subMatrix);

            printArray(mulMatrix);


        }
    }
}