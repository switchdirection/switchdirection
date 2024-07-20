using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskFromManualHomeWork8
{
    class EmployeeContract : Document
    {
		private int _id;
		private DateOnly _date;
		private DateOnly _startDate;
		private DateOnly _endDate;
		private string _name;

        public string Name 
		{
			get { return _name; }
			set { _name = value; }
		}

        public DateOnly EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public DateOnly StartDate
		{
			get { return _startDate; }
			set { _startDate = value; }
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

		public EmployeeContract()
		{
			Id = new Random().Next();
			Date = new DateOnly(2022, 11, 9);
			StartDate = new DateOnly(2023, 11, 9);
			EndDate = new DateOnly(2033, 11, 9);
			Name = "Victor";
		}

		public EmployeeContract(int id, DateOnly date, DateOnly startDate, DateOnly endDate, string name)
		{
			Id = id;
			Date = date;
			StartDate = startDate;
			EndDate = endDate;
			Name = name;
		}

        public override void PrintInfo()
        {
            Console.WriteLine("Информация о контракте с сотрудника: " +
				$"\nId документа: {Id}" +
				$"\nДата заключения документа: {Date}" +
				$"\nДата вступления договора в силу: {StartDate}" +
				$"\nДата завершения работы договора: {EndDate}" +
				$"\nИмя сотрудника с кем заключен договор: {Name}\n");
        }
    }
}
