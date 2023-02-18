/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine());

if (a>9999 && a<100000)
{
    int b = a/10000;
    int c = a%10000/1000;
    int d = a%1000/100;
    int e = a%100/10;
    int f = a%10;
    if (b==f && c==e)
        Console.WriteLine($"{a} -> да");
    else
        Console.WriteLine($"{a} -> нет");
}
else {Console.WriteLine($"{a} не является пятизначным числом.");}