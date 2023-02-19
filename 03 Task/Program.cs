// Kiril Lazarov current employee file
namespace _03_Task
{
    using System;
    using System.Threading;
    using System.Globalization;
    using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2023, 05, 2, 20, 30, 22);
            int age = 34;
            int salary = 2000;
            Console.WriteLine($"The current date is {d}.My name is Kiril and i am {age} years old");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("gb-GB");
            Console.WriteLine("My current salary is {0:c}", 2000);
            Console.Read();
        }
    }
}