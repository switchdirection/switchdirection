using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork9
{
    class Debt
    {
		private double _balance;
		private double _interestRate;

		public double InterestRate
		{
			get { return _interestRate; }
			set { _interestRate = value; }
		}

		public double Balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

		public Debt(double balance, double interestRate)
		{
			Balance = balance;
			InterestRate = interestRate;
		}

		public void PrintBalance()
		{
            Console.WriteLine($"Баланс составляет: {Balance}");
        }

		public void WaitOneYear()
		{
			Balance *= InterestRate;
		}

	}
}
