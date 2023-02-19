/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
/*если N равно 0 или N отрицательное, то выдаёт таблицу кубов от N до 1*/
if (N==0)
    {Console.Write("0 -> 0, 1");
    return;}
int M = N;
int i = 1;
int A = N; // для вывода текста как в условии задачи
if (N<0)
{
    M = -N;
    i = N;
    N = -1;
}
int [] mass = new int [M];
int j = 0;
for (; i<=N; i++)
{
    mass[j] = i*i*i;
    j++;
}
Console.Write ($"{A} ->");
for (j=0; j<M-1; j++) // M-1 для того, чтобы в итоге последнее значение было без запятой
{
    Console.Write($" {mass[j]}, ");
}
Console.Write($"{mass[M-1]}");
if (A<0)
{
    Console.Write(", 0, 1");
}
