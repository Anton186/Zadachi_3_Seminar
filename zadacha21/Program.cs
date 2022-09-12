// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//√ (x b - x a) 2 + (y b - y a) 2 + (z b - z a) 2

Console.WriteLine("Напишите первую точку по оси X");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите первую точку по оси Y");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите первую точку по оси Z");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую точку по оси X");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую точку по оси Y");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую точку по оси Z");
int Z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)); 
Console.WriteLine($"{res:f2}");