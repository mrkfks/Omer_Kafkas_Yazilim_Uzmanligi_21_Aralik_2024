using _9_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Day.utils
{
    public class Profile
    {
        public Product save(Product product)
        {
            return product;
        }
        public int Days(EDay eDay)
        {
            switch (eDay)
            {
                case EDay.PAZARTESI:
                    return 10;
                case EDay.SALI:
                    return 20;
                case EDay.ÇARŞAMBA:
                    return 30;
                default:
                    return 0;
            }
        }
    }
}
