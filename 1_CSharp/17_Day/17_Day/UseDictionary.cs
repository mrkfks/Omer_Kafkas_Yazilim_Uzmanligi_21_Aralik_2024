using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day
{
    public class UseDictionary
    {
        public UseDictionary() 
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            //add item
            users.Add("ali", "Ali Bilmem ");
            users.Add("veli", "Veli Bilmem");
            users.Add("ayse", "Ayşe Bilmem");
            users.Add("mehmet", "Mehmet Bilmem");

            Console.WriteLine(users["zehra"]);

            //all keys 
            Dictionary<string, string>.KeyCollection keys = users.Keys;
            foreach (string key in keys)
            {
                string val = users[key];
                Console.WriteLine($"key:{key} - val: {val}");
            }
            string data = users.GetValueOrDefault("kemal", "kemal yok");
            Console.WriteLine(data);

            bool statusKey = users.ContainsKey("kemal");
            Console.WriteLine(statusKey);

            //delete item
            users.Remove("ali");

            Console.WriteLine("*******************");
            //all values
            Dictionary<string, string>.ValueCollection values = users.Values;
            foreach (string item in values)
            { 
            Console.WriteLine(item);
            }
        }

    }
}
