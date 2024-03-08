using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TINH
{
    // Class Tinh để định nghĩa thông tin của 1 tỉnh
    public class Tinh
    {
        public int MaTinh { get; set; }
        public string TenTinh { get; set; }
        public float DienTich { get; set; }
    }

    // Class Nhập/Xuất để quản lý việc nhập và xuất thông tin tỉnh
    public class NhapXuatTinh
    {
        //Hàm nhập thông tin của một tỉnh
        public static void NhapTinh(ref Tinh a)
        {
            Console.Write("Nhập Mã Tỉnh: ");
            a.MaTinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập Tên Tỉnh: ");
            a.TenTinh = Console.ReadLine();

            Console.Write("Nhập Diện Tích: ");
            a.DienTich = float.Parse(Console.ReadLine());
        }

        //Hàm xuất thông tin của 1 tỉnh
        public static void XuatTinh(Tinh a)
        {
            Console.WriteLine($"Mã Tỉnh: {a.MaTinh}");
            Console.WriteLine($"Tên Tỉnh: {a.TenTinh}");
            Console.WriteLine($"Diện Tích: {a.DienTich}");
        }
    }

    // Class Program để chứa phương thức Main và các thực thi khác
    public class Program
    {
        const int N = 100;

        //Hàm Main để chạy chương trình 
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Tinh[] t = new Tinh[N];
            int n = 0;

            // Gọi hàm nhập danh sách tỉnh từ bên ngoài class
            NhapDSTinh(t, ref n);
            //Gọi hàm xuất danh sách tỉnh từ bên ngoài class
            XuatDSTinh(t, n);
            Console.ReadLine();
        }

        //Hàm nhập danh sách tỉnh
        static void NhapDSTinh(Tinh[] t, ref int n)
        {
            Console.Write("Nhập số lượng Tỉnh: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                t[i] = new Tinh();
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Tỉnh thứ {i + 1}");
                NhapXuatTinh.NhapTinh(ref t[i]);
            }
        }

        // Hàm xuất danh sách tỉnh
        static void XuatDSTinh(Tinh[] t, int n)
        {
            Console.WriteLine("=-=DANH SÁCH CÁC TỈNHH=-=");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"---Tỉnh thứ {i + 1}---");
                NhapXuatTinh.XuatTinh(t[i]);
                Console.WriteLine("---------------------------");
            }
        }
    }
}
