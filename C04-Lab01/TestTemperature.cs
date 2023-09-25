using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04
{
    public  class TestTemperature
    {
        public static void Main(string[] args)
        {
            
            double initialftemp = 0;
            Temperature temp = new Temperature(initialftemp);
            //phần này k tự code phải hỏi 40%
            while (true)
            {
                Console.Write("Please enter Fahrenheit value (0 to exit): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double newFahrenheit))
                //double.TryParse()  chuyển đổi một chuỗi thành một số thực (double)và kiểm tra xem việc chuyển đổi có thành công hay không.
                //Dòng này kiểm tra xem chuỗi input có thể chuyển đổi thành một số thực (double) hay không.
                //Nếu có, giá trị chuyển đổi được lưu vào biến newFahrenheit.
                {
                    if (newFahrenheit == 0)
                    // Dòng này kiểm tra nếu newFahrenheit bằng 0,
                    // tức là người dùng muốn thoát khỏi chương trình, nó sẽ in ra thông báo và sử dụng lệnh break để thoát khỏi vòng lặp vô hạn.
                    {
                        Console.WriteLine("Exiting the program.");
                        break;
                    }

                    temp.SetFahrenheit(newFahrenheit);
                    //
                    Console.WriteLine("Fahrenheit: " + temp.getFahrenheit());
                    Console.WriteLine("Celsius: " + temp.GetCelsius());
                    Console.WriteLine("Celsius: " + temp.GetKelvin());
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
