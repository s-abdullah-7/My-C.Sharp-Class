using System.Transactions;

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

        static void storeArray()
        {

            Console.WriteLine("Enter the Row of the Matrix :");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Column of the Matrix :");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matrices = new int[r, c];

            for (int i = 0;i < matrices.GetLength(0); i++)
            {
                for(int j = 0;j < matrices.GetLength(1); j++)
                {
                    Console.Write($"Enter the row of {i} and column of {j} : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    matrices[i, j] = n;

                }
            }
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


            Console.WriteLine("Enter the Row of the Matrix :");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Column of the Matrix :");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matrices1 = new int[r, c];
            int[,] matrices2 = new int[r, c];

            //int[,] matrix3 = { { 1, 3, 4 } ,{ 3, 5 ,6 } };

            //matrix3[1,0] = 10;

            //printArray(matrix3);

            //for (int i = 0; i < matrices1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrices1.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter the row of {i} and column of {j} : ");
            //        int n = Convert.ToInt32(Console.ReadLine());
            //        matrices1[i, j] = n;


            //    }
            //}
            //for (int i = 0; i < matrices2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrices2.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter the row of {i} and column of {j} : ");
            //        int n = Convert.ToInt32(Console.ReadLine());
            //        matrices2[i, j] = n;


            //    }
            //}



            Console.WriteLine("The First Matrix : ");
            storeArray();
            printArray(matrices1);

            Console.WriteLine("The Second Matrix : ");
            printArray(matrices2);







            int[,] addMatrix = Add2dArray(matrices1, matrices2);

            Console.WriteLine("Adding Two Matrices :");
            printArray(addMatrix);

        }
    }
}