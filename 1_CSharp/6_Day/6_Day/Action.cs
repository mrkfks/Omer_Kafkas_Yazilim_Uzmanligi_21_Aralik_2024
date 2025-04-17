using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Day
{
    public class Action
    {
        // 123Ali
        public bool StringValid(string data)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char c in data)
            {
                if (numbers.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void Fibonacci(int number)
        {
            int a = 0, b = 1, c;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
