using System;
class FourthTask
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());

        int steps = CollatzSteps(n);
        Console.WriteLine($"Количество шагов, чтобы достичь 1: {steps}");
    }
    static int CollatzSteps(int n)
    {
        if (n == 0)
        {
            throw new ArgumentException("!!!!!!!!число должно быть больше 0");
        }
        int steps = 0;

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            steps++;
        }
        return steps;
    }
}