using System;
using System.Collections.Generic;
class Notebook
{
    public int NumberBook;
    public string ColorBook;
    public char Grade;
}
class Program
{
    static void Main()
    {
        Random rand = new Random();
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple", "Cyan", "Lime", "Orange" };
        List<string> Entity = new List<string>();
        Notebook[] shelf = new Notebook[3];
        Entity.Add("Baldi");
        Entity.Add("Student");
        int a = 0;
        int b = 0;
        string[] op = { "+", "-", "*", "/" };
        Console.Write("Choise difficulty (Easy, Medium, Hard): ");
        string choise = Console.ReadLine();
        Console.WriteLine($"{Entity[0]}: Hello, {Entity[1]}, let's solve examples! ");
        for (int j = 0; j < shelf.Length; j++)
        {
            shelf[j] = new Notebook();
            shelf[j].NumberBook = j + 1;
            shelf[j].ColorBook = colors[rand.Next(colors.Length)];
            Console.WriteLine($"{shelf[j].ColorBook} Notebook #{shelf[j].NumberBook}");
            int CorrectCount = 0;
            for (int i = 1; i <= 3; i++)
            {
                switch (choise)
                {
                    case "Easy":
                        a = rand.Next(-9, 10);
                        b = rand.Next(-9, 10);
                        break;
                    case "Medium":
                        a = rand.Next(-99, 100);
                        b = rand.Next(-99, 100);
                        break;
                    case "Hard":
                        a = rand.Next(-999, 1000);
                        b = rand.Next(-999, 1000); ;
                        break;
                    default:
                        Console.Write("E");
                        break;
                }
                string oper = op[rand.Next(op.Length)];
                double oresult = 0;
                if (oper == "+") { oresult = a + b; }
                else if (oper == "-") { oresult = a - b; }
                else if (oper == "*") { oresult = a * b; }
                else if (oper == "/") { oresult = (double)a / b; }
                Console.Write($"Example №{i}: {a} {oper} {b} = ");
                double yresult = double.Parse(Console.ReadLine());
                if (yresult == oresult)
                {
                    Console.WriteLine($"{Entity[0]}: Correct!");
                    CorrectCount++;
                }
                else
                {
                    Console.WriteLine($"{Entity[0]}:Incorrect! The correct answer is {oresult} \a");
                }
            }
            switch (CorrectCount)
            {
                case 3:
                    shelf[j].Grade = 'A';
                    break;
                case 2:
                    shelf[j].Grade = 'B';
                    break;
                case 1:
                    shelf[j].Grade = 'C';
                    break;
                default:
                    shelf[j].Grade = 'D';
                    break;
            }
            Console.WriteLine($"Result for this notebook: {shelf[j].Grade}");
        }
        Console.WriteLine("Final notebook shelf");
        foreach (var book in shelf)
        {
            Console.WriteLine($"Book #{book.NumberBook} | Color: {book.ColorBook} | Grade: {book.Grade}");
        }
    }
}
