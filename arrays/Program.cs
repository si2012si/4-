using System;
namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем первый массив-список и заполняем его числами от 1 до 10
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }
            // Задаем второй массив-список и копируем в него первую половину первого массива
            int[] array2 = new int[array1.Length / 2];
            Array.Copy(array1, 0, array2, 0, array1.Length / 2);
            // Сортируем второй массив-список и выводим его на экран
            Array.Sort(array2);
            Console.WriteLine("Второй массив-список после сортировки:");
            foreach (int number in array2)
            {
                Console.Write(number + " ");
            }
            // Обращаем второй массив-список и выводим его на экран
            Array.Reverse(array2);
            Console.WriteLine("\nВторой массив-список после обращения:");
            foreach (int number in array2)
            {
                Console.Write(number + " ");
            }
            // Вставляем новые элементы во второй массив-список и выводим его на экран
            array2[0] = 0;
            Array.Resize(ref array2, array2.Length + 2);
            Array.Copy(array2, 1, array2, 3, array2.Length - 3);
            array2[1] = 2;
            array2[3] = 4;
            array2[5] = 6;
            Console.WriteLine("\nВторой массив-список с новыми элементами на 1, 3, 5 позициях:");
            foreach (int number in array2)
            {
                Console.Write(number + " ");
            }
        }
    }
}
