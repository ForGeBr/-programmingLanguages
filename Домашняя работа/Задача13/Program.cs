// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите любое число: ");
int Num = int.Parse(Console.ReadLine()!);

int n = 1;
int Num1 = 0;

if (Num < 0)
{
    Num = Num * -1;
}
if (Num / 100 > 0)
{
    while (Num / n > 999)
    {
        n = n * 10;
    }
    Num1 = (Num / n) % 10;
    Console.WriteLine(Num1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}