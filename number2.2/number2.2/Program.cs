
using System;

class ThirdTask
{
    public static int FactIt(int x)
    {
        if (x < 0) throw new ArgumentException("!!!x не должен быть отрицательным");
        int result = 1;
        for (int i = 2; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }

    public static int FactRe(int x)
    {
        if (x < 0) throw new ArgumentException("!!!x не должен быть отрицательным");
        return x <= 1 ? 1 : x * FactRe(x - 1);
    }

    public static int FibIt(int n)
    {
        if (n < 0) throw new ArgumentException("!!!n не должен быть отрицательным");
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    public static int FibRe(int n)
    {
        if (n < 0) throw new ArgumentException("!!!n не должен быть отрицательным");
        return n <= 1 ? n : FibRe(n - 1) + FibRe(n - 2);
    }

    static void Main()
    {
        try
        {
            int x = NonNegative("Целое число для вычисления факториала:");
            Console.WriteLine($"{x}! = {FactIt(x)} (итеративный)");
            Console.WriteLine($"{x}! = {FactRe(x)} (рекурсивный)");

            int n = NonNegative("Номер числа Фибоначчи:");
            Console.WriteLine($"Число Фибоначчи: {FibIt(n)} (итеративный)");
            Console.WriteLine($"Число Фибоначчи: {FibRe(n)} (рекурсивный)");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    private static int NonNegative(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
            {
                return value;
            }
            Console.WriteLine("!!!ввод некорректен, попробуйте снова.");
        }
    }
}
