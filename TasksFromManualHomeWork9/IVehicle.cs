using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork9
{
    interface IVehicle
    {
        public void Drive(double distance);
        public bool Refuel(double volume);
    }
}
