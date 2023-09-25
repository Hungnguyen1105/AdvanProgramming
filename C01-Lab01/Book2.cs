using OOP.C01.Lab01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP
{
    class Book2
        //Phần 5
    {
        private string name;
        private Author[] authors;
        public double price;
        public int Qty = 0;

        public string Name
            //property 
        {
            get { return name; }
            private set { name = value; }
        }

        public Author[] Authors
            //property 
        {
            get { return Authors; }
        }

        public double Price
            //property 
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
            //property
        {
            get { return Qty; }
            set { Qty = value; }
        }

        public Book2(string name, Author[] authors, double price)
        {
            /* 
               Có hai hàm tạo (constructors) cho lớp Book2.
               public Book2(string name, Author[] authors, double price): 
               Đây là hàm tạo có tham số để khởi tạo một đối tượng Book2 với tên, mảng tác giả và giá.
             */
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public Book2(string name, Author[] authors, double price, int Qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.Qty = Qty;
        }

        public string AuthorNames()
        {
            string[] authorNames = authors.Select(author => author.Name).ToArray();
            return string.Join(", ", authorNames);
            /* Đây là một phương thức công khai mà bạn có thể gọi để trả về một chuỗi chứa tên của tất cả các tác giả trong mảng authors. 
               Phương thức này sử dụng LINQ để trích xuất tên từ mảng và nối chúng lại thành một chuỗi.*/
        }

        public override string ToString()
        {
            string authorDetails = string.Join("; ", authors.Select(author => author.ToString()));
            return "Book[Name=" + name + ", Authors{" + authorDetails + "}, Price=" + price + ", Quantity=" + Qty + "]";
            /* Đây là một phương thức ghi đè (override) phương thức ToString() của lớp cha Object. 
               Phương thức này được sử dụng để tạo một chuỗi mô tả đối tượng Book2 hiện tại. Nó bao gồm tên sách, thông tin về các tác giả, giá và số lượng. 
               Phương thức này thường được gọi tự động khi bạn muốn chuyển một đối tượng thành chuỗi (ví dụ: Console.WriteLine(book)).*/
        }
    }
}
