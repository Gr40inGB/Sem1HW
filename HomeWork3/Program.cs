﻿// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.Write("Введите число: "); int x = int.Parse(Console.ReadLine());

if (x % 2 == 0) Console.Write($"Введённое число {x} - чётное");
else Console.Write($"Введённое число {x} - нечётное");
