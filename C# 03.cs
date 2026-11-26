using System;
using System.Reflection.Metadata.Ecma335;
class Calculator
{
    static void Main()
    {
        Console.Write("A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write($"Sum: {Sum(a, b)}");
                break;
            case "2":
                Console.Write($"Diff: {Diff(a, b)}");
                break;      
            case "3":
                Console.Write($"Mult: {Mult(a, b)}");
                break;
            case "4":
                Console.Write($"Dub: {Sub(a, b)}");
                break;
            case "5":
                Console.Write($"Degree: {Degree(a)}");
                break;
            default:
                Console.Write("E");
                break;
        }
    }
    static double Sum(double a, double b)
    {
        return a + b;
    }
    static double Diff(double a, double b)
    {
        return a - b;
    }
    static double Mult(double a, double b)
    {
        return a * b;
    }
    static double Sub(double a, double b)
    {
        if (b == 0)
        {
            Console.Write("E");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
    static double Degree(double a)
    {
        return a * a;
    }
}
