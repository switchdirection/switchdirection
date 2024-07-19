namespace TasksFromManualHomeWork6_7
{
    internal class Phone
    {
        private string _number;
        private string _model;
        private double _weight;

        public string Number
        {
            get
            {
                return _number;
            }
            private set
            {
                _number = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            private set
            {
                _model = value;
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            private set
            {
                _weight = value;
            }
        }

        public Phone()
        {
            Number = "+375(29)534-24-12";
            Model = "Samsung A15";
            Weight = 240.0;
        }

        public Phone(string number, string model)
        {
            Number = number;
            Model = model;
            Weight = 200.0;
        }

        public Phone(string number, string model, double weight) : this(number, model)
        {
            Weight = weight;
        }

        public void setNumber(string number)
        {
            Number = number;
        }

        public void setModel(string model)
        {
            Model = model;
        }

        public void setWeight(double weight)
        {
            Weight = weight;
        }

        public string getNumber()
        {
            return Number;
        }

        public void recieveCall(string name)
        {
            Console.WriteLine($"Звонит: {name}\n");
        }
        public void recieveCall(string number, string name)
        {
            Console.WriteLine($"Звонит: {name}\nНомер телефона: {number}\n");
        }

        public void sendMessage(params string[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Нет номер на которые можно отправить сообщение.\n");
            }
            else
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine($"С номера {this.Number} было отправленно сообщение на номер: {number}");
                }
                Console.WriteLine();
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Номер телеофна: {Number}\nМодель телефона: {Model}\nВес телефона: {Weight}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Phone phone1 = new Phone("+375(44)682-42-54", "Apple Iphone 14");
            Phone phone2 = new Phone("+375(33)512-53-12", "Xiami Redme 11 Note", 190.5);
            string phoneNumber = phone.getNumber();
            string phoneNumber1 = phone1.getNumber();
            string phoneNumber2 = phone2.getNumber();
            ConsoleToRed();
            Console.WriteLine("Звонок на phone:");
            phone.recieveCall("Иван");
            Console.WriteLine("Звонок на phone1:");
            phone.recieveCall("Степан");
            Console.WriteLine("Звонок на phone2:");
            phone.recieveCall("Елена");
            ConsoleToWhite();
            ConsoleToGreen();
            Console.WriteLine($"Номер телефона phone: {phoneNumber}\nНомер телефона phone2: {phoneNumber1}\nНомер телефона phone2: {phoneNumber2}");
            ConsoleToWhite();
            Console.WriteLine("\nИнформация о телефонах: \n");
            ConsoleToRed();
            phone.PrintInfo();
            phone1.PrintInfo();
            phone2.PrintInfo();
            ConsoleToWhite();
            ConsoleToGreen();
            Console.WriteLine("Перегруженный звонок на phone: \t");
            phone.recieveCall("+375(44)231-31-32", "Иван");
            Console.WriteLine("Перегруженный звонок на phone: \t");
            phone.recieveCall("+375(44)231-31-51", "Степан");
            Console.WriteLine("Перегруженный звонок на phone: \t");
            phone.recieveCall("+375(44)231-44-41", "Елена");
            ConsoleToWhite();
            Console.WriteLine("Отправка сообщений: ");
            ConsoleToRed();
            Console.WriteLine("Отправка с телефона phone: ");
            phone.sendMessage();
            Console.WriteLine("Отправка с телефона phone1: ");
            phone1.sendMessage("+375(29)512-56-65", "+375(44)581-53-18");
            Console.WriteLine("Отправка с телефона phone2: ");
            phone2.sendMessage("+375(29)512-56-65", "+375(44)581-53-18", "+375(29)588-97-09", "+375(44)194-44-54");
            ConsoleToWhite();
        }

        static void ConsoleToGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void ConsoleToRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void ConsoleToWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
