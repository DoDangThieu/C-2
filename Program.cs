using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
            Console.ReadKey();
        }
        private static void Menu()
        {
            string chonCN;
            Service chucNang = new Service();
            do
            {
                Console.WriteLine("QUẢN LÝ HỌC VIÊN CỦA LỚP HỌC");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Nhập danh sách đối tượng.");
                Console.WriteLine("2. Xuất danh sách đối tượng.");
                Console.WriteLine("3. Lưu File - Đọc File.");
                Console.WriteLine("4. Mã ID tự tăng khi nhập vào và check trùng.");
                Console.WriteLine("5. Xóa đối tượng theo ID sử dụng LINQ.");
                Console.WriteLine("0. Kết thúc.");
                Console.WriteLine("--------------------------------------");
                Console.Write("Mời bạn chọn chức năng? ");
                chonCN = Console.ReadLine();
                switch (chonCN)
                {
                    case "1":
                        chucNang.NhapDanhSach();
                        break;
                    case "2":
                        chucNang.XuatDanhSach();
                        break;
                    case "3":
                        chucNang.LuuFileDocFile();
                        break;
                    case "4":
                        chucNang.MaID();
                        break;
                    case "5":
                        chucNang.XoaTheoID();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chọn chức năng từ 0->7");
                        break;

                }
            }while (!chonCN.Equals("0"));
        }
    }
}
