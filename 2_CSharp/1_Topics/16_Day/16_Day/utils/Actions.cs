using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Day.utils
{
    public class Actions<T>
    {
        private List<T> items = new List<T>();

        public void Add(T t)
        {
            items.Add(t);
            Console.WriteLine($"{t} eklendi.");
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
