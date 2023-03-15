using System;
using System.Collections;

namespace TrueFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание первых двух массивов
            BitArray a = new BitArray(new bool[] { true, true, false, false });
            BitArray b = new BitArray(new bool[] { true, false, true, false });
            // Битовое сложение и вывод на экран
            BitArray sum = a.Or(b);
            Console.WriteLine("Сумма: " + String.Join("", ToBoolArray(sum)));
            // Битовое умножение и вывод на экран
            BitArray product = a.And(b);
            Console.WriteLine("Произведение: " + String.Join("", ToBoolArray(product)));
            // Инверсия первого массива и вывод на экран
            BitArray inverted = a.Not();
            Console.WriteLine("Инверсия: " + String.Join("", ToBoolArray(inverted)));
        }
        // Вспомогательный метод для преобразования BitArray в bool[]
        static bool[] ToBoolArray(BitArray bits)
        {
            bool[] array = new bool[bits.Count];
            for (int i = 0; i < bits.Count; i++)
            {
                array[i] = bits.Get(i);
            }
            return array;
        }
    }
}
