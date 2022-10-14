using Demo_SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SOLID.Classes
{
    internal class BMW : Cars
    {
        public string GetCar()
        {
            
            return "Display";
        }

        public double GetCost()
        {
            throw new NotImplementedException();
        }
    }
}
