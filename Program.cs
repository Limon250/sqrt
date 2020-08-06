using System.Threading;
using System.Dynamic;
using System.Diagnostics;
using System;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a value!");
            double a = Double.Parse(Console.ReadLine());
            Thread.Sleep(800);

            double b = Math.Sqrt(a);
            Thread.Sleep(800);
            Console.WriteLine("Sqrt from {0} = {1}", a, b);

            Thread.Sleep(800);
            Console.WriteLine("To exit just press Enter");
            Console.ReadKey();
        }   
    }
}     
