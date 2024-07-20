namespace TasksFromManualHomeWork9
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();   
            ThirdTask();
        }

        public static void FirstTask()
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            Console.WriteLine("Баланс: ");
            mortgage.PrintBalance();
            mortgage.WaitOneYear();
            Console.WriteLine("Баланс после 1 года: ");
            mortgage.PrintBalance();

            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }
            Console.WriteLine("Баланс после 20 лет: ");
            mortgage.PrintBalance();
        }

        public static void SecondTask()
        {
            Console.WriteLine("Class.Person");
            Person person = new Person();
            person.Greet();
            Console.WriteLine("Class.Student");
            Student student = new Student();
            student.SetAge(17);
            student.Greet();
            student.ShowAge();
            Console.WriteLine("Class.Teacher");
            Teacher teacher = new Teacher();
            teacher.SetAge(32);
            teacher.Greet();
            teacher.Explain();  
        }

        public static void ThirdTask()
        {
            double consump;
            while(true)
            {
                Console.Write("Введте средний расход топлива на 100 километров: ");
                if (double.TryParse(Console.ReadLine(), out consump) && consump > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невозможно заправить машину таким количеством топлива.");
                }
            }
            double distance;
            while (true)
            {
                Console.Write("Введте дистанцию на которую хотите проехать: ");
                if (double.TryParse(Console.ReadLine(), out distance) && distance > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невозможно заправить машину таким количеством топлива.");
                }
            }
            SportsCar car = new SportsCar(0, consump);
            car.Drive(distance);
            car.PrintFuelLeft();
            double fuel;
            while (true)
            {
                Console.Write("Введите количество топлива на которое вы хотите заправить машину: ");
                if(double.TryParse(Console.ReadLine(), out fuel) && fuel > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невозможно заправить машину таким количеством топлива.");
                }
            }
            bool refuel = car.Refuel(fuel);
            Console.WriteLine($"Значение переменной refuel: {refuel}");
            car.Drive(distance);
            car.PrintFuelLeft();
        }
    }
}
