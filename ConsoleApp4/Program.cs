using System;
using System.Collections;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Используя пространство имен System.Collections.Stack реализуйте стек строк.\n Программируйте все операторы стека");

            Stack stack = new Stack();
            // Добавляем элементы в стек
            stack.Push("Hello");
            stack.Push("world");
            stack.Push("!");
            // Выводим содержимое стека
            Console.WriteLine("Стек:");
            foreach (object obj in stack)
                Console.WriteLine(obj);
            // Получаем элемент с вершины стека без его удаления
            Console.WriteLine("\nВерхний элемент стека:");
            Console.WriteLine(stack.Peek());
            // Извлекаем элементы из стека и выводим их на экран
            Console.WriteLine("\nИзвлечение элементов из стека:");
            while (stack.Count > 0) { }
                Console.WriteLine(stack.Pop());

        }
    }
}
