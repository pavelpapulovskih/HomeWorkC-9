// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int LeviAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return LeviAckermann(m - 1, 1);
    }
    else
    {
        return LeviAckermann(m - 1, LeviAckermann(m, n - 1));
    }
}


Console.WriteLine("Введите натуральное не отрицательное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное не отрицательное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана принимает значения {m} и {n} и даёт результат {LeviAckermann(m, n)}");