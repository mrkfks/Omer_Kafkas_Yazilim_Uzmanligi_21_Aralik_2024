﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Day.properties
{
    public class Product
    {

        private int Pid;
        private string Title;
        private string Detail;
        private int Price;

        public int pid
        {
            get 
            {
                Console.WriteLine("Pid Get Call");
                return Pid;
            }
            set
            {
                if (value > 0) {Pid = value;}
                else{throw new Exception("Negative or Zero Number Problem");}
            }
        
        }

        public string title
        {
            get {return Title;}
            set
            {
                if (value.Length > 1 && value.Length < 101) {Title = value;}
                else {throw new Exception("Title size > 1 and size < 101");}
            }
        }

        public string detail
        {
            get { return Detail;}
            set { Detail = value;}
        }
        public int price 
        {
            get { return Price; }
            set { Price = value; }
        }

    }
}
