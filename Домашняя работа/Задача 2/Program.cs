// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);

if (Num1 > Num2)
{
    Console.WriteLine($"Max = {Num1} > Min = {Num2}");
}
else
{
    Console.WriteLine($"Max = {Num2} > Min = {Num1}");
}