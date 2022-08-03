/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

Console.Clear();
int[, ] number2DArray = CreateMatr();
printMatr(number2DArray);

int rowMinSum = 0;
int sumRow = SumRowElements(number2DArray, 0);
for (int i = 1; i < number2DArray.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(number2DArray, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    rowMinSum = i;
  }
}

Console.WriteLine($"\n{rowMinSum +1 } - строкa с наименьшей суммой ({sumRow}) элементов ");


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


int SumRowElements(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

