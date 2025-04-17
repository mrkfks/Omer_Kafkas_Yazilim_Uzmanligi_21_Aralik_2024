using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day.car_fabric
{
    public class Togg : Car
    {
        public override string Fuel()
        {
            return "Eletric";
        }
        public override int Price()
        {
            throw new NotImplementedException();
        }
        public override string Color() 
        {
            return "Red";
        }
        public override string Name()
        {
            return "Togg";
        }
    }
}
