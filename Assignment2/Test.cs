using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    internal class Test
    {
        //    static void Main(string[] args)
        //    {

        //        MultifunctionCopy multiCopy = new MultifunctionCopy();
        //        SingleCopy singleCopy = new SingleCopy();

        //        int choice;
        //        do
        //        {
        //            Console.WriteLine("Function (1 - Copy, 2 - Scan, 3 - Fax, 0 - Exit):");
        //            if (int.TryParse(Console.ReadLine(), out choice))
        //            {
        //                switch (choice)
        //                {
        //                    case 1:
        //Console.WriteLine("chon mau trang den hay in mau (T/N):");
        //                        string colorChoice = Console.ReadLine();
        //bool isColor = (colorChoice.ToLower() == "n");
        //string summary1 = "";

        //                        Console.WriteLine("ban da chon " + (isColor ? "nhiều màu" : "trắng đen"));

        //                        Console.WriteLine("Chọn dau ra 1 mat hay nhieu mat (1/2):");
        //                        if (int.TryParse(Console.ReadLine(), out choice))
        //                        {
        //                            switch (choice)
        //                            {
        //                                case 1:
        //                                    Console.WriteLine("Bạn đã chọn sao chép " + (isColor ? "màu" : "trắng đen"));
        //                                    multiCopy.Color = isColor ? "In nhiều màu" : "Trắng đen";
        //                                    multiCopy.Copy();
        //                                    summary1 += "Sao chép " + (isColor ? "màu" : "trắng đen") + " một mặt"; // Cộng thêm thông tin vào biến summary
        //                                    break;
        //                                case 2:
        //                                    Console.WriteLine("Bạn đã chọn sao chép " + (isColor ? "màu" : "trắng đen"));
        //                                    multiCopy.Color = isColor ? "In nhiều màu" : "Trắng đen";
        //                                    multiCopy.Copy();
        //                                    summary1 += "Sao chép " + (isColor ? "màu" : "trắng đen") + " nhiều mặt"; // Cộng thêm thông tin vào biến summary
        //                                    break;
        //                                default:
        //                                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1 hoặc 2 cho mặt.");
        //                                    break;
        //                            }
        //                            Console.WriteLine(summary1);
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 1 hoặc 2 cho mặt.");
        //                        }
        //                        break;
        //                    case 2:
        //                        Console.WriteLine("chon mau trang den hay in mau (T/N):");
        //                        string colorChoice1 = Console.ReadLine();
        //                        bool isColor1 = (colorChoice1.ToLower() == "n");
        //                        string summary2 = "";
        //                        Console.WriteLine("Ban da chon Scan " + (isColor1 ? "nhiều màu" : "trắng đen"));

        //                        Console.WriteLine("Chọn dau ra 1 mat hay nhieu mat (1/2):");
        //                        if (int.TryParse(Console.ReadLine(), out choice))
        //                        {
        //                            switch (choice)
        //                            {
        //                                case 1:
        //Console.WriteLine("Ban da chon Scan " + (isColor1 ? "màu" : "trắng đen"));
        //multiCopy.Color = isColor1 ? "Scan nhiều màu" : "Trắng đen";
        //multiCopy.Copy();
        //summary2 += "Scan " + (isColor1 ? "màu" : "trắng đen") + " một mặt"; 
        //break;
        //                                case 2:
        //                                    Console.WriteLine("Ban da chon Scan " + (isColor1 ? "màu" : "trắng đen"));
        //                                    multiCopy.Color = isColor1 ? "In nhiều màu" : "Trắng đen";
        //                                    multiCopy.Copy();
        //                                    summary2 += "Scan " + (isColor1 ? "màu" : "trắng đen") + " nhiều mặt"; 
        //                                    break;
        //                                default:
        //                                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1 hoặc 2 cho mặt.");
        //                                    break;
        //                            }
        //                            Console.WriteLine(summary2);
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 1 hoặc 2 cho mặt.");
        //                        }
        //                        break;
        //                        multiCopy.Scan();
        //                        break;
        //                    case 3:
        //                        Console.WriteLine("Nhập số fax cần gửi đến");
        //                        string faxNumber = InputFaxNumber();

        //                        if (!string.IsNullOrWhiteSpace(faxNumber))
        //                        {
        //                            Console.WriteLine("Đã gửi fax đến địa chỉ: " + faxNumber);
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("Số fax không hợp lệ. Vui lòng nhập số fax hợp lệ.");
        //                        }
        //                        multiCopy.Fax();
        //                        break;
        //                    case 0:
        //                        Console.WriteLine("Kết thúc chương trình.");
        //                        break;
        //                    default:
        //                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1, 2, 3 hoặc 0.");
        //                        break;
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1, 2, 3 hoặc 0.");
        //            }
        //        } while (choice != 0);
        //    }
        //    public static string InputFaxNumber()
        //    {
        //        string faxNumber;
        //        bool isValid = false;

        //        do
        //        {

        //            try
        //            {
        //                faxNumber = Console.ReadLine();

        //                if (string.IsNullOrWhiteSpace(faxNumber))
        //                {
        //                    Console.WriteLine("Số fax không được để trống.");
        //                }
        //                else if (faxNumber.All(char.IsDigit))
        //                //char.IsDigit check kí tự tât cả là số
        //                {
        //                    isValid = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Số fax phải chứa chỉ số.");
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Đã xảy ra lỗi. Vui lòng thử lại.");
        //                faxNumber = "";
        //            }
        //        } while (!isValid);

        //        return faxNumber;
        //    }
        //}
        public static void Main(string[] args)
        {
            SingleCopy singleCopy = new SingleCopy("Trắng đen", "Model"); // Màu trắng đen là mặc định

            int choice;
            do
            {
                Console.WriteLine("Function (1 - Copy - 1sided  ,2 - Copy - 2sided , 0 - Exit):");
                string colorChoice = Console.ReadLine();
                bool isColor = (colorChoice.ToLower() == "n");
                string summary3 = "";
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn sao chép " + (isColor ? "màu" : "trắng đen"));
                        singleCopy.Color = isColor ? "In " : "Trắng đen";
                        singleCopy.Copy();
                        summary3 += "Sao chép " + (isColor ? "" : "trắng đen") + " một mặt";
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn sao chép " + (isColor ? "màu" : "trắng đen"));
                        singleCopy.Color = isColor ? "In " : "Trắng đen";
                        singleCopy.Copy();
                        summary3 += "Sao chép " + (isColor ? "" : "trắng đen") + " 2 mat";
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1 hoặc 0.");
                        break;

                }
            } while (choice != 0);

        }
    }
}
