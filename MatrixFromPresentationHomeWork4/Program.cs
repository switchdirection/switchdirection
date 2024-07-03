namespace MatrixFromPresentationHomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            while (true)
            {
                Console.Write("Введите количество строк: ");
                if (int.TryParse(Console.ReadLine(), out rows) && rows > 0) { break; }
                else
                {
                    Console.WriteLine("Вы ввели некорректное количество строк");
                }
            }
            while (true)
            {
                Console.Write("Введите количество столбцов: ");
                if (int.TryParse(Console.ReadLine(), out columns) && columns > 0) { break; }
                else
                {
                    Console.WriteLine("Вы ввели некорректное количество столбцов");
                }
            }
            int[,] array = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    while (true)
                    {
                        Console.Write($"array[{i}][{j}] = ");
                        int number;
                        if(int.TryParse(Console.ReadLine(), out number)) { array[i, j] = number; break; }
                        else
                        {
                            Console.WriteLine("Вы ввели не число.");
                        }
                    }
                }
            }
            Console.WriteLine();
            PrintMatrix(array);
            Console.WriteLine();
            FindPositivAndNegativeNumbers(array);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Выберите способ сортировки (1-По возрастанию/2-По убыванию): ");
                int choice;
                if(int.TryParse(Console.ReadLine(), out choice) && choice >=1 && choice <= 1) { }
                else
                {
                    Console.WriteLine("Нет такого выбора.");
                }
                switch(choice) 
                {
                    case 1:
                        {
                            Console.WriteLine("Отсортированная матрица: ");
                            AscendingSort(array);
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Отсортированная матрица: ");
                            DescendingSort(array);
                            Console.WriteLine();
                            break;
                        }
                }
                break;
            }
            Console.WriteLine("Инвертированная матрица: ");
            MatrixInversion(array);
        }

        public static void FindPositivAndNegativeNumbers(int[,] arr)
        {
            int positive = 0, negative = 0;
            for(int i = 0; i < arr.GetLength(0); i++) 
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] >= 0)
                    {
                        positive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
            }
            Console.WriteLine("Позитивные: " + positive + "\nОтрицательные: " + negative);
        }

        public static void AscendingSort(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int k = 0;
                while(k < arr.GetLength(1))
                {
                    for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, j + 1];
                            arr[i, j + 1] = temp;
                        }
                    }
                    k++;
                }
                
            }
            PrintMatrix(arr);
        }
        public static void DescendingSort(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int k = 0;
                while (k < arr.GetLength(1))
                {
                    for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    {
                        if (arr[i, j] < arr[i, j + 1])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, j + 1];
                            arr[i, j + 1] = temp;
                        }
                    }
                    k++;
                }

            }
            PrintMatrix(arr);
        }

        public static void MatrixInversion(int[,] arr)
        {
            int length = arr.GetLength(1);
            int middle = arr.GetLength(1) / 2;
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j<middle; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, length - j - 1];
                    arr[i, length - j - 1] = temp;
                }
            }
            PrintMatrix(arr);
            
        }

        public static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
