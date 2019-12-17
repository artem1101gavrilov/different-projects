using System;
using System.Text.RegularExpressions;

public class Solution
{
    //Определение количества слов, содержащих более трех запятых.
    static void Function1(string [] words)
    {
        int count = 0;
        foreach (var str in words)
        {
            int k = 0;
            foreach (Match m in Regex.Matches(str, ","))
            {
                k++;
            }
            if (k >= 3) count++;
        }
        Console.WriteLine("Количество слов с тремя и более запятых = " + count);
    }

    //Определить длину слова, содержащего наибольшее число символов "о" и напечатать его
    static void Function2(string[] words)
    {
        int maxO = 0;
        string answer = "";
        foreach (var str in words)
        {
            int k = 0;
            foreach (Match m in Regex.Matches(str, "о"))
            {
                k++;
            }
            if (k > maxO)
            {
                maxO = k;
                answer = str;
            }
        }
        Console.WriteLine("Максимальное количество букв о = " + maxO + " в слове " + answer);
    }

    //Определить длину строки до третьего с конца строки слова
    static void Function3(string[] words)
    {
        int count = 0;
        for (int  i = 0; i < words.Length - 3; ++i)
        {
            count += words[i].Length;
            ++count; //Пробел
        }
        --count; //Последний пробел не в счет
        Console.WriteLine("Длина строки до третьего с конца строки слова = " + count);
    }

    //Определить количество слов, начинающихся на сочетание "ви"
    static void Function4(string[] words)
    {
        int count = 0;
        foreach (var str in words)
        {
            if (str.StartsWith("ви")) count++;
        }
        Console.WriteLine("Количество слов, начинающихся на сочетание \"ви\" = " + count);
    }

    static void Main()
    {
        var text = "При написании приложений,,, ви ви ви одной из важнейших вопросов являются потребление памяти и отзывчивость (скорость работы).";
        var words = text.Split(' ');
        Function1(words);
        Function2(words);
        Function3(words);
        Function4(words);
        Console.ReadLine(); 
    }
}