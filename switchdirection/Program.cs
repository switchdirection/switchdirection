﻿namespace switchdirection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMonth();
            TypeOfTheYear();
        }

        static void DisplayMonth()
        {
            Console.Write("Введите номер месяца: ");
            byte monthNumber;
            if (byte.TryParse(Console.ReadLine(), out monthNumber) && monthNumber > 0 && monthNumber <= 12) { }
            else
            {
                Console.WriteLine("Вы ввели не корректный номер месяца.");
            }
            switch (monthNumber)
            {
                case 1:
                    {
                        Console.WriteLine("Это Январь!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Это Февраль!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Это Март!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Это Апрель!");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Это Май!");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Это Июнь!");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Это Июль!");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Это Август!");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Это Сентябрь!");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Это Октябрь!");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Это Ноябрь!");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Это Декабрь!");
                        break;
                    }

            }
        }

        public static void TypeOfTheYear()
        {
            Console.Write("Введите номер месяца: ");
            byte monthNumber;
            if (byte.TryParse(Console.ReadLine(), out monthNumber) && monthNumber > 0 && monthNumber <= 12) { }
            else { Console.WriteLine("Вы ввели не корректный номер месяца."); }
            if (monthNumber >= 1 && monthNumber <= 2 || monthNumber == 12)
            {
                Console.WriteLine("Это Зима!");
            }
            else if (monthNumber >= 3 && monthNumber <= 5)
            {
                Console.WriteLine("Это Весна!");
            }
            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                Console.WriteLine("Это Лето!");
            }
            else if (monthNumber >= 9 && monthNumber <= 11)
            {
                Console.WriteLine("Это Осень!");
            }
        }
    }
}
