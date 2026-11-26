using System;
using System.Collections.Generic;
using System.Threading;
namespace ConsoleApp1
{
    interface IAction
    {
        void Run();
    }
    class A : IAction
    {
        public void Run() => Console.WriteLine("A");
    }
    class B : IAction
    {
        void IAction.Run() => Console.WriteLine("B");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.Run();
            ((IAction)b).Run();
        }
    }
}
