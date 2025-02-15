using _16_Day.utils;

namespace _16_Day
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // array - immutable
            int[] ints = { 10, 20, 30 };
            string[] users = { "Ahmet", "Zehra", "Veli", "Mehmet" };

            Console.WriteLine("Ints array:");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Users array:");
            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            // Collections  - mutable
            // ArrayList
            UseArrayList useArrayList = new UseArrayList();
            useArrayList.call();
            Console.WriteLine("==========================");

            // List
            // Generic
            Actions<int> actions = new Actions<int>();
            actions.Add(100);
            actions.DisplayItems();

            UseList useList = new UseList();
            useList.Call();
        }
    }
}
