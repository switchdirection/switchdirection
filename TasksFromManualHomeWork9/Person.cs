using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork9
{
    class Person
    {
        private int _age = 18;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public void Greet()
        {
            Console.WriteLine("Привет!");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст: {Age} лет");
        }

        public void SetAge(int age)
        {
            Age = age;
        }


    }
}
