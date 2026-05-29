using System;
using System.Collections.Generic;
using System.Threading;
namespace ConsoleApp1
{
    interface IFlyable
    {
        void Fly();
    }
    interface ISwimmable
    {
        void Swim();
    }
    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
        }
    }
}   
