using System;
using System.Collections.Generic;
using System.Threading;
namespace ConsoleApp1
{
    interface IMovable
    {
        void Move();
    }
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("The bicycle is moving.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();
            car.Move();
            bicycle.Move();
        }
    }
}
