﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i = 1; 

Console.WriteLine("Промежуток чётных чисел: ");

while (i <= N)

{
    if (i % 2 == 0)

    {
        Console.Write($"{i} ");
    }
    i++; //Или же i = i + 1
}