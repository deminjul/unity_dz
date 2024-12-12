using System;

class FirstTask
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int maxNumber;
        while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber < 2)
        {
            Console.WriteLine("!!!введите число больше 1");
        }

        Console.WriteLine($"Простые числа до {maxNumber}:");

        for (int number = 2; number <= maxNumber; number++)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}