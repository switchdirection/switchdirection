using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork8
{
    class Rectangle : Triangle
    {
        private double _ad;

        public double AD
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public Rectangle() : base()
        {
            AD = 6;
        }

        public Rectangle(double ab, double bc, double cd, double ad) : base(ab, bc, cd)
        {
            AD = ad;
        }

        public override void CalculateSquare()
        {
            Console.WriteLine($"Площадь прямоугольника составляет: {AB*BC}");
        }

        public override void CalculatePerimete()
        {
            Console.WriteLine($"Периметр прямоугольника составляет: {AB + BC + CD + AD}");
        }
    }
}
