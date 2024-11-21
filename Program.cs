using System;

class Program
{
    static int[,] FillMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(0, 101); 
            }
        }

        return matrix;
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static (int, int) FindRowWithMinSum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return (minRowIndex, minSum);
    }

    static void Main(string[] args)
    {
        int rows = 4;
        int cols = 6;
        int[,] matrix = FillMatrix(rows, cols);

        Console.WriteLine("Згенерована матриця:");
        PrintMatrix(matrix);

        var (minRowIndex, minSum) = FindRowWithMinSum(matrix);

        Console.WriteLine($"\nРядок з мінімальною сумою елементів: {minRowIndex + 1}");
        Console.WriteLine($"Мінімальна сума: {minSum}");
        Console.ReadKey();
    }
}

