/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int Result(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i % 2 != 1) /* для того чтобы видеть
        сумму элементов на нечётных позициях, как считает
        человек, а не машина, востатке ставим 1, а не 0*/
        {
            count += inArray[i];
        }
    }
    return count;
}

int[] array = GetArray(4,-10, 100);
Console.WriteLine(String.Join(", ", array));
int count = Result(array);
Console.WriteLine(count);