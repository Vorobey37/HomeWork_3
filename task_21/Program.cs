/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.WriteLine("Введите координаты точки A:");
double Xa = double.Parse(Console.ReadLine());
double Ya = double.Parse(Console.ReadLine());
double Za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
double Xb = double.Parse(Console.ReadLine());
double Yb = double.Parse(Console.ReadLine());
double Zb = double.Parse(Console.ReadLine());
double L = Math.Sqrt(Math.Pow(Xa-Xb,2) + Math.Pow(Ya-Yb,2) + Math.Pow(Za-Zb,2));
Console.WriteLine($"A ({Xa}, {Ya}, {Za}); B ({Xb}, {Yb}, {Zb}) -> {L}");
