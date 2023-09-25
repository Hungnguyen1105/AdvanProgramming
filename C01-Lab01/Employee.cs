using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.C01.Lab01
{
    class Employee
    {
        public int ID { get; } //thuoc tinh chi doc
        public string Firstname { get; }
        public string Lastname { get; }
        public int Salary { get; set; }// thuoc tinh doc va ghi
                //get { return salary; }// tra ve gia tri hien tai cua bk
                //private set { salary = value; }

        public Employee(int id, string firstname, string lastname, int salary)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
            // contructor chua tham so de khoi tao nhan vien
        }
        public string Fullname()
        {
            return $"{Firstname}  {Lastname}";
            // tra ve ten day du nhan vien
        }
        public int AnnualSalary()
        {
            return Salary * 12;
            // tinh luong 1 nam
        }
        public void RasiseSalary(int percent)
        {
            Salary += (Salary * percent) / 100;
            // tang luong theo phan tram 
           
        }
        public override string ToString()
        {
            return "Employee[ID={ID}, Fullname={Fullname()}, Salary={Salary}]";
            // tra ve chuoi doi tuong
        }

    }
}
