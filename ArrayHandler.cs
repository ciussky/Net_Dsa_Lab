using System;
using System.Collections.Generic;
using System.Globalization;

public class ArrayHandler
{
    private List<int> items = new List<int>();

    public void Add(int value)
    {       
        items.Add(value);
        Console.WriteLine($"Added {value} to array");
        Print();
    }

    public void InsertAt(int index, int value)
    {
        if (index < 0 || index > items.Count)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        if (items.Count == 0 && index == 0)
        {
            Add(value);
        }
        else
        {
            items.Insert(index, value);
            Console.WriteLine($"Inserted {value} at index {index}");
            Print();
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > items.Count - 1)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        items.RemoveAt(index);
        Print();
    }

    public void GetAt(int index)
    {
        if (index < 0 || index > items.Count - 1)
        {
            Console.WriteLine("Index invalid.");
            return;
        }

        Console.WriteLine($"Element at index {index} is {items[index]}");
    }

    public void Print()
    {
        Console.WriteLine($"Current Array: [{string.Join(", ", items)}]");
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
