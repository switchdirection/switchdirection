namespace AdditionalTasksFromManualHomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckWordLengthInTheString();
        }

        public static void CheckWordLengthInTheString()
        {
            Console.WriteLine("Введите строку: ");
            var text = Console.ReadLine();
            string minLength = string.Empty, maxLength = string.Empty;
            foreach(var c in text)
            {
                Console.WriteLine(c);
            }
        }
    }
}
