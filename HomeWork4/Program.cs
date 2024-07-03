using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstCyclesTask();
            SecondCyclesTask();
            ThirdCyclesTask();
            FourthCyclesTask();
            FifthCyclesTask();
            SixCyclesTask();

            FirstArraysTask();
            SecondArraysTask();
            ThirdArraysTask();
            FourthArraysTask();
        }


        public static void FirstCyclesTask()
        {
            Console.WriteLine("Result of FirstCyclesTask: ");
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        public static void SecondCyclesTask()
        {
            Console.WriteLine("Result of SecondCyclesTask: ");
            for(int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        public static void ThirdCyclesTask()
        {
            Console.WriteLine("Result of ThirdCyclesTask: ");
            int variable;
            while(true)
            {
                Console.Write("Введите любое положительное число: ");
                if (int.TryParse(Console.ReadLine(), out variable) && variable > 0)
                {
                    for(int i = 1; i <= variable; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число.");
                }

            }
            Console.WriteLine("\n");
        }
        public static void FourthCyclesTask()
        {
            Console.WriteLine("Result of FourthCyclesTask: ");
            Console.Write("Введите количество чисел: ");
            int numberOfIterations;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out numberOfIterations) && numberOfIterations > 0) { break; }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число.");
                }
            }
            int i = 1;
            while (i <= numberOfIterations)
            {
                Console.Write((i*7) + " ");
                i++;
            }
            Console.WriteLine("\n");
        }
        public static void FifthCyclesTask()
        {
            Console.WriteLine("Result of FifthCyclesTask: ");
            for (int i = 0, j = 0; j < 10; i -= 5, j++){
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        public static void SixCyclesTask()
        {
            Console.WriteLine("Result of SixCyclesTask: ");
            for (int i = 10; i <= 20; i++)
            {
                Console.Write(Math.Pow(i,2) + " ");
            }
            Console.WriteLine("\n");
        }

        public static Random rand = new Random();

        public static void FirstArraysTask()
        {
            Console.WriteLine("Result of FirstArraysTask: ");
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int number;
            while (true)
            {
                Console.Write("Введите число: ");
                if(int.TryParse(Console.ReadLine(), out number)) { break; }
                else
                {
                    Console.WriteLine("Вы ввели не корректное число");
                }
            }
            bool contains = arr.Contains(number);
            if(contains)
            {
                Console.WriteLine("Число есть в массиве.");
            }
            else
            {
                Console.WriteLine("Числа нет в массиве.");
            }

            Console.WriteLine("\n");
        }
        public static void SecondArraysTask()
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int number;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                if(int.TryParse(Console.ReadLine(), out number)) { break;}
                else
                {
                    Console.WriteLine("Вы ввели некорректное число.");
                }
            }

            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            int[] arr2 = new int[arr.Length - count];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] != number)
                {
                    arr2[j] = arr[i];
                    j++;
                } 
            }
            for(int i = 0; i<arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static void ThirdArraysTask()
        {
            int size;
            while (true)
            {
                Console.Write("Введите размер массива: ");
                if(int.TryParse(Console.ReadLine(), out size)) { break; }
                else
                {
                    Console.WriteLine("Вы ввели некорректный размер массива");
                }
            }
            int[] arr = new int[size];
            for(int i =0; i < size; i++)
            {
                arr[i] = rand.Next(0, 256);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int min = arr[0], max = arr[0];
            
            double average = 0;
            for(int i = 0; i < size ; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                average += arr[i];
            }
            Console.WriteLine($"Min element: {min}\nMax element: {max}\nAverage: {average/size}");
        }
        public static void FourthArraysTask()
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];
            double average = 0;
            double average2 = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0,20);
                arr2[i] = rand.Next(0, 20);
                average += arr[i];
                average2 += arr2[i];
            }
            Console.WriteLine("Первый массив: ");
            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            average /= 5; average2 /= 5;
            Console.WriteLine("Первое среднее арифметическое: " + average + "\nВторое среднее арифметическое: " + average2);
            if (average == average2)
            {
                Console.WriteLine("Среднее арифметические равны");
            }
            else
            {
                if(average > average2)
                {
                    Console.WriteLine("Среднее арифметическое первого массива больше");
                }
                else
                {
                    Console.WriteLine("Среднее арифметическое второго массива больше");
                }
            }
            
        }
    }
}
