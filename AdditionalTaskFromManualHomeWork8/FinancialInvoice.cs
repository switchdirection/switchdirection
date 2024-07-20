using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskFromManualHomeWork8
{
    class FinancialInvoice : Document
    {

		private decimal _totalAmountPerMonth;
		private int _id;
		private DateOnly _date;
		private int _departmentCode;

		public int DepartmentCode
		{
			get { return _departmentCode; }
			set { _departmentCode = value; }
		}


		public DateOnly Date
		{
			get { return _date; }
			set { _date = value; }
		}


		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public decimal TotalAmountPerMonth
		{
			get { return _totalAmountPerMonth; }
			set { _totalAmountPerMonth = value; }
		}

		public FinancialInvoice()
		{
			TotalAmountPerMonth = 250;
			Id = new Random().Next();
			Date = new DateOnly(2024, 2, 25);
			DepartmentCode = new Random().Next();
		}
		public FinancialInvoice(decimal totalAmountPerMonth, int id, DateOnly date, int departmentCode)
		{
			TotalAmountPerMonth = totalAmountPerMonth;
			Id = id;
			Date = date;
			DepartmentCode = departmentCode;
		}

        public override void PrintInfo()
        {
            Console.WriteLine("Информация о финансовой накладной: " +
				$"\nИтоговая сумма за месяц: {TotalAmountPerMonth} BYN" +
				$"\nId документа: {Id}" +
				$"\nДата заключения документа: {Date}" +
				$"\nКод департамента: {DepartmentCode}\n");
        }
    }
}
