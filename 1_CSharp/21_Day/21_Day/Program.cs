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
            int fileIndex = Convert.ToInt32(Console.ReadLine());
            string fullfile = filesList[fileIndex - 1];
            string plainFileName = fullfile.Substring(0, fullfile.Length - 4);

            fileControl = new FileControl(plainFileName);
            List<string> fileContent = fileControl.ReadFile();
            foreach (var item in fileContent)
            {
                Console.WriteLine(item);
            }
        }
    }
}