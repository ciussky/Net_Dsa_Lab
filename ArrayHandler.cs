using System;
using System.Collections.Generic;
using System.Globalization;

public class ArrayHandler
{
    private List<int> items = new List<int>();

    public void Add(int value)
    {       
        items.Add(value);
        Console.WriteLine($"Added {value} to array, array values are [{string.Join(",", items)}]");
    }

    public void InsertAt(int index, int value)
    {
        if (index < 0 || index > items.Count - 1)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        items.Insert(index, value);
        Console.WriteLine($"Inserted {value} at index {index}");

        Console.WriteLine($"Updated array is: [{string.Join(",", items)}]");

    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > items.Count - 1)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        items.RemoveAt(index);

        //Console.WriteLine($"Removed {items[index]}");
        Console.WriteLine($"Updated array is: [{string.Join(",", items)}]");
    }

    public void GetAt(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        Console.WriteLine($"Element at index {index} is {items[index]}");
    }

    public void Print()
    {
        Console.WriteLine("Array: " + string.Join(", ", items));
    }

    public int Count()
    {
        return items.Count;
    }

    public string ArrItems()
    {
        return string.Join(", ", items);
    }
}
