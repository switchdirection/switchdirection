namespace AdditionalTasksHomeWork4
{
    internal class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            FirstAdditionalTask(11);
            SecondAdditionalTask();
            ThirdAdditionalTask();
            FourthAdditionalTask();
            FifthAdditionalTask();
            SixAdditionalTask();
            SeventhAdditionalTask();
        }

        public static void FirstAdditionalTask(int n)
        {
            List<int> list = new List<int>() { 0, 1 };
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1) { }
                else
                {
                    int sum = list[i - 1] + list[i - 2];
                    list.Add(sum);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

        }
        public static void SecondAdditionalTask()
        {
            double amount;
            int month;
            while (true)
            {
                Console.Write("Введите сумму вклада: ");
                if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректную сумму");
                }
            }
            while (true)
            {
                Console.Write("Введите количество месяцев: ");
                if (int.TryParse(Console.ReadLine(), out month) && month > 0) { break; }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число месяцев");
                }
            }
            for (int i = 0; i < month; i++)
            {
                double sum = Math.Round((amount * 7) / 100, 2);
                Console.WriteLine($"После {i + 1}-го месяца ваши проценты составят {sum} BYN, а вклад будет насчитывать {Math.Round(amount + sum, 2)} BYN");
                amount += sum;
            }
            Console.WriteLine("По итогу конечная сумма вклада будет равна: " + Math.Round(amount, 2));
        }
        public static void ThirdAdditionalTask()
        {
            Console.WriteLine("Уже было, лежит отдельным проектом в репозитории))");
        }
        public static void FourthAdditionalTask()
        {
            int size;
            while (true)
            {
                Console.Write("Введите размер массива: ");
                if(int.TryParse(Console.ReadLine(), out size) && size > 5 && size <= 10) { break; }
                else
                {
                    Console.WriteLine("Вы ввели не подходящий размер для массива");
                }
            }
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 50);
            }
            int evenNumberCount = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 == 0 && array[i] !=0) 
                {
                    evenNumberCount++;
                }
            }
            int[] evenArr = new int[evenNumberCount];
            for(int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] %2 == 0 && array[i] != 0)
                {
                    evenArr[j] = array[i];
                    j++;
                }
            }

            Console.WriteLine("Первый массив: ");
            PrintArray(array);
            Console.WriteLine("Массив чётных чисел первого массива: ");
            PrintArray(evenArr);
        }
        public static void FifthAdditionalTask()
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            Console.WriteLine("Не изменённый массив: ");
            PrintArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    arr[i] = 0;
                }
            }
            Console.WriteLine("Изменённый массив: ");
            PrintArray(arr);
        }
        public static void SixAdditionalTask()
        {
            string[] arr = new string[] { "Иван", "Евгений", "Святослав", "Марина", "Наталья", "Виктор", "Максим" };
            Console.WriteLine("Массив до сортировки: ");
            PrintArray(arr);
            Array.Sort(arr);
            Console.WriteLine("Массив после сортировки: ");
            PrintArray(arr);
        }
        public static void SeventhAdditionalTask()
        {
            Console.WriteLine("Уже реализовал в проекте MatrixFromPresentationHomeWork4, тоже лежит в отдельном проекте в репозитории))");
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
