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
            Console.ReadKey();
        }
    }
}