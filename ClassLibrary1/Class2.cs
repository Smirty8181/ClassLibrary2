public class SimpleStack<T>
{
    private SimpleList<T> list;

    public SimpleStack(int capacity)
    {
        list = new SimpleList<T>(capacity);
    }

    public void Push(T item)
    {
        
        if (list.GetSize() >= list.GetCapacity())
        {
            Console.WriteLine("Ошибка: Переполнение стека!");
            return;
        }

        list.Add(item);
    }

    public T Pop()
    {
        if (list.GetSize() == 0) 
        {
            Console.WriteLine("Ошибка: Стек пуст!");
            return default(T); 
        }

        T item = list.Remove();
        if (item == null) 
        {
            Console.WriteLine("Ошибка: Не удалось удалить элемент из стека!");
            return default(T);
        }

        return item;
    }

    public T Peek()
    {
        if (list.GetSize() == 0)
        {
            Console.WriteLine("Ошибка: Стек пуст");
            return default(T); 
        }

        T item = list.GetLast();
        if (item == null) 
        {
            Console.WriteLine("Ошибка: Не удалось получить верхний элемент стека!");
            return default(T);
        }

        return item;
    }
}