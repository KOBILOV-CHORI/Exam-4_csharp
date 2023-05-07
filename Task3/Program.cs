var list = new List<int>();
list.Add(12);
list.Add(43);
System.Console.WriteLine(list.ToString());
System.Console.WriteLine(list[1]);


public class MyList<T>
{
    List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public void Remove(T item)
    {
        items.Remove(item);
    }
    public int Count()
    {
        return items.Count();
    }
    public bool Contains(T item)
    {
        return items.Contains(item);
    }
    
}