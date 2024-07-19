using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork8
{
    class Accountant : IInfo
    {
        private string _rank = "Бухгалтер";

        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[Class.Accountant] Моя должность: {Rank}");
        }
    }
}
