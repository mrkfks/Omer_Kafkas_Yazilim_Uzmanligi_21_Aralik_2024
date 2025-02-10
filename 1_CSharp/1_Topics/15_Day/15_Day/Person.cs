using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day
{
    public class Person : Customer
    {
        private int cid;
        public Person(int cid)
        {
            this.cid = cid;
        }
        public override int GetCustomerId()
        {
            Console.WriteLine("GetCustomeId Call");
            return cid;
        }
    }
} 

