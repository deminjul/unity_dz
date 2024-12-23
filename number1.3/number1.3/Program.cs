﻿using System;

class SecondTask
{
    static void Main(string[] args)
    {

        Console.WriteLine("Коэффициент a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Коэффициент b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Коэффициент c:");
        double c = Convert.ToDouble(Console.ReadLine());


        SolveEquation(a, b, c);
    }

    static void SolveEquation(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконеееееееечно много решений (0 = 0).");
                }
                else
                {
                    Console.WriteLine("Нет действительных корней(((");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Уравнение имеет лишь один корень: x = {x}");
            }
        }
        else
        {
            if ((Math.Pow(b, 2) - 4 * c * a) < 0)
            {
                Console.WriteLine("Нет решений((((");
            }
            else
            {
                double discriminant = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два!!! различных корня: x1 = {x1}, x2 = {x2}");
            }
        }

    }
}