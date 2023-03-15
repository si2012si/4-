using System;

public abstract class BaseClass
{
    public abstract void vvod(); // Абстрактный метод для ввода значений
    public abstract void vivod(); // Абстрактный метод для вывода значений
}
// Первый производный класс
public class FirstClass : BaseClass
{
    private double x, y, z; // Частные поля
    // Конструктор инициализации
    public FirstClass()
    {
        x = y = z = 0;
    }
    // Реализация методов интерфейса
    public override void vvod()
    {
        Console.WriteLine("Введите новые значения для x, y и z: ");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());
    }
    public override void vivod()
    {
        Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
    }
}
// Второй производный класс
public class SecondClass
{
    private int a, b, c; // Частные поля
    // Конструктор инициализации
    public SecondClass()
    {
        a = b = c = 0;
    }
    // Виртуальные методы
    public virtual void Method1()
    {
        Console.WriteLine("Вызван метод 1 из SecondClass");
    }
    public virtual void Method2()
    {
        Console.WriteLine("Вызван метод 2 из SecondClass");
    }
}
// Третий производный класс, наследующий от SecondClass
public class ThirdClass : SecondClass
{
    public override void Method1()
    {
        Console.WriteLine("Вызван метод 1 из ThirdClass");
    }
    public override void Method2()
    {
        Console.WriteLine("Вызван метод 2 из ThirdClass");
    }
}
// Интерфейс с методами vvod и vivod
public interface IInputOutput
{
    void vvod();
    void vivod();
}
// Измененный первый класс, реализующий интерфейс
public class UpdatedFirstClass : IInputOutput
{
    private double x, y, z;
    public UpdatedFirstClass()
    {
        x = y = z = 0;
    }
    public void vvod()
    {
        Console.WriteLine("Введите новые значения для x, y и z: ");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());
    }
    public void vivod()
    {
        Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
    }
}
// Пример использования классов
class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты классов
        BaseClass first = new FirstClass();
        IInputOutput updatedFirst = new UpdatedFirstClass();
        SecondClass second = new SecondClass();
        ThirdClass third = new ThirdClass();
        // Вызываем методы для первого объекта
        first.vvod();
        first.vivod();
        // Вызываем методы для второго объекта
        updatedFirst.vvod();
        updatedFirst.vivod();
        // Вызываем виртуальные методы для третьего объекта
        second.Method1();
        second.Method2();
        third.Method1();
        third.Method2();
        Console.ReadLine();
    }
}