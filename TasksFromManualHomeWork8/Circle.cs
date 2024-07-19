using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork8
{
    class Circle : Rectangle
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle()
        {
            R = 12;
        }

        public Circle(double r)
        {
            R = r;
        }

        public override void CalculateSquare()
        {
            Console.WriteLine($"Площадь круга составляет: {Math.Round((Math.PI*Math.Pow(R, 2)),3)}");
        }

        public override void CalculatePerimete()
        {
            Console.WriteLine($"У круга нет периметра, по этому вот вам длинна окружности: {Math.Round((2 * Math.PI * R),3)}");
        }
    }
}
