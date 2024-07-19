using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork8
{
    class Employee : IInfo
    {
        private string _rank = "Работник";

        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        } 

        public void PrintInfo()
        {
            Console.WriteLine($"[Class.Employee] Моя должность: {Rank}");
        }
    }
}
