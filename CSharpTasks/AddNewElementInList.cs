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
        int[] arr2 = new int[3];
        int[] arr3 = new int[2];
        arr.CopyTo(0, arr2, 0, 3);
        arr.CopyTo(3, arr3, 0, 2);

        //Создаю новый лист, который объединяет два массива и новое число
        List<int> arr4 = new List<int>();
        arr4.AddRange(arr2);
        arr4.Add(9);
        arr4.AddRange(arr3);

        //Вывод данных на экран
        foreach (var i in arr4)
        {
            Console.Write(i);
        }
        Console.ReadLine();
    }
}