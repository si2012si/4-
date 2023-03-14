using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y:");
            double y = double.Parse(Console.ReadLine());
            double z = Math.Sin(x) + Math.Cos(x) + Math.Sin(2 * x);
            Console.WriteLine($"Z({x},{y}) = {z}");
            Console.ReadLine();
        }
    }
}
