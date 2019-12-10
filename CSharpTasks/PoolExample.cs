using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void Main()
    {
        PoolManager pools = new PoolManager();
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine(PoolManager.instance.listPools[0].TakeFromPool());
        }
        for (int i = 0; i < 13; i++)
        {
            PoolManager.instance.listPools[0].AddToPool(i*10);
        }
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine(PoolManager.instance.listPools[0].TakeFromPool());
        }
        Console.ReadLine(); 
    }
}

public class PoolObjects
{
    int id = 0;
    public Stack<int> poolObjects { get; private set; }

    public PoolObjects()
    {
        poolObjects = new Stack<int>();
        for(int i  = 0; i < 10; ++i)
            AddToPool(id++);
    }

    public void AddToPool(int i)
    {
        poolObjects.Push(i);
    }

    public void ReturnToPool(int gameObject)
    {
        poolObjects.Push(gameObject);
    }

    public int TakeFromPool()
    {
        if (poolObjects.Count == 0) AddToPool(id++);
        return poolObjects.Pop();
    }
}

public class PoolManager
{
    public static PoolManager instance = null;
    public List<PoolObjects> listPools;

    public PoolManager()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            return;
        }

        listPools = new List<PoolObjects>();
        listPools.Add(new PoolObjects());
        listPools.Add(new PoolObjects());
    }
}