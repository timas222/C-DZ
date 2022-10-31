// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMatrixRndIntSecond(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix2;
}

void PrintMatrixSecond(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],4}, ");
            else Console.Write($"{matrix2[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(0); ++j)
            for (int a = 0; a < matrix2.GetLength(1); ++a)
                resultMatrix[i, a] += matrix[i, j] * matrix2[j, a];
    return resultMatrix;
}
void PrintMultiplyMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (j < resultMatrix.GetLength(1) - 1) Console.Write($"{resultMatrix[i, j],4}, ");
            else Console.Write($"{resultMatrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(array2D);
Console.WriteLine();
int[,] arr2D = CreateMatrixRndIntSecond(2, 2, 1, 5);
PrintMatrixSecond(arr2D);
Console.WriteLine();
int[,] resultMatrix = MultiplyMatrix(array2D, arr2D);
PrintMultiplyMatrix(resultMatrix);