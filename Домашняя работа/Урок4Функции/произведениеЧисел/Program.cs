// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine()!);
int count = 1;
int i = 1;

while (i <= Num)
{
    count = count * i;
    Console.WriteLine($"{i} ");
    i++;
}
Console.WriteLine($"= {count}");
