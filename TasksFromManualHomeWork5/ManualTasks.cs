using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork5
{
    internal class ManualTasks
    {
        public static void EightFirstDigit(string str)
        {
            string eightFirstDigits = string.Empty;
            foreach (char c in str)
            {
                if (char.IsDigit(c) && eightFirstDigits.Length < 8)
                {
                    eightFirstDigits += c;
                }
            }
            Console.WriteLine(eightFirstDigits);
        }

        public static void ReplaceLetters(string str)
        {
            string replaceLetters = string.Empty;
            string[] temp = str.Split("-");
            for (int i = 0; i < temp.Length; i++)
            {
                if (int.TryParse(temp[i], out var val))
                {

                    continue;
                }
                else if (temp[i].Length == 3)
                {
                    temp[i] = "***";
                }
            }
            replaceLetters = string.Join("-", temp);
            Console.WriteLine(replaceLetters);
        }

        public static void LowerCaseLettersInFormat(string str)
        {
            string lowerCaseLetters = string.Empty;
            string[] temp2 = str.Split("-");
            for (int i = 0; i < temp2.Length; i++)
            {
                if (int.TryParse(temp2[i], out var val))
                {
                    continue;
                }
                else
                {
                    foreach (char c in temp2[i])
                    {
                        if (char.IsDigit(c))
                        {
                            temp2[i] = temp2[i].Replace(c, ' ');
                        }

                    }
                    temp2[i] = temp2[i].Trim();
                    lowerCaseLetters += temp2[i] + "/";
                }
            }
            lowerCaseLetters = lowerCaseLetters.Replace(' ', '/');
            lowerCaseLetters = lowerCaseLetters.Remove(lowerCaseLetters.Length - 1);
            Console.WriteLine(lowerCaseLetters.ToLower());
        }

        public static void UpperCaseLettersInFormat(string str)
        {
            string lowerCaseLetters = string.Empty;
            string[] temp2 = str.Split("-");
            for (int i = 0; i < temp2.Length; i++)
            {
                if (int.TryParse(temp2[i], out var val))
                {
                    continue;
                }
                else
                {
                    foreach (char c in temp2[i])
                    {
                        if (char.IsDigit(c))
                        {
                            temp2[i] = temp2[i].Replace(c, ' ');
                        }

                    }
                    temp2[i] = temp2[i].Trim();
                    lowerCaseLetters += temp2[i] + "/";
                }
            }
            lowerCaseLetters = lowerCaseLetters.Replace(' ', '/');
            lowerCaseLetters = lowerCaseLetters.Remove(lowerCaseLetters.Length - 1);
            StringBuilder sb = new StringBuilder(lowerCaseLetters);
            Console.WriteLine(sb.ToString().ToUpper());
        }

        public static void CheckIfTheStringContainsTheSequence(string str)
        {
            string temp = str.ToLower();
            bool contains = temp.Contains("abc");
            if (contains)
            {
                Console.WriteLine("Содержит последовательность ABC или abc");
            }
            else
            {
                Console.WriteLine("Не содержит последовательность ABC или abc");
            }
        }

        public static void CheckIfAStringStartingWithASequence(string str)
        {
            bool startWith = str.StartsWith("555");
            if (startWith)
            {
                Console.WriteLine("Номер начинается с 555");
            }
            else 
            { 
                Console.WriteLine("Номер не начинается с 555");
            }
        }
        public static void CheckIfAStringEndsWithASequence(string str)
        {
            bool endsWith = str.EndsWith("1a2b");
            if (endsWith)
            {
                Console.WriteLine("Строка заканчивается на 1a2b");
            }
            else
            {
                Console.WriteLine("Строка не заканчивается на 1a2b");
            }
        }
    }
}
