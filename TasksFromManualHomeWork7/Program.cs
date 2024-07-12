namespace TasksFromManualHomeWork7
{
    internal class Computer
    {
        private decimal _price;
        private string _model;
        private RAM _ram;
        private HDD _hdd;

        public decimal Price { get { return _price; } set { _price = value; } }
        public string Model{ get { return _model; } set { _model = value; } }
        public RAM RAM { get { return _ram; } set { _ram = value; } }
        public HDD HDD { get { return _hdd; } set { _hdd = value; } }

        public Computer(decimal price, string model)
        {
            Price = price; 
            Model = model;
            RAM = new RAM();
            HDD = new HDD();
        }

        public Computer(decimal price, string model, RAM ram, HDD hdd) 
        {
            Price = price;
            Model = model;
            RAM = ram;
            HDD = hdd;
        }

        public void PrintInfoAboutComputer()
        {
            Console.WriteLine($"Информация о компьютере: " +
                $"\nЦена компьютера: {this.Price} BYN" +
                $"\nМодель компьюетра: {this.Model}" +
                $"\nОперативная память: " +
                $"\n\tНазвание: {this.RAM.Name}" +
                $"\n\tОбъём: {this.RAM.Volume} МБ" +
                $"\nЖёсткий диск: " +
                $"\n\tНазвание: {this.HDD.Name}" +
                $"\n\tОбъём: {this.HDD.Volume} МБ" +
                $"\n\tТип: {this.HDD.PType}\n\n");
        }

    }

    internal class RAM
    {
        private string _name;
        private decimal _volume;

        public string Name { get { return _name; } set { _name = value; } }
        public decimal Volume { get { return _volume; } set { _volume = value; } }

        public RAM()
        {
            _name = "Kingston SODIMM DDR4";
            _volume = 8192;
        }

        public RAM(string name, decimal volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    internal class HDD
    {
        private string _name;
        private decimal _volume;
        private Type _type;

        public string Name { get{ return _name; } set { _name = value; } }

        public decimal Volume { get { return _volume; } set { _volume = value; } }
        public Type PType { get { return _type; } set { _type = value; } }

        public HDD()
        {
            Name = "Seagate Barracuda ST2000DM008";
            Volume = 2000000;
            PType = Type.Interior;
        }

        public HDD(string name, decimal volume, Type type)
        {
            Name = name;
            Volume = volume;
            PType = type;
        }
    }

    enum Type
    {
        Interior = 1,
        External = 2
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer(2800, "New model");
            Computer computer2 = new Computer(3200, "One more new model", new RAM("Kingston", 16384), new HDD("Seagate", 4000000, Type.External));
            computer1.PrintInfoAboutComputer();
            computer2.PrintInfoAboutComputer();

            ATM atm = new ATM();
            atm.WithdrawMoneyFromAnATM(245);
            atm.PrintInfo();
        }
    }
}
