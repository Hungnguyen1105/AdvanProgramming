using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.C01.Lab01
{
    class Author
    {
        public string Name { get; } // Thuộc tính Name chỉ đọc
        public string Email { get; set; } // Thuộc tính Email có thể đọc và ghi

        private char gender; // Thuộc tính Gender là một ký tự (char)

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'f')
                // check xem cos ki m hoac f hay k
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'm' or 'f'.");
                }
            }
        }

        // Constructor để khởi tạo đối tượng Author
        public Author(string name, string email, char gender)
        {
            Name = name;
            Email = email;
            Gender = gender; // Kiểm tra và gán giá trị Gender
        }

        // Phương thức ToString() trả về chuỗi biểu diễn của đối tượng Author
        public override string ToString()
        {
            return $"Author[Name={Name}, Email={Email}, Gender={Gender}]";
        }

    }
}