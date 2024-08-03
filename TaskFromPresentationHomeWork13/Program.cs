using System.Text.Json;

namespace TaskFromPresentationHomeWork13
{
    public class Peson 
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeJSON();
        }

        public static void SerializeJSON()
        {
            string directory = FindDerictorty();
            string fullPath = GetFullPathToFile(directory);
            string json = File.ReadAllText(fullPath);   
            var personJson = JsonSerializer.Deserialize<Peson>(json);
            Console.WriteLine("Имя: " + personJson.Name);

        }

        public static string FindDerictorty()
        {
            while(true)
            {
                string path = string.Empty;
                Console.Write("Введите путь к папке (Пример: D:\\): ");
                path = Console.ReadLine();
                if (Directory.Exists(path))
                {
                    return path;
                }
                else
                {
                    Console.WriteLine("Введённой директории не существует.");
                }
            }
            
        }

        public static string GetFullPathToFile(string path)
        {
            string[] fileNames = Directory.GetFiles(path);
            Console.WriteLine("Файлы находящиеся в этой директории: ");
            for(int i = 0; i < fileNames.Length; i++) 
            {
                Console.WriteLine($"{i+1}. {fileNames[i]}");
            }
            while (true)
            {
                string file = string.Empty;
                Console.Write("Введите полное имя файла в формате .json: ");
                file = Console.ReadLine();
                if(File.Exists(path + file) && file.Contains(".json")) { return path + file; }
                else
                {
                    Console.WriteLine("Вы ввели некорректное название файла, или ввели файл не того формата.");
                }
            }
        }
    }
}
