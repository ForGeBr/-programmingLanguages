Console.Clear();



//for (int i = 0; i < 3; i++)
//for (int i = 0; i <matrix.GetLength(0); i++)
void PrintArray(int[,] matr)
{
    //for (int j = 0; j < 4; j++)
    //for (int j = 0; j < matrix.GetLength(1); j++)
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);// круглыми скобками обозначен полуинтервал от 1 до 10 [1;10)
        }
        
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);