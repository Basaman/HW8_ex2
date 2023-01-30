
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Clear();

int[,] array = GetArray(rows, columns, 0, 10);
int[] ColumnsSumValueArray = GetColumnsSumValueArray(array);

PrintArray(array);
Console.WriteLine();
/*Console.WriteLine($"{String.Join("; ", ColumnsSumValueArray)}"); // сумма элементов строки */

minRowAmount(ColumnsSumValueArray);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] matrix)
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

int[] GetColumnsSumValueArray(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] = result[i] + matrix[i, j];
        }
    }
    return result;
}

void minRowAmount(int[] array)
{
    int min = array[0];
    int minRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
         min = array[i];
         minRow = array[i];
         minRow = i;
        }       
    }
    Console.WriteLine($"Строка {minRow+1} с наименьшей суммой элементов равной {min}.");
}
