// НАпшите программу, которая на вход принимает число и выдаёт квадрат этого числа

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Квадрат числа{number} равен {sqr}");
Console.WriteLine($"Квадрат числа{number} равен {sqr1}");