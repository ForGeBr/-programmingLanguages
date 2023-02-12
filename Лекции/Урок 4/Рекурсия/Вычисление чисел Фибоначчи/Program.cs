﻿// У нас есть функция, которая будет что-то возвращать (начнём пока с целых чисел). Определяем её 
//наименование — Fibonacci. В качестве аргумента указываем n. Если значение n=1 или n=2, возвращаем 
//1. Иначе мы хотим вернуть Fibonacci(n-1) + Fibonacci(n-2).

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

//int Fibonacci(int n) 
//Получаются те самые числа Фибоначчи — каждое равно сумме двух предыдущих. 
//Есть тонкий момент. По аналогии с факториалом попробуем посчитать первые 50 чисел Фибоначчи так, 
//чтобы возвращалось double-значение.  

double Fibonacci(int n)

{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

//for (int i = 1; i < 10; i++) // Конструкция хорошо работает до 15-17 числа(i < 50 - до 50 числа), дальше вычисления начинают тормозить
for (int i = 1; i < 50; i++)
{
    //Console.WriteLine(Fibonacci(i)); // ниже используем конструкцию из лекции для большего количества чисел
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); // пронумеруем числа по порядку чтобы видеть с которого пойдёт затуп
}
