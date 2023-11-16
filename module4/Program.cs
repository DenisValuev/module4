namespace module4
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

            // Задание №3.4.3 Светофор
            Semaphore ColorSemNow = Semaphore.Green;
            Console.WriteLine(ColorSemNow);

            // ввод строки 
            Console.WriteLine("Введите: Цыга на цыпочках цыпленку цыкнул цыц");
            string str = Console.ReadLine();
            Console.WriteLine(str);

            //Деление
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            //Инкремент постфиксный
            int counter = 10;
            Console.WriteLine("Value : {0} Increment: {1}", counter, counter++);
            Console.WriteLine(counter);

            int k = -1;
            int b = 2;
            b = b - k;
            Console.WriteLine(b);

            // Преобразование типов
            Console.Write("Введите свой возраст: ");
            byte MyAge = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Ваш возраст: {0}", MyAge);

            // Задание 3.7.4

            Console.Write("Какой Ваш любимый день недели? ");
            byte Day = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день {0}", (DayOfWeek)Day);

        }
        enum DaysOfWeek : byte
        {
            Tuesday = 2,
            Monday = 1,
            Wednesday = 3,
            Friday = 4
        }

        // Светофор
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }

}