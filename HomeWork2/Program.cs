// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

float x1 = 0; float x2 = 0; float x3 = 0;
bool error = true;

while (error)
{
    Console.Write("Введите первое число: "); x1 = float.Parse(Console.ReadLine());
    Console.Write("Введите второе число: "); x2 = float.Parse(Console.ReadLine());
    if (x1 == x2)
    {
        error = true; Console.WriteLine("Необходимо вводить разные числа"); continue;
    }
    Console.Write("Введите третье число: "); x3 = float.Parse(Console.ReadLine());
    if (x1 == x3 || x2 == x3)
    {
        error = true; continue; Console.WriteLine("Необходимо вводить разные числа"); continue;
    }
    else error = false;
}

float max = x1;          // max = x1

if (max < x2) max = x2;  // else x1 > x2  max = x1 
if (max < x3) max = x3;  // else x3 < max  max = x1 or x2

Console.Write($" Максимальное число = {max} ");