﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
//int[] array1 = new int[N];
int i = 1;
while (i <= N)
{
    double sqr = Math.Pow(i,3); 
    Console.WriteLine(sqr);
    i++;
}

