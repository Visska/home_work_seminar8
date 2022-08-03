/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[, ] CreateMatr()
{
    int[, ] matrix = new int[4, 4];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}

void printMatr(int[, ] array)
{
    Console.Write(" \t");
    for (var i = 0; i < array.GetLength(1); i++)
    {
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
            if (j < array.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication (int[, ] array1, int[, ] array2, int[, ] arrayResult)
{
    for (int i = 0; i < arrayResult.GetLength(0); i++)
  {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            arrayResult[i,j] = array1[i,j] * array2[i,j];
        }
  }
}

Console.Clear();
int[, ] first2DArray = CreateMatr();
Console.WriteLine($"\nПервая матрица: ");
printMatr(first2DArray);

int[, ] second2DArray = CreateMatr();
Console.WriteLine($"\nВторая матрица: ");
printMatr(second2DArray);

int[, ] multi2DArray = CreateMatr();

MatrixMultiplication(first2DArray, second2DArray, multi2DArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
printMatr(multi2DArray);