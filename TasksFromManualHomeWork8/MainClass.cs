namespace TasksFromManualHomeWork8
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        static void FirstTask()
        {
            Figures[] figures = new Figures[] { new Triangle(), new Rectangle(), new Circle(), new Rectangle(13, 22, 13, 22), new Circle(7) };
            foreach (Figures f in figures)
            {
                f.CalculateSquare();
                f.CalculatePerimete();
                Console.WriteLine();
            }
        }

        static void SecondTask()
        {
            CEO ceo = new CEO();
            Accountant accountant = new Accountant();
            Employee employee = new Employee();
            ceo.PrintInfo();
            accountant.PrintInfo();
            employee.PrintInfo();
        }
    }
}
