namespace AdditionalTasksFromManualHomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckWordLengthInTheString();
            FindWordWithMinUniqueChars();
            CheckPalindrom();
            DublicateCharsInTheString();
        }

        public static void CheckWordLengthInTheString()
        {
            Console.Write("Введите строку: ");
            var text = Console.ReadLine();
            var words = text.Split(' ');
            string minLength = words[0], maxLength = words[0];
            foreach(var word in words)
            {
                if(word.Length > maxLength.Length)
                {
                    maxLength = word;
                }

                if(word.Length < minLength.Length)
                {
                    minLength = word;
                }
            }
            Console.WriteLine($"Слово минимальной длинны: {minLength}\nСЛово максимальной длинны: {maxLength}");
        }

        public static void FindWordWithMinUniqueChars()
        {
            Console.Write("Введите строку: ");
            var text = Console.ReadLine();
            var words = text.Split(' ');
            string minWord = words[0];
            int minUniqueChars = CountUniqueChars(minWord);

            foreach (string word in words)
            {
                int uniqueChars = CountUniqueChars(word);
                if (uniqueChars < minUniqueChars)
                {
                    minUniqueChars = uniqueChars;
                    minWord = word;
                }
            }

            Console.WriteLine($"Слово с минимальным числом различных символов: {minWord}");
        }

        public static int CountUniqueChars(string word)
        {
            HashSet<char> uniqueChars = new HashSet<char>(word);
            return uniqueChars.Count;
        }

        public static void CheckPalindrom()
        {
            Console.Write("Введите строку: ");
            var text = Console.ReadLine();
            var words = text.ToLower().Split(' ');
            int index;
            while (true)
            {
                Console.Write("Выберите слово которое хотите проверить: ");
                if (int.TryParse(Console.ReadLine(), out index) && index>0 && index <= words.Length) 
                { 
                    break;
                }
                else
                {
                    Console.WriteLine("Введённое число не корректно.");
                }
            }

            string word = words[index-1];
            bool polindrom = true;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    polindrom = false;
                    break;
                }
            }

            if( polindrom )
            {
                Console.WriteLine("Слово является полиндромом");
            }
            else
            {
                Console.WriteLine("Слово не является полиндромом");
            }
            
        }

        public static void DublicateCharsInTheString()
        {
            Console.Write("Введите строку: ");
            var text = Console.ReadLine();
            string resultString = string.Empty;
            foreach(char letter in text)
            {
                //Либо так
                /*resultString += letter;
                resultString += letter;*/

                //Либо так, результат одинаковый, не понимаю просто что будет лучше в данном случае, что эффективнее использовать
                for (int i = 0; i < 2; i++)
                {
                    resultString+=letter;
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
