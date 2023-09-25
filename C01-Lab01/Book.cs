using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.C01.Lab01
{
    class Book
    {
        private string name;
        public Author author;
        public double price;
        public int Qty = 0;


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return Qty; }
            set { Qty = value; }
        }

       
        public Book(string name, Author author, double price, int Qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.Qty = Qty;
        }

        public override string ToString()
        {
            return "Book[Name=" + name + ", Author[Name=" + author.Name + ", Email=" + author.Email + ", Gender=" + author.Gender + "], Price=" + price + ", Quantity=" + Qty + "]";
        }
    }
}
