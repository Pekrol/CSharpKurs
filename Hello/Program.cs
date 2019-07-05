using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValueTypes();

            for (; ; )
            {
                Greetings();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisuje komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni możesz wypić browca!!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś zły wiek!!");
            }
            else
            {
                Console.WriteLine("Możesz wypić mleko :) ");
            }
        }

        /// <summary>
        /// Powitanie użytkownika
        /// </summary>
        private static void Greetings()
        {
            Console.Write("Wpisz imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
