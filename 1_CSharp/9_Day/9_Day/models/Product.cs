using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Day.models
{
    public struct Product
    {
        public int pid;
        public string title;
        public string detail;
        public int price;
        public bool status;

        public Product(int pid, string title, string detail, int price, bool status)
        {
            this.pid = pid;
            this.title = title;
            this.detail = detail;
            this.price = price;
            this.status = status;
        }

        public override string ToString() 
        { 
            return $"ID: {pid} Title: {title} Detail: {detail} Price: {price} Status: {status}";
        }

    }
}
