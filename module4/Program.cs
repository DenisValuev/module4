﻿namespace module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane"; // создание константы
            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет, мир"); //вывод литералов
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n Jane");

            Console.WriteLine("\x01");// вывод символьного литерала

            Console.WriteLine(true); // вывод логических литералов
            Console.WriteLine(false);

            // анкета
            byte age = 27;
            bool pet = true;
            double size = 37.5;
            Console.WriteLine("My name is {0} \nMy age is {1} \nDo I have a pet? {2} \nMy shoe size is {3}", MyName, age, pet, size);
            Console.ReadKey();

            // перечесление
            DaysOfWeek MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);
            
        }
        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }
    }

}