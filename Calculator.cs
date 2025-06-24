using System;

public class Calculator
{
    // Неизменяемое поле числа Пи
    public const double PI = 3.14159265358979323846;

    // Сумма двух чисел
    public double Sum(double a, double b) => a + b;

    // Произведение двух чисел
    public double Multiply(double a, double b) => a * b;

    // Разность двух чисел
    public double Subtract(double a, double b) => a - b;

    // Частное двух чисел
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new ArgumentException("Деление на ноль!");
        return a / b;
    }

    // Минимум из двух чисел
    public double Min(double a, double b) => (a < b) ? a : b;

    // Минимум из трех чисел
    public double Min(double a, double b, double c) => Min(Min(a, b), c);

    // Максимум из двух чисел
    public double Max(double a, double b) => (a > b) ? a : b;

    // Максимум из трех чисел
    public double Max(double a, double b, double c) => Max(Max(a, b), c);

    // Возведение в степень (целая степень, не используя Math.Pow)
    public double Pow(double a, int b)
    {
        if (b == 0) return 1;
        double res = 1;
        int n = Math.Abs(b);
        for (int i = 0; i < n; i++)
            res *= a;
        return b > 0 ? res : 1.0 / res;
    }

    // Наибольший общий делитель (алгоритм Евклида)
    public int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    // Наименьшее общее кратное
    public int LCM(int a, int b)
    {
        if (a == 0 || b == 0) return 0;
        return Math.Abs(a * b) / GCD(a, b);
    }

    // Квадратный корень (метод Ньютона)
    public double Sqrt(double x)
    {
        if (x < 0)
            throw new ArgumentException("Отрицательное число!");
        if (x == 0) return 0;
        double guess = x / 2.0;
        for (int i = 0; i < 20; i++)
            guess = 0.5 * (guess + x / guess);
        return guess;
    }

    // Синус (ряд Тейлора, x в радианах)
    public double Sin(double x)
    {
        // Приводим x к диапазону [-PI, PI] для ускорения сходимости
        while (x > PI) x -= 2 * PI;
        while (x < -PI) x += 2 * PI;
        double term = x;
        double sum = x;
        for (int n = 1; n <= 10; n++)
        {
            term *= -x * x / ((2 * n) * (2 * n + 1));
            sum += term;
        }
        return sum;
    }

    // Рандомное двузначное число [10,99]
    private static int _seed = (int)DateTime.Now.Ticks & 0xFFFF;
    public int RandomTwoDigit()
    {
        // Линейный конгруэнтный генератор
        _seed = (_seed * 1103515245 + 12345) & int.MaxValue;
        int num = 10 + (_seed % 90);
        return num;
    }
}