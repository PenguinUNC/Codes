using System;
using System.Collections.Generic;
using System.Threading;
namespace ConsoleApp1
{
    interface Iperson
    {
        string Name { get; set; }
    }
    class Student : Iperson
    {
        public string Name { get; set; }
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Name = "John", Age = 20 };
            Console.Write(student.Name);
        }
    }
}
