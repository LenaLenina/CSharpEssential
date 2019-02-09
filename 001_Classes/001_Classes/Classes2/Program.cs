using System;

// Классы.

// Использование методов доступа к закрытым полям.

namespace Classes
{
    class MyClass
    {
        private string field = null;
        int number = 10;
        bool boolean = true;

        public void SetField(string value) // Метод-мутатор - mutator  (setter)
        {
            field = value;
        }
        
        //Создаем метод с именем GetField который возвращает значение типа string (!требуется обязательно вернуть string через return).
        //Не имеет параметров.
        
        public string GetField()           // Метод-аксессор -  accessor  (getter)
        {
            return field;
        }
        
        public int GetNumber()
        {
            return number;
        }
        
        public bool GetBool()
        {
            return boolean;   
        }  
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello world!");     // Метод-мутатор

            string @string = instance.GetField();  // Метод-аксессор

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
