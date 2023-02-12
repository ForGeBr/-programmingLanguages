
Console.Clear();

// В таком виде будут возвращаться целые числа, что к 17 числу приведёт к переполнению терминала
// int Factorial(int n) 

// избежать поможет нижеприведённый тип чисел(с точкой), но виду будет как 1.99082Е+32
// Е+32 - означает 10 в 32й степени умноженное на предыдущее число

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6
