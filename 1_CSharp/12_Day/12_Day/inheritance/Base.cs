using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Day.inheritance
{
    public class Base
    {
        public virtual void Call()
        {
            Console.WriteLine("Base Call");
        }
    }
    public class B : Base
    {
        public override void Call()
        {
            Console.WriteLine("B Write Call");
        }
    }
}
