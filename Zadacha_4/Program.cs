/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введи первое число: "); //Приглашение на ввод первого числа.
int numberA = int.Parse(Console.ReadLine()); //Считываем первое число.

Console.Write("Введи второе число: "); //Приглашение на ввод второго числа.
int numberB = int.Parse(Console.ReadLine()); //Считываем второе число.

Console.Write("Введи третье число: "); //Приглашение на ввод третьего числа.
int numberC = int.Parse(Console.ReadLine()); //Считываем третье число.

int max = numberA; // Объявляю максимальным числом numberA.

if (max < numberB) // Если numberA меньше numberB, то объявляю максимальным numberB.
{
    max = numberB;
}
if (max < numberC) // Если numberB меньше numberC, то объявляю максимальным numberC.
{
    max = numberC;
}

Console.WriteLine($"Максимальное число равно: "); //Вывожу на экран максимальное число

Console.Write(max); //Считывает максимальное число.
