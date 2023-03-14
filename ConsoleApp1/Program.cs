using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name: ");
            string fio = Console.ReadLine();
            Console.WriteLine("Please enter your course: ");
            int kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your group: ");
            string group = Console.ReadLine();
            Console.WriteLine("\nYour data: \nName: {0} \nCourse: {1} \nGroup: {2}", fio, kurs, group);
            Console.ReadLine();
        }
    }
}