namespace TaskFromPresentationHomeWork8
{
    abstract class Animal
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void setName(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public abstract void Eat();

    }

    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("Собака ест.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            while (true)
            {
                Console.Write("Введте имя для собачки: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Вы ввели неккоректное имя.");
                }
                else
                {
                    break;
                }
            }

            Dog dog = new Dog(name);
            string oldName = dog.getName();
            dog.setName("Muha");
            string newName = dog.getName();
            dog.setName(oldName);
            dog.Eat();
            Console.WriteLine($"Имя которое вы ввели для собаки: {oldName}" +
                $"\nНовое имя для собаки которое было изменено используя setName: {newName}");

        }
    }
}