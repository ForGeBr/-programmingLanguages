/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк первой матрицы: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int col = int.Parse(Console.ReadLine()!);
int[,] firstarray = GetArray(str, col, -50, 50);
int[,] secondArray = GetArray(str, col, -50, 50);
int[,] resultArray = GetArray(str, col, -50, 50);

PrintArray(firstarray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();

/*  ниже использован блок проверки, назначение не очень понятно, 
программа работает и без него, проверяется наличие нулевх значений.
скопипастил у коллеги для "подумать" */

if (firstarray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < firstarray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstarray.GetLength(1); k++)
        {
            resultArray[i, j] += firstarray[i, k] * secondArray[k, j];
        }
    }
} 

Console.WriteLine("Результирующая матрица");
PrintArray(resultArray);