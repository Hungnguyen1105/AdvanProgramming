using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class MultifunctionPrint : AbstractPrint
    {
        private string color;
        private int papertray;
        int scanningslot;
        public string Color
        {
            get => color;
            set
            {
                this.color = value;
            }
        }
        public int Papertray
        {
            get => papertray;
            set
            {
                this.papertray = value;
            }
        }
        public int Scanningslot
        {
            get => scanningslot;
            set
            {
                this.scanningslot = value;
            }
        }

        public MultifunctionPrint(string color, int papertray, int scanningslot)
        {
            this.color = color;
            this.papertray = papertray;
            this.scanningslot = scanningslot;
        }

        public MultifunctionPrint()
        {
        }

        public override void ShowInfo()
        {

        }
        public override void PrintColor() { }

        public override void SidedPrint(int selectedPaperTray)
        {



            if (selectedPaperTray >= 1 && selectedPaperTray <= papertray)
            {
                int pagesPerSide = 2; // Số mặt in trên mỗi tờ giấy

                // Tính toán tổng số mặt in được in cùng một lúc dựa trên số khay giấy đã chọn
                int totalPages = papertray * pagesPerSide;

                Console.WriteLine($"Máy in đa năng có {selectedPaperTray} khay giấy có thể in {totalPages} mặt giấy cùng một lúc.");
            }
            else
            {
                Console.WriteLine("Số lượng khay giấy không hợp lệ. Máy in hỗ trợ từ 1 đến 3 khay giấy.");
            }
        }

        
    }
}

