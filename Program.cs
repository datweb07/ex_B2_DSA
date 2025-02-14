using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arrayEx
{
    class MonHoc
    {
        private string tenMonHoc;
        private double[] diemMonHoc;

        public MonHoc(string tenMonHoc, int soDiemCanThiet)
        {
            this.tenMonHoc = tenMonHoc;
            diemMonHoc = new double[soDiemCanThiet];
        }

        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }

        public double[] DiemMonHoc
        {
            get { return diemMonHoc; }
            set { diemMonHoc = value; }
        }

        public void NhapDiem()
        {
            for (int i = 0; i < diemMonHoc.Length; i++)
            {
                {
                    Console.Write($"Điểm {tenMonHoc} lần {i + 1} là: ");
                    diemMonHoc[i] = double.Parse(Console.ReadLine());
                    while (diemMonHoc[i] < 0 || diemMonHoc[i] > 10)
                    {
                        Console.Write($"Nhập lại điểm {tenMonHoc} lần {i + 1}: ");
                        diemMonHoc[i] = double.Parse(Console.ReadLine());
                    }
                }
            }
        }


        public double DiemTrungBinh()
        {
            double sum = 0;
            foreach (double i in diemMonHoc)
            {
                sum += i;
            }
            return sum / diemMonHoc.Length;
        }


        public double DiemCaoNhat()
        {
            double max = diemMonHoc[0];
            foreach (double i in diemMonHoc)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public double DiemThapNhat()
        {
            double min = diemMonHoc[0];
            foreach (double i in diemMonHoc)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }


        public void Infor()
        {
            Console.Write($"Môn {tenMonHoc}, " +
                $"có {diemMonHoc.Length} cột điểm, " +
                $"điểm trung bình: {DiemTrungBinh()}, " +
                $"điểm cao nhất: {DiemCaoNhat()}, " +
                $"điểm thấp nhất: {DiemThapNhat()}");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số môn học: ");
                int soMonHoc;
                while (!int.TryParse(Console.ReadLine(), out soMonHoc) || soMonHoc <= 0)
                {
                    Console.Write("Số môn học không hợp lệ, vui lòng nhập lại: ");
                }

                for (int i = 0; i < soMonHoc; i++)
                {
                    Console.Write($"Nhập tên môn học thứ {i + 1}: ");
                    string tenMon = Console.ReadLine();
                    while (string.IsNullOrEmpty(tenMon))
                    {
                        Console.Write("Tên môn học không được bỏ trống, vui lòng nhập lại: ");
                        tenMon = Console.ReadLine();
                    }

                    Console.Write($"Nhập số cột điểm của môn {tenMon}: ");
                    int diemMonHoc;
                    while (!int.TryParse(Console.ReadLine(), out diemMonHoc) || diemMonHoc <= 0)
                    {
                        Console.Write("Số cột điểm không hợp lệ, vui lòng nhập lại: ");
                    }

                    MonHoc monHoc1 = new MonHoc(tenMon, diemMonHoc);
                    monHoc1.NhapDiem();
                    monHoc1.Infor();
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
