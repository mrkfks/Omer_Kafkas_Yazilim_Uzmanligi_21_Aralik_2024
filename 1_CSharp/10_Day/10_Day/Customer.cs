using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Day
{
    public class Customer
    {
        public void Login(string email, string password)
        {
            Console.WriteLine($" {email} -  {password} ");
        }
        public void ProfileImageCrop(int width, int height)
        {
            try
            { 
            Console.WriteLine($" {width} -  {height} ");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
