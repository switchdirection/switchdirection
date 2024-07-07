namespace TasksFromPresentationHomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = string.Empty;
            byte choiseRead;
            while (true)
            {
                Console.Write("Выберить метод ввода текст: " +
                "\n1. С консоли" +
                "\n2. Из файла" +
                "\nВыбор: ");
                if(byte.TryParse(Console.ReadLine(), out choiseRead) && choiseRead > 0 && choiseRead <=2) 
                {
                    Console.Clear();
                    break;  
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Нет такого метода ввода");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            if(choiseRead == 1)
            {
                Console.Write("Введите текст: ");
                text = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ваш текст:" +
                    "\n" + text);
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (choiseRead == 2)
            {
                text = ReadTextFromFile();
                Console.Clear();
                Console.WriteLine("Ваш текст:" +
                    "\n" + text);
                Thread.Sleep(3000);
                Console.Clear();
            }
            //На всякий случай)
            else
            {
                Console.WriteLine("Метод ввода не был определён");
                return;
            }
            bool key = true;
            while (key)
            {
                Console.Write("\t\t\tМеню выбора" +
                "\n1. Найти слова, содержащие максимальное количество цифр" +
                "\n2. Найти самое длинное слово и определить, сколько раз оно встречалось в тексте" +
                "\n3. Заменить цифры от 0 до 9 на слова 'ноль', 'один', ..., 'девять'" +
                "\n4. Вывести на экран сначала вопросительные, а затем восклицательные предложения" +
                "\n5. Вывести на экран только предложения, не содержащие запятые" +
                "\n6. Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву" +
                "\n7. Изменить путь к файлу" +
                "\n8. Напомнить введённый вами текст" +
                "\n9. Выход" +
                "\nВыбор: ");
                byte choise;
                while (true)
                {
                    if (byte.TryParse(Console.ReadLine(), out choise) && choise > 0 && choise <= 9)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Нет такого выбора.");
                    }
                }
                switch (choise)
                {
                    case 1:
                        {
                            Console.Clear();
                            var words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                            List<string> wordsWithNumbers = new List<string>();
                            int maxCountOfNumbersInWord = 0;
                            for(int i = 0; i < words.Length; i++)
                            {
                                int numbersInWord = 0;
                                foreach(var c in words[i])
                                {
                                    if (char.IsDigit(c))
                                    {
                                        numbersInWord++;
                                    }
                                }
                                if(maxCountOfNumbersInWord< numbersInWord)
                                {
                                    maxCountOfNumbersInWord = numbersInWord;
                                }
                            }
                            for(int i = 0; i < words.Length; i++)
                            {
                                int numbersInWord = 0;
                                foreach (var c in words[i])
                                {
                                    if (char.IsDigit(c))
                                    {
                                        numbersInWord++;
                                    }
                                }
                                if(numbersInWord == maxCountOfNumbersInWord)
                                {
                                    wordsWithNumbers.Add(words[i]);
                                }
                            }

                            Console.Write("Слова в которых максимальное количество цифр: ");
                            foreach (var c in wordsWithNumbers)
                            {
                                Console.Write(c + " ");
                            }
                            Thread.Sleep(3000);
                            Console.Clear();

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            var words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                            var wordWithMaxLength = words[0];
                            foreach(var word in words)
                            {
                                if(word.Length > wordWithMaxLength.Length)
                                {
                                    wordWithMaxLength = word;
                                }
                            }
                            int countWordWithMaxLength = 0;
                            foreach (var word in words)
                            {
                                if (word.Length == wordWithMaxLength.Length)
                                {
                                    countWordWithMaxLength++;
                                }
                            }
                            Console.WriteLine($"Самое длинное слово: {wordWithMaxLength}\nСколько раз оно встречалось в тексте: {countWordWithMaxLength}");
                            Thread.Sleep(3000);
                            Console.Clear();

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            string words = string.Empty;
                            for(int i = 0; i < text.Length; i++)
                            {
                                if (char.IsDigit(text[i]))
                                {
                                    switch (text[i])
                                    {
                                        case '0':
                                            {
                                                words += "ноль";
                                                break;
                                            }
                                        case '1':
                                            {
                                                words += "один";
                                                break;
                                            }
                                        case '2':
                                            {
                                                words += "два";
                                                break;
                                            }
                                        case '3':
                                            {
                                                words += "три";
                                                break;
                                            }
                                        case '4':
                                            {
                                                words += "четыре";
                                                break;
                                            }
                                        case '5':
                                            {
                                                words += "пять";
                                                break;
                                            }
                                        case '6':
                                            {
                                                words += "шесть";
                                                break;
                                            }
                                        case '7':
                                            {
                                                words += "семь";
                                                break;
                                            }
                                        case '8':
                                            {
                                                words += "восемь";
                                                break;
                                            }
                                        case '9':
                                            {
                                                words += "девять";
                                                break;
                                            }
                                    }
                                }
                                else
                                {
                                    words += text[i];
                                }
                            }
                            Console.WriteLine("Ваш текст: \n" + words);
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            List<string> sentences = new List<string>();
                            string sentence = string.Empty;
                            foreach(char c in text)
                            {
                                sentence += c;
                                if(c == '!' || c == '?' || c == '.')
                                {
                                    if (!string.IsNullOrWhiteSpace(sentence))
                                    {
                                        sentences.Add(sentence.Trim());
                                        sentence = string.Empty;
                                    }
                                }
                            }
                            Console.WriteLine("Восклицательные предложения: ");
                            foreach (var sen in sentences) 
                            {
                                if (sen.EndsWith('!'))
                                {
                                    Console.WriteLine(sen);
                                }
                            }
                            Console.WriteLine("Вопросительные предложения: ");
                            foreach (var sen in sentences)
                            {
                                if (sen.EndsWith('?'))
                                {
                                    Console.WriteLine(sen);
                                }
                            }
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            List<string> sentences = new List<string>();
                            string sentence = string.Empty;
                            foreach (char c in text)
                            {
                                sentence += c;
                                if (c == '!' || c == '?' || c == '.')
                                {
                                    if (!string.IsNullOrWhiteSpace(sentence))
                                    {
                                        sentences.Add(sentence.Trim());
                                        sentence = string.Empty;
                                    }
                                }
                            }
                            Console.WriteLine("Предложения которые не содержат запятых: ");
                            foreach (var sen in sentences)
                            {
                                bool contains = sen.Contains(',');
                                if (contains)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine(sen);
                                }
                            }
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            var words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                            List<string> wordsWithSameFirstAndLastLetter = new List<string>();
                            foreach (var word in words)
                            {
                                if (word.StartsWith(word[0]) && word.EndsWith(word[0]) && word.Length > 1)
                                {
                                    wordsWithSameFirstAndLastLetter.Add(word);
                                }
                            }
                            Console.WriteLine("Слова которые начинаеются и заканчиваются на одну букву: ");
                            foreach(var word in wordsWithSameFirstAndLastLetter)
                            {
                                Console.WriteLine(word + " ");
                            }
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            if(choiseRead == 1)
                            {
                                Console.WriteLine("Вы вводили текст с консоли, вам ни к чему менять путь к файлу)");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            text = ReadTextFromFile();
                            Console.Clear();
                            Console.WriteLine("Ваш текст:" +
                                "\n" + text);
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Ваш текст: ");
                            Console.WriteLine(text);
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("Пока пока)");
                            Thread.Sleep(3000);
                            key = false;
                            break;
                        }
                }
            }
            
        }

        public static string ReadTextFromConsole()
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            return text;
        }
        public static string ReadTextFromFile()
        {
            string line;
            string text = string.Empty;

            try
            {
                Console.Write("Введите путь к файлу в формате 'C:\\\\Sample.txt': ");
                var path = Console.ReadLine();
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    text+= line;
                    line = sr.ReadLine();
                }
                sr.Close();
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;

        }
    }
}
