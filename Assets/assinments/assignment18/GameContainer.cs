using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameContainer<T>
{
    public T item;
    public void SetItem(T item)
    {
        this.item = item;
    }
    public T GetItem()
    {
        return item;
    }
}
public static class GameUtils
{
    public static string DescribeItem<T>(T something)
    {
        return $"This item is a {something}.";
    }
}

