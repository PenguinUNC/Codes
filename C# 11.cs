using System;
//class Four
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        const int size = 10;
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = rand.Next(11);
//            Console.Write(array[i] + " ");
//        }
//        Console.WriteLine();
//        foreach(int i in array)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}
//class Five
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        Console.Write("Size: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write("Element: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        for (int i = 0; i < size / 2; i++)
//        {
//            int temp = array[i];
//            array[i] = array[size - 1 - i];
//            array[size - 1 - i] = temp;
//        }
//        Console.Write("Reversed: ");
//        foreach (int i in array)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}
//class Six
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        const int size = 10;
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = rand.Next(11);
//            Console.Write(array[i] + " ");
//        }
//        Console.Write("\nBing: ");
//        int x = int.Parse(Console.ReadLine());
//        int count = 0;
//        for (int i = 0; i < size; i++)
//        {
//            if (array[i] == x)
//            {
//                count++;
//            }
//        }
//        Console.Write($"Number {x} in massiv {count} count");
//    }
//}
//class Seven
//{
//    static void Main()
//    {
//        string[] array = { "Mike", "Kevin", "Alexandre", "Winston", "Paul" };
//        string longers = array[0];
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Length > longers.Length)
//            {
//                longers = array[i];
//            }
//        }
//        Console.WriteLine($"Longest: {longers}");
//        Console.Write($"Long: {longers.Length}");
//    }
//}
//class Eitht
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        const int size = 10;
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = rand.Next(-10, 31);
//            Console.Write(array[i] + " ");
//        }
//        Console.WriteLine();
//        foreach (int i in array)
//        {
//            if (i < 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}
//class Nine
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        const int size = 10;
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = rand.Next(11);
//            Console.Write(array[i] + " ");
//        }
//        int position = 0;
//        for (int i = 0; i < size; i++)
//        {
//            if (array[i] != 0)
//            {
//                array[position] = array[i];
//                position++;
//            }
//        }
//        for (int i = position; i < size; i++)
//        {
//            array[i] = 0;
//        }
//        Console.WriteLine();
//        Console.Write("Result: " + string.Join(", ", array));
//    }
//}
class Ten
{
    static void Main()
    {
        const int size = 5;
        int[] array = new int[size];
        Console.WriteLine("Massiv: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        bool isSorted = true;
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                isSorted = false;
                break;
            }
        }
        Console.WriteLine();
        if (isSorted) { Console.Write("Massiv is sorted"); }
        else { Console.Write("Massiv not sorted"); }
    }
}
