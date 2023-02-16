/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.Clear();

Console.Write("Cколько чисел хотите ввести?: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Чесел больше ноля: {count}");


// Эталонное решение от преподавателя:
/*
int Prompt(string message)
{
    Sistem.Console.Write(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result; //возвращаем результат
}
//Ввести массив
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} -й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        return count;
    }
}

int length = Prompt("Ввудите количество элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}"); 
*/