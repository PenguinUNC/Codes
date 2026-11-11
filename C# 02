Code 1:
using System;
//class One
//{
//    static void Main()
//    {
//        Console.Write("X: ");
//        int x = int.Parse(Console.ReadLine());
//        int result = Square(x);
//        Console.Write(result);
//    }
//    static int Square(int x)
//    {
//        return x * x;
//    }
//}
//class Two
//{
//    static void Main()
//    {
//        Console.Write("A: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write($"A is {IsEven(a)}");
//    }
//    static bool IsEven(int a)
//    {
//        return a % 2 == 0;
//    }
//}
class Three
{
    static void Main()
    {
        Console.Write("R: ");
        double r = double.Parse(Console.ReadLine());
        Console.Write($"Result: {Fourm(r)}");
    }
    static double Fourm(double r)
    {
        return 3.14 * r * r;
    }
}
Code 2:
using System;
class Program
{
    // Задача 1: Квадрат числа
    static int Square(int x)
    {
        return x * x;
    }
    // Задача 2: Проверка чётности
    static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
    // Задача 3: Площадь круга
    static double CalculateCircleArea(double r)
    {
        return Math.PI * r * r;
    }
    static void Main()
    {
        // Задача 1
        Console.Write("Введите число для возведения в квадрат: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Квадрат числа {num} = {Square(num)}");
        Console.WriteLine(); //
        // Задача 2
        Console.Write("Введите число для проверки чётности: ");
        int number = int.Parse(Console.ReadLine());
        if (IsEven(number))
            Console.WriteLine("Чётное");
        else
            Console.WriteLine("Нечётное");
        Console.WriteLine();
        // Задача 3
        Console.Write("Введите радиус круга: ");
        double radius = double.Parse(Console.ReadLine());
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"Площадь круга = {area:F2}");
    }
}
