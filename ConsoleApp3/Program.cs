using System;
using System;
using System.Collections;
public class MyQueue
{
    private Queue queue = new Queue();
    public void Enqueue(string item)
    {
        this.queue.Enqueue(item);
    }
    public string Dequeue()
    {
        return (string)this.queue.Dequeue();
    }
    public string Peek()
    {
        return (string)this.queue.Peek();
    }
    public int Count()
    {
        return this.queue.Count;
    }
    public void Clear()
    {
        this.queue.Clear();
    }
    public bool Contains(string item)
    {
        return this.queue.Contains(item);
    }
    public void CopyTo(string[] array, int index)
    {
        this.queue.CopyTo(array, index);
    }
}
namespace ConsoleApp3
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Используя пространство имен System.Collections.Queue реализуйте очередь строк.\nПрограммируйте все операторы очереди.");
     MyQueue myQueue = new MyQueue();
            myQueue.Enqueue("some value");
            myQueue.Enqueue("another value");
            myQueue.Peek();
            myQueue.Dequeue();
        }
        

    }
}
