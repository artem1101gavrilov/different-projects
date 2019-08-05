using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static void Main(string[] args)
    {
        //Исходная строка
        string str = "1 3 5 7 8";
        //Конвертируем в массив интов
        int [] arrayA = Array.ConvertAll(str.Split(new char[] {' '}), Int32.Parse);
        //Ищем максимальное значение
        int maxArray = arrayA.Max();
        //Создаем новый массив, в котором будут 0 и 1
        int[] arrayB = new int[maxArray];
        //Заполняем массив arrayB
        for (int i = 0; i < arrayA.Length; ++i) arrayB[arrayA[i] - 1] = 1;
       
        //Console.ReadKey();
    }

}