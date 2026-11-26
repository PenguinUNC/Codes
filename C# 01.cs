using System;
using System.Collections.Generic;
class Int
{
    static void Main()
    {
        List<int> Num = new List<int> { 3, 7, 2, 9, 4 };
        int sum = 0;
        
        Console.Write("Числа: ");
        foreach (int i in Num)
        {
            Console.Write($"{i} ");
            sum += i;
        }
        Console.WriteLine($"\nСумма: {sum}");
    }
}


using System;
using System.Collections.Generic;
class Double
{
    static void Main()
    {
        List<double> Num = new List<double> { 2.5, 3.8, 1.2, 4.1 };
        double sum = 0;
        Console.Write("Числа: ");
        foreach (double d in Num)
        {
            Console.Write($"{d} ");
            sum += d;
        }
        double average = sum / Num.Count;
        Console.WriteLine($"\nСумма: {sum}");
        Console.WriteLine($"Среднее: {average:F2}");
    }
}


using System;
using System.Collections.Generic;
class Float
{
    static void Main()
    {
        Random rand = new Random();
        List<float> Num = new List<float>();  
        Console.Write("Случайные числа: ");
        for (int i = 0; i < 5; i++)
        {
            float value = (float)rand.NextDouble();
            Num.Add(value);
            Console.Write($"{value:F2} ");
        }
        Console.WriteLine("\nВсе числа (округлённые):");
        foreach (float i in Num)
        {
            Console.Write($"{i:F2} ");
        }
    }
}


using System;
using System.Collections.Generic;
class Char
{
    static void Main()
    {
        List<char> B = new List<char> { 'А', 'р', 'т', 'ё', 'м' };
        
        Console.Write("Буквы в имени: ");
        foreach (char c in B)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
        
        if (B.Contains('А'))
        {
            Console.WriteLine("Буква 'А' найдена!");
        }
        else
        {
            Console.WriteLine("Буква 'А' не найдена");
        }
    }
}


using System;
using System.Collections.Generic;
class String
{
    static void Main()
    {
        List<string> City = new List<string> { "Москва", "Париж", "Лондон", "Токио", "Нью-Йорк" };
        Console.Write("Города: ");
        foreach (string city in City)
        {
            Console.Write($"{city} ");
        }
        Console.WriteLine("\n\nВведите название города: ");
        string input = Console.ReadLine();
        if (City.Contains(input))
        {
            int index = City.IndexOf(input);
            Console.WriteLine($"Найден! Город '{input}' на позиции {index}");
        }
        else
        {
            Console.WriteLine("Не найден");
        }
    }
}


using System;
using System.Collections.Generic;
class Bool
{
    static void Main()
    {
        List<bool> Flag = new List<bool>();
        for (int i = 0; i < 6; i++)
        {
            Flag.Add(i % 2 == 0);
        }
        Console.Write("Значения: ");
        foreach (bool b in Flag)
        {
            Console.Write($"{b} ");
        }
        int count = 0;
        foreach (bool b in Flag)
        {
            if (b) { count++; }
        }
        Console.WriteLine($"\nКоличество true: {count}");
    }
}
