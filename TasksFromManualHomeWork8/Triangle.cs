using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork8
{
    class Triangle : Figures
    {
        private double _ab;

        public double AB
        {
            get { return _ab; }
            set { _ab = value; }
        }

        private double _bc;

        public double BC
        {
            get { return _bc; }
            set { _bc = value; }
        }

        private double _cd;

        public double CD
        {
            get { return _cd; }
            set { _cd = value; }
        }

        public Triangle()
        {
            AB = 3;
            BC = 4;
            CD = 5;
        }

        public Triangle(double ab, double bc, double cd) 
        {
            AB = ab;
            BC = bc;
            CD = cd;
        }

        public override void CalculateSquare()
        {
            double p = (AB + BC + CD) / 2;
            Console.WriteLine($"Площадь треугольника составляет: {Math.Round(Math.Sqrt(p*(p-AB)*(p-BC)*(p-CD)),3)}");
        }

        public override void CalculatePerimete()
        {
            Console.WriteLine($"Периметр треугольника составляет: {AB+BC+CD}");
        }
    }
}
