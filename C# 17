using System;
using System.Collections.Generic;
using System.Threading;
namespace ConsoleApp1
{
    interface IComparable
    {
        int Square();
    }
    class Rectangle : IComparable
    {
        public int Width;
        public int Height;
        public int Square()
        {
            return Width * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IComparable rectangle = new Rectangle() { Width = 5, Height = 10 };
            Console.WriteLine($"Square: {rectangle.Square()}");
        }
    }
}
