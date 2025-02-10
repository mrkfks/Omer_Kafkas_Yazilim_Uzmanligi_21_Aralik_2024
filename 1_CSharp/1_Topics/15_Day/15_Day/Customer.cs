using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day
{
    public abstract class Customer
    {
        public abstract int GetCustomerId();
        // total
        //name

        public string GetName()
        {
            int CustomerId = GetCustomerId();
            if (CustomerId == 100)
            {
                return "Ali Bilmem";
            }
            else if (CustomerId == 200)
            {
                return "Zehra Bilirim";
            }
            return "";
        }

            public int GetTotal()
        {
            int customerID = GetCustomerId();
            if (customerID == 100)
            {
                return 1000000;
            }
            else if (customerID == 200) 
            {
                return 2000000;
            }
            return 0;

        }
    }

}
