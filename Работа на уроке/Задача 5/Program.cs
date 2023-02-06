// Напишите программу, которая на входе принимает число (N), а на выходе показывает все целые числа
// в промежутке от -N  до N. Пример: 4 - -4,-3,-2,-1,0,1,2,3,4

Console.WriteLine("Введите число N ");

int N = Math.Abs(int.Parse(Console.ReadLine()!));
int K = -N;
while(K<=N)
{
Console.Write($" {K} ");
K ++;
}