namespace Calculator2._0
{
    internal class Program
    {
        public delegate void Add(double firstValue, double secondValue);
        public delegate void Substract(double firstValue, double secondValue);
        public delegate void Multiply(double firstValue, double secondValue);
        public delegate void Division(double firstValue, double secondValue);
        public delegate void Pow(double firstValue, double secondValue, double pow1, double pow2);
        public delegate void Root(double firstValue, double secondValue);
        public delegate void FindSin(double firstValue, double secondValue);
        public delegate void FindCos(double firstValue, double secondValue);

        static void Main(string[] args)
        {

            Calculator();
        }
        public static void Calculator()
        {
            Add add = AddFunc;
            Substract substract = SubstractFunc;
            Multiply multiply = MultiplyFunc;
            Division divide = DivisionFunc;
            Pow pow = PowFunc;
            Root root = RootFunk;
            FindCos cos = FindCosFunc;
            FindSin sin = FindSinFunc;
            bool key = true;
            while (key)
            {
            reWrote:
                double firstValue, secondValue;
                while (true)
                {
                    Console.Write("Введите первое число: ");
                    if (double.TryParse(Console.ReadLine(), out firstValue)) { break; }
                    else
                    {
                        Console.WriteLine("Вы ввелие не корректное число");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Введите второе число: ");
                    if (double.TryParse(Console.ReadLine(), out secondValue)) { break; }
                    else
                    {
                        Console.WriteLine("Ошибка: Вы ввелие не корректное число");
                        continue;
                    }
                }
                Console.Clear();
                byte userChoice;
                while (key)
                {
                    while (true)
                    {
                        Console.Write("Выберите операцию:\n1. +\n2. -\n3. *\n4. /\n5. ^\n6. sqrt\n7. cos(x)\n8. sin(x)\n9. Изменить введенные числа\n10. Выход\nВыбор: ");
                        if (byte.TryParse(Console.ReadLine(), out userChoice)) { break; }
                        else
                        {
                            Console.WriteLine("Ошибка: Вы выбрали несуществующую операцию.\n");
                            continue;
                        }
                    }

                    Console.Clear();
                    switch (userChoice)
                    {
                        case 1:
                            {
                                add(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                substract(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                multiply(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                if (secondValue == 0)
                                {
                                    while (true)
                                    {
                                        Console.Write("Получилось так, что вы ввели 0, на 0 делить нельзя, введите другое число пожалуйста: ");
                                        if (double.TryParse(Console.ReadLine(), out secondValue) && secondValue != 0) { break; }
                                        else
                                        {
                                            Console.WriteLine("Ошибка: Оно всё равно равно 0, так не положено");
                                            continue;
                                        }
                                    }

                                }
                                divide(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 5:
                            {
                                double pow1, pow2;

                                while (true)
                                {
                                    Console.Write("Введите степень в которую хотите возвести первое число: ");
                                    if (double.TryParse(Console.ReadLine(), out pow1)) { break; }
                                    else
                                    {
                                        Console.WriteLine("Ошибка: Вы ввели неккоректную степень числа");
                                        continue;
                                    }
                                }
                                while (true)
                                {
                                    Console.Write("Введите степень в которую хотите возвести второе число: ");
                                    if (double.TryParse(Console.ReadLine(), out pow2)) { break; }
                                    else
                                    {
                                        Console.WriteLine("Ошибка: Вы ввели неккоректную степень числа");
                                        continue;
                                    }
                                }

                                pow(firstValue, secondValue, pow1, pow2);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 6:
                            {
                                root(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 7:
                            {
                                cos(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 8:
                            {
                                sin(firstValue, secondValue);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 9:
                            {
                                goto reWrote;
                            }
                        case 10:
                            {
                                Console.Clear();
                                Console.WriteLine("Досвидания <3");
                                key = false;
                                break;
                            }
                    }
                }




            }
        }

        public static void AddFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: {firstValue} + {secondValue} = {firstValue + secondValue}");
        }

        public static void SubstractFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: {firstValue} - {secondValue} = {firstValue - secondValue}");
        }
        public static void MultiplyFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: {firstValue} * {secondValue} = {firstValue * secondValue}");
        }
        public static void DivisionFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: {firstValue} / {secondValue} = {firstValue / secondValue}");
        }
        public static void PowFunc(double firstValue, double secondValue, double pow1, double pow2)
        {
            Console.WriteLine($"Результат: \n{firstValue}^{pow1} = {Math.Round(Math.Pow(firstValue, pow1), 5)}\n{secondValue}^{pow2} = {Math.Round(Math.Pow(secondValue, pow2), 5)}");
        }
        public static void RootFunk(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: \nsqrt({firstValue}) = {Math.Round(Math.Sqrt(firstValue), 5)}\nsqrt({secondValue}) = {Math.Round(Math.Sqrt(secondValue), 5)}");
        }
        public static void FindSinFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: \nsin({firstValue}) = {Math.Round(Math.Sin(firstValue), 5)}\nsin({secondValue}) = {Math.Round(Math.Sin(secondValue), 5)}");
        }
        public static void FindCosFunc(double firstValue, double secondValue)
        {
            Console.WriteLine($"Результат: \ncos({firstValue}) = {Math.Round(Math.Cos(firstValue), 5)}\ncos({secondValue}) = {Math.Round(Math.Cos(secondValue), 5)}");
        }
    }
}
