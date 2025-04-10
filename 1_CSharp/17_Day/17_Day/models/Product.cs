using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day.models
{
    public struct Product
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }

        public Product()
        {
        }

        public Product(string title, string detail, double price, int status)
        {
            this.Title = title;
            this.Detail = detail;
            this.Price = price;
            this.Status = status;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Detail: {Detail}, Price: {Price}, Status: {Status}";
        }
    }
}

