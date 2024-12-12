using System;
class SixthTask
{
    static void Main()
    {

        Console.WriteLine("Введите действительную часть первого комплексного числа:");
        double real1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите мнимую часть первого комплексного числа:");
        double imag1 = Convert.ToDouble(Console.ReadLine());
        ComplexNumber num1 = new ComplexNumber(real1, imag1);
        Console.WriteLine("Введите действительную часть второго комплексного числа:");
        double real2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите мнимую часть второго комплексного числа:");
        double imag2 = Convert.ToDouble(Console.ReadLine());
        ComplexNumber num2 = new ComplexNumber(real2, imag2);
        Console.WriteLine($"Первое комлексное число: {num1}");
        Console.WriteLine($"Второе комлексное число: {num2}");
        Console.WriteLine($"Сложение: {num1 + num2}");
        Console.WriteLine($"Вычитание: {num1 - num2}");
        Console.WriteLine($"Умножение: {num1 * num2}");
        Console.WriteLine($"Деление: {num1 / num2}");
        Console.WriteLine($"Первое комплексное число в квадрате: {num1.Pow(2)}");
        Console.WriteLine($"Квадратный корень из первого комплексного числа: {num1.Sqrt()}");
        Console.WriteLine($"Модуль первого комплексного числа: {num1.Modulus()}");
        Console.WriteLine($"Угол первого комплексного числа (в радианах): {num1.Argument()}");
    }
}
public class ComplexNumber
{
    public double Re { get; }
    public double Im { get; }

    public ComplexNumber(double real, double imaginary)
    {
        Re = real;
        Im = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Re + b.Re, a.Im + b.Im);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Re - b.Re, a.Im - b.Im);
    }

    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(
            a.Re * b.Re - a.Im * b.Im,
            a.Re * b.Im + a.Im * b.Re
        );
    }

    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        double denominator = b.Re * b.Re + b.Im * b.Im;
        if (denominator == 0)
        {
            throw new DivideByZeroException("!!!!!деление на 0");
        }
        return new ComplexNumber(
            (a.Re * b.Re + a.Im * b.Im) / denominator,
            (a.Im * b.Re - a.Re * b.Im) / denominator
        );
    }

    public ComplexNumber Pow(int exponent)
    {
        if (exponent < 0)
            throw new ArgumentOutOfRangeException("!!!!степень не может быть отрицательной.");

        if (exponent == 0) return new ComplexNumber(1, 0);

        double magnitude = Math.Pow(Modulus(), exponent);
        double angle = Argument() * exponent;
        return new ComplexNumber(
            magnitude * Math.Cos(angle),
            magnitude * Math.Sin(angle)
        );
    }

    public ComplexNumber Sqrt()
    {
        double modulus = Modulus();
        double angle = Argument() / 2;
        return new ComplexNumber(
            Math.Sqrt(modulus) * Math.Cos(angle),
            Math.Sqrt(modulus) * Math.Sin(angle)
        );
    }

    public double Modulus()
    {
        return Math.Sqrt(Re * Re + Im * Im);
    }

    public double Argument()
    {
        return Math.Atan2(Im, Re);
    }
    public override string ToString()
    {
        string sign = Im >= 0 ? "+" : "-";
        return $"{Re} {sign} {Math.Abs(Im)}i";
    }
}