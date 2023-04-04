﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int AllSum(int m, int n)
{
    if (m == n)
        {
            return m;
        }
        else if (m > n)
        {
            return 0;
        }
        else
        {
            return m + AllSum(m + 1, n);
        }
}


Console.WriteLine("Введите натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма от {m} до {n} равна {AllSum(m, n)}");