﻿using System;

// Классы.

namespace Classes
{
    // Создаем класс с именем MyClass.
    // В теле класса создаем открытое поле типа string с именем field и метод с именем Method.

    class MyClass
    {
        // В теле класса создаем переменную типа string с именем field
        public string field;

        //Создаем метод с именем Method который ничего не возвращает(void)
        public void Method()
        {
            Console.WriteLine(field);
        }
        
        //Создаем метод с именем Method2 который ничего не возвращает(void) и имеет один парамет типа string с имене str
        public void Method2(string str)
        {
            Console.WriteLine(field);
            
            // Присваиваем переменной field значение параметра str
            field = str;
            
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. Создаем экземпляр класса MyClass (по сильной ссылке).
            // 2. Создаем экземпляр класса MyClass с именем instance.
            // 3. Инстанцируем класс MyClass.
            // 4. Создаем переменную с именем instance, типа MyClass и присваиваем ей адрес экземпляра на куче. 
            // (instance - является ссылкой на экземпляр класса MyClass построенный на куче)

            MyClass instance = new MyClass();

            // Полю field, экземпляра instance, присваиваем значение Hello world!

            instance.field = "Hello world!";

            // Выводим на экран значение поля field экземпляра instance.

            Console.WriteLine(instance.field);

            // Вызов метода с именем Method на экземпляре instance.
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
