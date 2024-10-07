using System;
using System.Runtime.CompilerServices;

public class SimpleList<T>
{
    private T[] elements;
    private int size;

    public SimpleList(int capacity)
    {
        elements = new T[capacity];
        size = 0;
    }

    public void Add(T item)
    {
        if (size > elements.Length)
            Console.WriteLine("Список переполнен!");
        else
            elements[size++] = item;
    }

    public T Remove()
    {
        if (size == 0)
            Console.WriteLine("Удаление из пустого списка");
        else
            return elements[--size];

        return default(T);
    }
    public T GetLast()
        {
            if (size < 1)
                Console.WriteLine("Пустой список");
            else
                return elements[size - 1];

            return default(T);
        }


}