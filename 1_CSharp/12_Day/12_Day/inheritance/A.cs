using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Day.inheritance
{
    public class A : Base
    {
        public int age = 30;

        public override void Call()
        { 
            Console.WriteLine("A Write Call");
        }

        public int sum(int a, int b)
        { 
            int sm = a + b;
            Console.WriteLine(sm);
            return sm;
        }
    }
}
