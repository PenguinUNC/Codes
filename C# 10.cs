using System;
//class Six
//{
//    static void Main()
//    {
//        Console.Write("Your number: ");
//        int n = int.Parse(Console.ReadLine());
//        bool isPrime = true;
//        if(n < 2) { isPrime = false; }
//        for (int i = 2; i < n; i++)
//        {
//            if(n % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }
//        if (isPrime)
//        {
//            Console.Write(n + " prime");
//        }
//        else
//        {
//            Console.Write(n + " not prime");
//        }
//    }
//}
//class Seven
//{
//    static void Main()
//    {
//        Console.Write("Your number: ");
//        int n = int.Parse(Console.ReadLine());
//        int f = 1;
//        int s = 1;
//        Console.Write("Subsequence: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(f + " ");
//            int next = f + s;
//            f = s;
//            s = next;
//        }
//    }
//}
//class Eight
//{
//    static void Main()
//    {
//        Console.WriteLine("0 = exit.");
//        Console.WriteLine("Your numbers: ");
//        int n;
//        int sum = 0;
//        int count = 0;
//        do
//        {
//            n = int.Parse(Console.ReadLine());
//            if (n != 0)
//            {
//                sum += n;
//                count++;
//            }

//        } while (n != 0);
//        if (count > 0)
//        {
//            double average = (double)sum / count;
//            Console.Write("AV: " + average);
//        }
//        else
//        {
//            Console.Write("Non Numbers");
//        }
//    }
//}
//class Nine
//{
//    static void Main()
//    {
//        Console.Write("Your number: ");
//        int n = int.Parse(Console.ReadLine());
//        int temp = n;
//        int reversed = 0;
//        while(temp > 0)
//        {
//            int ld = temp % 10;
//            reversed = reversed * 10 + ld;
//            temp = temp / 10;
//        }
//        Console.Write("Reversed: " + reversed);
//    }
//}
//class Ten
//{
//    static void Main()
//    {
//        Console.Write("Your number a: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Your number b: ");
//        int b = int.Parse(Console.ReadLine());
//        while (a != 0 && b != 0)
//        {
//            if (a > b) { a %= b; }
//            else { b %= a; }
//        }
//        int NOD = a + b;
//        Console.Write("NOD: " + NOD);
//    }
//}
//class Eleven
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        int n = 1;
//        int r = rand.Next(101);
//        while(n != r)
//        {
//            Console.Write("Your number: ");
//            n = int.Parse(Console.ReadLine());
//            if (n < 0 || n > 100)
//            {
//                Console.Write("E, ");
//            }
//            else
//            {
//                if (n < r)
//                {
//                    Console.WriteLine("Greater!");
//                }
//                else if (n > r)
//                {
//                    Console.WriteLine("Less!");
//                }
//            }
//        }
//        Console.Write("Win, Equal! " + r);
//    }
//}
//class Twelve
//{
//    static void Main()
//    {
//        Console.Write("Your number: ");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            if ((i % 3 == 0 || i % 5 == 0) && i % 15 != 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}
class Thirteen
{
    static void Main()
    {
        Console.Write("Your grade: ");
        string choise = Console.ReadLine();
        switch (choise)
        {
            case "a":
                Console.Write("Great!");
                break;
            case "b":
                Console.Write("Good!");
                break;
            case "c":
                Console.Write("Decent!");
                break;
            case "d":
                Console.Write("Bad!");
                break;
            case "f":
                Console.Write("Fail!");
                break;
            default:
                Console.Write("E");
                break;
        }
    }
}
