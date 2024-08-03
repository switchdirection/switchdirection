using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AdditionTaskFromPresentationHomeWork13
{
    public class SuperHeroSquad
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }

        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }

        [JsonPropertyName("formed")]
        public int Formed { get; set; }

        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("members")]
        public List<SuperHero> Members { get; set; }
    }

    public class SuperHero
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }

        [JsonPropertyName("powers")]
        public List<string> Powers { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullPath = "D:\\Superherosquad.json";
            string json = File.ReadAllText(fullPath);
            var squadJson = JsonSerializer.Deserialize<SuperHeroSquad>(json);
            Console.WriteLine($"SquadName: {squadJson.SquadName}" +
                $"\nHomeTown: {squadJson.HomeTown}" +
                $"\nFormed: {squadJson.Formed}" +
                $"\nSecretBase: {squadJson.SecretBase}" +
                $"\nActtive: {squadJson.Active}" +
                $"\nMembers: ");
            foreach(SuperHero hero in  squadJson.Members)
            {
                Console.WriteLine($"  Name: {hero.Name}" +
                    $"\n  Age: {hero.Age}" +
                    $"\n  SecretIdenty: {hero.SecretIdentity}" +
                    $"\n  Powers: ");
                foreach(string power in hero.Powers)
                {
                    Console.WriteLine("    "+power);
                }
            }

            XmlSerializer xmlser = new XmlSerializer(typeof(SuperHeroSquad));
            Stream serialStream = new FileStream("superherosquad.xml", FileMode.Create);

            xmlser.Serialize(serialStream, squadJson);
            Console.WriteLine("Xml файл успешно создан");

        }
    }
}
