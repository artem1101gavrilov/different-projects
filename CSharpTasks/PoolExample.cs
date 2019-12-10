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
        Console.WriteLine();
        for (int i = 0; i < 13; i++)
        {
            GameObject ga = new GameObject();
            ga.name = "b1_old";
            PoolManager.instance.listPools[0].ReturnToPool(ga);
        }
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine(PoolManager.instance.listPools[0].TakeFromPool());
        }
        Console.WriteLine();
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine(PoolManager.instance.listPools[1].TakeFromPool());
        }
        Console.ReadLine(); 
    }
}

public class PoolObjects
{
    public Stack<GameObject> poolObjects { get; private set; }
    private GameObject prefab;

    public PoolObjects(GameObject prefab)
    {
        poolObjects = new Stack<GameObject>();
        this.prefab = prefab;
        for(int i  = 0; i < 10; ++i)
            AddToPool();
    }

    void AddToPool()
    {
        var go = new GameObject();
        go.SetActive(false);
        go.name = prefab.name;
        poolObjects.Push(go);
    }

    public void ReturnToPool(GameObject gameObject)
    {
        gameObject.SetActive(false);
        poolObjects.Push(gameObject);
    }

    public GameObject TakeFromPool()
    {
        if (poolObjects.Count == 0) AddToPool();
        poolObjects.Peek().SetActive(true);
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

        GameObject go1 = new GameObject();
        go1.name = "b1";
        GameObject go2 = new GameObject();
        go2.name = "b2";

        listPools = new List<PoolObjects>();
        listPools.Add(new PoolObjects(go1));
        listPools.Add(new PoolObjects(go2));
    }
}

public class GameObject
{
    bool isActive;
    static int id;
    public string name;

    public void SetActive(bool active)
    {
        isActive = active;
    }

    public GameObject()
    {
        isActive = true;
        name = id++.ToString();
    }

    static GameObject()
    {
        id = 0;
    }

    public static GameObject Instantiate()
    {
        return new GameObject();
    }

    public override string ToString()
    {
        return name;
    }
}
