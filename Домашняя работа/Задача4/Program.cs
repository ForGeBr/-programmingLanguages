// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число");
int Num3 = int.Parse(Console.ReadLine()!);

int Max = Num1;
if (Max < Num2)
{
    Max = Num2;
}
if (Max < Num3)
{
    Max = Num3;
}
Console.WriteLine($"Самое большое число = {Max} ");