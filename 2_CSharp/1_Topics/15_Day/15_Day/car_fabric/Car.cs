using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day.car_fabric
{
    public abstract class Car
    {
        public abstract string Name();
        public abstract int Price();
        public abstract string Fuel();

        public virtual string Color()
        {
            return "White";
        }
        public string Move() 
        {
            return "Moce Call";
        }
        public void Report()
        {
            Console.WriteLine($"{Name()} - {Fuel()} - {Price()} - {Color()} - {Move()}");
        }
    
    }
    
}
