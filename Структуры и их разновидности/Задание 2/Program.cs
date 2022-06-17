using System;

namespace Задание_2
{
    class MyClass
    {
        public string Сhange;
    }
    struct MyStruct
    {
        public string Сhange;
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Сhange = "Изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Сhange = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            MyStruct mystruct = new MyStruct();

            myclass.Сhange = "Не изменено";
            mystruct.Сhange = "Не изменено";

            ClassTaker(myclass);
            StruktTaker(mystruct);

            Console.WriteLine("Класс: " + myclass.Сhange);
            Console.WriteLine("Структура: " + mystruct.Сhange);

            Console.Read();
        }
    }
}