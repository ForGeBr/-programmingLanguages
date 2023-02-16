//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты x, y, z для точки А (Через Enter):");
int x = int.Parse(Console.ReadLine()!), y = int.Parse(Console.ReadLine()!), z = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты x1, y1, z1 для точки В (Через Enter):");
int x1 = int.Parse(Console.ReadLine()!), y1 = int.Parse(Console.ReadLine()!), z1 = int.Parse(Console.ReadLine()!);

double res = Math.Round(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2)), 2);

Console.WriteLine($"Расстояние между тремя точками: {res}");