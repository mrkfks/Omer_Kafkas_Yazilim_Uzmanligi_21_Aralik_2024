using System;
using _21_Day.Utils;

namespace Days_21
{
    class Program
    {
        static void Main(string[] args)
        {
            FileControl fileControl = new ();
            
            //fileControl.WriteToFile("Line-3");
            // fileControl.DeleteFile();

            //fileControl.ReadFile();

            /*List<string> ls = fileControl.ReadFile();
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }*/
            List<string> filesList = fileControl.listFile();
            foreach (var item in filesList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Lütfen Okumak İstediğiniz dosyanın adını giriniz");
        }
    }
}
