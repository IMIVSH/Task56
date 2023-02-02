// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

void PrintInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] GetArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t", ConsoleColor.Green);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t", ConsoleColor.Green);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindSmallestRowNum(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            {
                sum = sum + array[j, i];
            }
        }
        sumArray[j] = sum;
        }
        
        int rowSum = sumArray[0];
        int rowNum = 0;
        for (int m = 1; m < sumArray.Length; m++)
        {
            if(sumArray[m] < rowSum)
            {
                rowSum = sumArray[m];
                rowNum = m;
            }
        }
        PrintInColor($"Наименьшая сумма элементов в ", ConsoleColor.Green);
        PrintInColor($"{rowNum}", ConsoleColor.Red);
        PrintInColor(" строке. ", ConsoleColor.Green);
}

int[,] array = GetArray(4, 4, 1, 9);
PrintArray(array);
FindSmallestRowNum(array);