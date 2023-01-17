// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

if (x > 0)  // двигаемся вправо от 1 до нужного числа 
{
    int count = 2;
    while (count <= x)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
else // x<=0:
{
    int count = 0; // 0 - четное число
    while (count >= x)
    {
        Console.Write($"{count} ");
        count -= 2;
    }
}

