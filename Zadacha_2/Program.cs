﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введи первое число: "); //Приглашение на ввод первого числа.
int numberA = int.Parse(Console.ReadLine()); //Считываем первое число.

Console.WriteLine("Введи второе число: ");  //Приглашение на ввод второго числа.
int numberB = int.Parse(Console.ReadLine());    //Считываем второе число.

if (numberA > numberB)  // Если первое число больше второго, вывести следующую надпись:
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    if (numberA < numberB)  // Если же первое число меньше второго, вывести следующую надпись:
    {
        Console.WriteLine("Второе число больше первого");
    }
    else  //Иначе, вывести надпись:
    {
        Console.WriteLine("Все числа равны");
    }


}