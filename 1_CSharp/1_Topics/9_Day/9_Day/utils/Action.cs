using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_Day.models;

namespace _9_Day.utils
{
    
    public class Action
    {
        public void save(Product product)
        {
            product.price = 100;
        }
    }
}
