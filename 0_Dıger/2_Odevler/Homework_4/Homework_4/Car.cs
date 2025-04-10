using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Car
    {
        //Properties
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yil { get; set; }
    }
        //Constructor
    public Car (string marka, string model, string yil)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
        }
        //Methods
        public void CarInfo()
        {
            Console.WriteLine($"Markası: {Marka}, Model: {Model}, Yıl: {Yil}");
        }
    }
