using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day.car_fabric
{
    public class Mercedes : Car
    {
        public override string Fuel()
        {
            return "Oil";
        }

        public override int Price()
        {
            return 4000000;
        }
        public override string Color()
        {
            return "Mercedes";
        }
    }
}
