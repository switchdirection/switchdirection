using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdditionalTaskFromManualHomeWork8
{
    internal class MainClass
    {
        public static DateTime curDate = DateTime.Now;
        static void Main(string[] args)
        {
            /* SupplyOfGoods supplyOfGoods = new SupplyOfGoods();
             EmployeeContract employeeContract = new EmployeeContract();
             FinancialInvoice financialInvoice = new FinancialInvoice();
             Register register = new Register();
             register.PrintInfoAboutDocument(supplyOfGoods);
             register.PrintInfoAboutDocument(employeeContract);
             register.PrintInfoAboutDocument(financialInvoice);
             register.SaveDocument(supplyOfGoods);
             register.SaveDocument(employeeContract);
             register.SaveDocument(financialInvoice);
             register.PrintInfoAboutDocumen();*/

            WorkWithRegister();
        }

        public static void WorkWithRegister() 
        {
            
            Register register = new Register();
            Console.Write("Добро пожаловать в систему учёта документов.");
            bool key = true;
            while (key)
            {
                byte choise;
                while (true)
                {
                    Console.Write("Выберите что вы хотите сделать:" +
                        "\n1. Добавить документ в регистр" +
                        "\n2. Просмотреть информацию о документах в регистре" +
                        "\n3. Выход " +
                        "\nВыбор: ");
                    if (byte.TryParse(Console.ReadLine(), out choise) && choise > 0 && choise <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Нет такого варианта.");
                    }
                }
                Console.Clear();
                switch (choise)
                {
                    case 1:
                        {
                            byte choiseDoc;
                            while (true)
                            {
                                Console.Write("Выберите документ который вы хотите создать:" +
                                    "\n1. Контракт на поставку товаров" +
                                    "\n2. Котракт с сотрудником" +
                                    "\n3. Финансовая накладная" +
                                    "\n4. Не создавать документ" +
                                    "\nВыбор: ");
                                if (byte.TryParse(Console.ReadLine(), out choiseDoc) && choiseDoc > 0 && choiseDoc <= 4)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы не можете создать такой документ.");
                                }
                            }
                            Console.Clear();
                            switch (choiseDoc)
                            {
                                case 1:
                                    {
                                        bool addToRegister = AddDocumentToRegister();
                                        Console.Clear();
                                        bool useCon = UseConstructor();
                                        Console.Clear();
                                        if (useCon)
                                        {
                                            int id = new Random().Next();
                                            Console.Write("Введите тип товара: ");
                                            string type = Console.ReadLine();
                                            int amount;
                                            while (true)
                                            {
                                                Console.Write("Введите количество товара: ");
                                                if (int.TryParse(Console.ReadLine(), out amount) && amount > 0)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Вы ввели некорректное количество товара.");
                                                }
                                            }
                                            Console.WriteLine("Введите дату составления договора: \n");
                                            DateOnly date = CreateDate();
                                            SupplyOfGoods supplyOfGoods = new SupplyOfGoods(id, type, amount, date);
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(supplyOfGoods);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                supplyOfGoods.PrintInfo();
                                                Delay();
                                            }

                                        }
                                        else
                                        {
                                            SupplyOfGoods supplyOfGoods = new SupplyOfGoods();
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(supplyOfGoods);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                supplyOfGoods.PrintInfo();
                                                Delay();
                                            }
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        bool addToRegister = AddDocumentToRegister();
                                        Console.Clear();
                                        bool useCon = UseConstructor();
                                        Console.Clear();
                                        if (useCon)
                                        {
                                            int id = new Random().Next();
                                            Console.WriteLine("Введите дату составления договора: ");
                                            DateOnly date = CreateDate();
                                            Console.WriteLine();
                                            Console.WriteLine("Введите дату вступления договора в силу: ");
                                            DateOnly startDate = CreateDate();
                                            Console.WriteLine();
                                            Console.WriteLine("Введите дату когда договор перестанет работать: ");
                                            DateOnly endDate = CreateDate();
                                            Console.WriteLine();
                                            string name = CreateName() ;
                                            EmployeeContract employeeContract = new EmployeeContract(id, date, startDate, endDate, name);
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(employeeContract);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                employeeContract.PrintInfo();
                                                Delay();
                                            }

                                        }
                                        else
                                        {
                                            EmployeeContract employeeContract = new EmployeeContract();
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(employeeContract);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                employeeContract.PrintInfo();
                                                Delay();
                                            }
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        bool addToRegister = AddDocumentToRegister();
                                        Console.Clear();
                                        bool useCon = UseConstructor();
                                        Console.Clear();
                                        if (useCon)
                                        {
                                            int id = new Random().Next();
                                            Console.WriteLine("Введите дату составления договора: \n");
                                            DateOnly date = CreateDate();
                                            int departmentCode = new Random().Next();
                                            decimal amount;
                                            while (true)
                                            {
                                                Console.Write("Введите итоговую сумму за месяц: ");
                                                if(decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Вы ввели некорректную итоговую сумму за месяц.");
                                                }
                                            }
                                            FinancialInvoice financialInvoice = new FinancialInvoice(amount, id, date, departmentCode);
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(financialInvoice);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                financialInvoice.PrintInfo();
                                                Delay();
                                            }

                                        }
                                        else
                                        {
                                            FinancialInvoice financialInvoice = new FinancialInvoice();
                                            if (addToRegister)
                                            {
                                                register.SaveDocument(financialInvoice);
                                                Delay();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Так как вы не добавляете документ в регистр, инфорацию о нём вы можете просмотреть только сейчас.\n");
                                                financialInvoice.PrintInfo();
                                                Delay();
                                            }
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        break;
                                    }
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            register.PrintInfoAboutDocument();
                            Delay();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Спасибо за использование нашей системы учёта документов, всего хорошего!");
                            key = false;
                            break;
                        }
                }
            }
           
        }

        public static bool AddDocumentToRegister()
        {
            byte add;
            while(true)
            {
                Console.Write("Хотите ли вы добавить документ в регистр?" +
                    "\n1. Да" +
                    "\n2. Нет" +
                    "\nВыбор: ");
                if(byte.TryParse(Console.ReadLine(), out add) &&  add > 0 && add <= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Нет такого варианта выбора.");
                }
            }
            if(add == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UseConstructor()
        {
            byte useCon;
            while (true)
            {
                Console.Write("Хотите ли вы сами ввести данные в документ?" +
                    "\n1. Да" +
                    "\n2. Нет" +
                    "\nВыбор: ");
                if (byte.TryParse(Console.ReadLine(), out useCon) && useCon > 0 && useCon <= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Нет такого варианта выбора.");
                }
            }
            if (useCon == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DateOnly CreateDate()
        {
            int year, month, day;
            while (true)
            {
                Console.Write("Введите год: ");
                if (int.TryParse(Console.ReadLine(), out year) && year > curDate.Year-30 && year <= curDate.Year + 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы неккоректно ввели год.");
                }
            }
            while (true)
            {
                Console.Write("Введите месяц: ");
                if (int.TryParse(Console.ReadLine(), out month) && month > 0 && month <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы неккоректно ввели месяц.");
                }
            }
            int daysInMoth = DateTime.DaysInMonth(year, month);
            while (true)
            {
                Console.Write("Введите количество дней в месяце: ");
                if (int.TryParse(Console.ReadLine(), out day) && day > 0 && day <= daysInMoth)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы неккоректно количество дней в месяце.");
                }
            }
            DateOnly date = new DateOnly(year, month, day);
            return date;
        }

        public static string CreateName()
        {
            string name;
            while (true)
            {
                Console.Write("Введите имя сотрудника: ");
                name = Console.ReadLine();
                bool digitOrWhiteSpace = false;
                foreach(var ch in name)
                {
                    if (char.IsDigit(ch) || ch == ' ')
                    {
                        digitOrWhiteSpace = true;
                    }
                }
                if (digitOrWhiteSpace || name == null || name == string.Empty)
                {
                    Console.WriteLine("Вы некорректно ввели имя.");
                }
                else
                {
                    break;
                }
            }
         
            return name;
        }
        public static void Delay()
        {
            Console.Write("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
