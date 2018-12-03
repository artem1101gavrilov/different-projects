using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTasks
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1");
            Random random = new Random();
            //Начальные необходимые данные для генерации задания
            int minNumber = 1;
            int MaxNumer = 10;
            List<int> alfavitNumer = new List<int>();
            List<int> arrayNumber = new List<int>();

            //Заполнение Алфавита всех чисел
            for (int i = minNumber; i <= MaxNumer; i++)
            {
                alfavitNumer.Add(i);
            }
            //Заполнение массива всеми числами из Алфавита кроме одного числа
            while (alfavitNumer.Count > 1)
            {
                int randNumber = alfavitNumer[random.Next(0, alfavitNumer.Count)];
                arrayNumber.Add(randNumber);
                alfavitNumer.Remove(randNumber);
            }
            //Выводим что осталось в Алфавите
            for (int i = 0; i < alfavitNumer.Count; i++)
            {
                Console.Write(alfavitNumer[i] + " ");
            }
            Console.WriteLine();

            //Выводим все числа из Массива
            for (int i = 0; i < arrayNumber.Count; i++)
            {
                Console.Write(arrayNumber[i] + " ");
            }
            Console.WriteLine();

            /*
             * Выполнение задания
             * На вход дается List<int>, минимальное и максимальное число
             * На выходе выдаем Какое число было пропущено
             */
            int sumArray = 0;
            int MaxSumArray = (MaxNumer + minNumber) * (MaxNumer) / 2;
            for (int i = 0; i < arrayNumber.Count; i++)
            {
                sumArray += arrayNumber[i];
            }
            Console.WriteLine("Answer: " + (MaxSumArray - sumArray));
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2");
            Random random = new Random();
            
            //Исходные данные
            List<int> arrayNumber = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int randNumber = random.Next(-100, 101);
                arrayNumber.Add(randNumber);
                Console.Write(arrayNumber[i] + " ");
            }
            Console.WriteLine();
            //Выполнение задания
            arrayNumber.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arrayNumber[i] + " ");
            }
            Console.WriteLine();

            if (arrayNumber[0] * arrayNumber[1] > arrayNumber[arrayNumber.Count - 3] * arrayNumber[arrayNumber.Count - 2])
            {
                Console.WriteLine("Numbers: " + arrayNumber[0] + "," + arrayNumber[1] + "," + arrayNumber[arrayNumber.Count - 1]);
            }
            else
            {
                Console.WriteLine("Numbers: " + arrayNumber[arrayNumber.Count - 3] + "," + arrayNumber[arrayNumber.Count - 2] + "," + arrayNumber[arrayNumber.Count - 1]);
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Task 3");
            Random random = new Random();
            //Исходные данные
            List<char> arrayChar = new List<char>();
            for (int i = 0; i < 30; i++)
            {
                int randNumber = random.Next(0, 3);
                switch (randNumber)
                {
                    case 0:
                        arrayChar.Add('<');
                        break;
                    case 1:
                        arrayChar.Add('-');
                        break;
                    case 2:
                        arrayChar.Add('>');
                        break;
                }
                Console.Write(arrayChar[i] + " ");
            }
            Console.WriteLine();
            //Выполнение алгоритма 
            int RightArrows = 0;
            int LeftArrows = 0;

            for (int i = 4; i < arrayChar.Count; i++)
            {
                if (arrayChar[i] == '<')
                {
                    if ((arrayChar[i - 1] == '<') && (arrayChar[i - 2] == '-') && (arrayChar[i - 3] == '-') && (arrayChar[i - 4] == '<'))
                    {
                        LeftArrows++;
                    }
                }
                else if (arrayChar[i] == '>')
                {
                    if ((arrayChar[i - 1] == '-') && (arrayChar[i - 2] == '-') && (arrayChar[i - 3] == '>') && (arrayChar[i - 4] == '>'))
                    {
                        RightArrows++;
                    }
                }
            }
            Console.WriteLine("Right: " + RightArrows + ", Left: " + LeftArrows);
        }

        public static void Task4()
        {
            //Допустим было 10
            int k = 10;
            string text = "";
            //Ввели число 2
            //Для этого умножим наше число на 10
            k *= 10;
            //Возьмем модуль из 100 000
            k = k % 100000;
            //Прибавим 2
            k += 2;
            //Добавим нули перед началом
            for (int i = 1; i < 6; i++)
            {
                if (Math.Pow(10, i) > k)
                {
                    for (int j = 0; j < 6 - i; j++)
                    {
                        text += "0";
                    }
                    break;
                }
            }
            text += k.ToString();
            Console.WriteLine(text);
        }
        
        static void Main(string[] args)
        {
            Task3();
            Console.ReadKey(); 
        }
    }
}
