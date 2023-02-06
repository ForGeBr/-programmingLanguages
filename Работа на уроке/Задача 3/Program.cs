//  Напишите программу, которая будет выдавать название дня недели по заданному номеру 3 - среда, 5 - пятница

Console.Clear();

Console.Write("Если захотите выйти введите 100 ");
int num;
while (true)
{
    Console.Write(" Введите номер дня недели: ");
    num = int.Parse(Console.ReadLine()!);
    switch (num)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Такого дня не существует");
            break;
    }
    if (num == 100) break;
}