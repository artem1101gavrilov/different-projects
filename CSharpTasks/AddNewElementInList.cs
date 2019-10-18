using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main() 
    {
        //Заполняем данные в массив - 12345
        List<int> arr = new List<int>();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);
        arr.Add(5);

        //Разбиваю лист на массивы 123 и 45
        /*int[] arr2 = new int[3];
        int[] arr3 = new int[2];
        arr.CopyTo(0, arr2, 0, 3);
        arr.CopyTo(3, arr3, 0, 2);

        //Создаю новый лист, который объединяет два массива и новое число
        List<int> arr4 = new List<int>();
        arr4.AddRange(arr2);
        arr4.Add(9);
        arr4.AddRange(arr3);*/

        arr.AddNewElement(9, 3);

        //Вывод данных на экран
        foreach (var i in arr)
        {
            Console.Write(i);
        }

        Console.ReadLine();
    }
}

public static class AddNewElementList
{
    public static void AddNewElement(this List<int> list, int newElement, int index)
    {
        //Если размер меньше, то выходим
        if(index > list.Count) return;
        var lastIndex = list.Count - index;

        //Разбиваю лист на массивы
        int[] arr1 = new int[index];
        int[] arr2 = new int[lastIndex];
        list.CopyTo(0, arr1, 0, index);
        list.CopyTo(index, arr2, 0, lastIndex);

        //Объединение двух массивов и нового числа
        list.Clear();
        list.AddRange(arr1);
        list.Add(newElement);
        list.AddRange(arr2);
    }
}
