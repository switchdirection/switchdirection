using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskFromManualHomeWork8
{
    class Register
    {
        private Document[] _documents;

        public Document[] Documents
        {
            get { return _documents; }
            set { _documents = value; }
        }

        public Register()
        {
            Documents = new Document[10];
        }

        public void SaveDocument(Document document)
        {
            for(int i = 0; i < Documents.Length; i++)
            {
                if (Documents[i] == null)
                {
                    Console.WriteLine("Документ был успешно добавлен в регистр.\n");
                    Documents[i] = document;
                    return;
                }
            }
            Console.WriteLine("Вы больше не можете добавить документ в регист, место кончилось.");
            return;
        }

        public void PrintInfoAboutDocument()
        {
            if (Documents[0] == null)
            {
                Console.WriteLine("Регистр пуст.");
                return;
            }
            Console.WriteLine("Вывод информации о документах из регистра: ");
            foreach (Document doc in Documents)
            {
                if(doc != null)
                {
                    doc.PrintInfo();
                }
            }
        }
        public void PrintInfoAboutDocument(SupplyOfGoods supplyOfGoods)
        {
            supplyOfGoods.PrintInfo();
        }
        public void PrintInfoAboutDocument(EmployeeContract employeeContract)
        {
            employeeContract.PrintInfo();
        }
        public void PrintInfoAboutDocument(FinancialInvoice financialInvoice)
        {
            financialInvoice.PrintInfo();
        }
    }
}
