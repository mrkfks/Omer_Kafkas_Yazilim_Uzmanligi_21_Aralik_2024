using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day.car_fabric
{
    public class Bmw : Car
    {
        public override string Fuel()
        {
            return "Diesel";
        }

        public override int Price()
        {
            return 3000000;
        }
        public override string Name()
        {
            return "BMW";
        }
    }
}
