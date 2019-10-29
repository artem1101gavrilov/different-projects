using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

public class Transform 
{
    public int x;
}

public class GameObject
{
    public int id;
    public static void Destroy(GameObject go)
    {
        Console.WriteLine("Delete " + go.id.ToString());
    }
}

// TODO : убрать where new () и заменить метод POP
public class Pool<T> where T : new()
{
    Queue<T> queue;
    T t;
    Transform x;
    const int sz = 10;

    public Pool(T value, Transform x)
    {
        t = value;
        this.x = x;
        queue = new Queue<T>(sz);
    }

    public bool Push(T value)
    {
        if (queue.Count == sz)
        {
            if (value is GameObject)
            {
                GameObject g = value as GameObject;
                GameObject.Destroy(g);
            }
            return false;
        }
        if (value is GameObject)
        {
            Console.WriteLine("Add " + (value as GameObject).id.ToString());
        }
        queue.Enqueue(value);
        return true;
    }

    public T Pop()
    {
        if (queue.Count == 0)
        {
            return new T();
        }
        T tt = queue.Dequeue();
        if (tt is GameObject)
        {
            Console.WriteLine("Remove " + (tt as GameObject).id.ToString());
        }
        return tt;
    }
}

class Solution
{
    static void Main() 
    {
        int id = 0 ;
        Transform t = new Transform();
        GameObject g = new GameObject() { id = id };
        Pool<GameObject> pool  = new Pool<GameObject>(g, t);

        for (int i = 0; i < 15; ++i, ++id)
        {
            GameObject gi = new GameObject() { id = id };
            pool.Push(gi);
        }

        for (int i = 0; i < 10; ++i)
        {
            GameObject gi = pool.Pop();
            Console.WriteLine(gi.id);
        }

        Console.WriteLine();
        Console.ReadLine();
    }

}