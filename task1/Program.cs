﻿// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M:  ");
int numSt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numEn = Convert.ToInt32(Console.ReadLine());

void Numbers(int numEn)
{
	if (numEn == numSt-1)
	{
		return;
	}
	Numbers(numEn - 1);
	Console.Write($"{numEn} ");     
}

Numbers(numEn);


