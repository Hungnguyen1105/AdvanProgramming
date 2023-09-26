using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.labtestKt.Lab01
{
    public class Problem2
    {
        static double[] arr = new double[100];
        static int s = 0;
        public static void AddValue()
        {
            if (s < 100)
            {
                Console.WriteLine("Nhap gia tri: ");
                double value = double.Parse(Console.ReadLine());
                arr[s] = value;
                s++;
                Console.WriteLine("Them vao mang thanh cong");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        public static void SearchValue()
        {
            Console.Write("Nhap gia tri can tim");
            double value = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] == value)
                {
                    count++;
                }

            }
            Console.WriteLine("So lan gia tri " + value + " xuat hien trong mang: " + count);
        }
        public static void PrintArray()
        {
            Console.WriteLine("In ra cac gia tri trong mang");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void PrintRange()
        {
            Console.WriteLine("Nhap gia tri Minval");
            double Minval = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri Maxval");
            double Maxval = double.Parse(Console.ReadLine());
            Console.WriteLine("Cac gai Minval va Maxval");
            for (int i = 0; i < s; i++)
            {
                if (arr[i] > Minval && arr[i] <= Maxval)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
        public static void PrintSortedArray()
        {
            double[] sortedArr = (double[])arr.Clone();
            Array.Sort(sortedArr);

            Console.WriteLine("Các giá trị trong mảng theo thứ tự tăng dần:");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Chọn một tùy chọn:");
                Console.WriteLine("1. Thêm giá trị vào mảng");
                Console.WriteLine("2. Tìm kiếm giá trị trong mảng");
                Console.WriteLine("3. In ra toàn bộ mảng");
                Console.WriteLine("4. In ra các giá trị trong khoảng");
                Console.WriteLine("5. In ra mảng đã sắp xếp");
                Console.WriteLine("0. Thoát");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Plese choose again");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exit.");
                        return;
                    case 1:
                        AddValue();
                        break;
                    case 2:
                        SearchValue();
                        break;
                    case 3:
                        PrintArray();
                        break;
                    case 4:
                        PrintRange();
                        break;
                    case 5:
                        PrintSortedArray();
                        break;
                    default:
                        Console.WriteLine("Eror , Please choose again");
                        break;
                }
            } while (true);
        }



    }
}
