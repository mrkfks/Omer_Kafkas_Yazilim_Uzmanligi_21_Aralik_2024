using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Book
{
    public class Book
    {
        private string title = "Ali";
        public string Title 
        { 
            get { return title; } 
        }


        private string author = "Veli";
        public string Author 
        {
            get { return author; }
            set {author = value;}
        }
    }
}
