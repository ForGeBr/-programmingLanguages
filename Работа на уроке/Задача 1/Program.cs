//Проверка квадрата числа

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine($"Является число {b} квадратом числа {a}");
}
else
{
    Console.WriteLine($"Не является число {b} квадратом числа {a}");
}
