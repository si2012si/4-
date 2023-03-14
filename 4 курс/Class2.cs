using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_курс
{
    internal class Class2
    {
        
            public int x, y, z;
            public void Vvod()
            {
                Console.WriteLine("Введите значения полей x, y, z: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());
            }
            public int Sum()
            {
                return x + y + z;
            }
        
    }
}
