﻿using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Словарь:");

            var dic = new Dictionary<string, string>();

            dic.AddToDictionary("table", "стол");
            dic.AddToDictionary("apple", "яблоко");
            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("pencil", "карандаш");
            dic.AddToDictionary("cap", "чашка");
            dic.AddToDictionary("tea", "чай");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine("В словаре {0} записей", dic.Lenght);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записив словаре");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]);
            }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]);

            // Delay.
            Console.ReadKey();
        }
    }
}
