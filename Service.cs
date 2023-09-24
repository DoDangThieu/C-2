using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    internal class Service 
    {

        List<Bike> bikes = new List<Bike>();
        internal void LuuFileDocFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("bikes.LOL", FileMode.OpenOrCreate, FileAccess.Write);

            bf.Serialize(fs, bikes);
            Console.WriteLine(fs);
            fs.Close();
            Console.WriteLine("File đã lưu");
            FileStream ff = new FileStream("bikes.LOL", FileMode.Open, FileAccess.Read);
            bikes = (List<Bike>)bf.Deserialize(ff);
            Console.WriteLine(ff);
            fs.Close();
            Console.WriteLine("Đọc file");
            XuatDanhSach();
        }

        internal void MaID()
        {
            Console.WriteLine("Nhap ID Bike:");
            int id = int.Parse(Console.ReadLine());

            if (bikes.Exists(x => x._ID == id))
            {
                Console.WriteLine("ID da ton tai");
                return;
            }
            Bike bi = new Bike();
            bi._ID = id;
            bi.nhap();
            bikes.Add(bi);
        }

        internal void NhapDanhSach()
        {
            string nhapTiep;
            Console.WriteLine("1.Nhập danh sách học viên.");
            int step;
            Console.WriteLine("Bạn muốn nhập step id tự tăng là bao nhiêu: ");
            step = Convert.ToInt32(Console.ReadLine());
            do
            {
                Bike bi = new Bike();
                bi._ID = GenerateID(step);
                bi.nhap();
                if (IsDuplicated(bi._ID))
                {
                    bikes.Add(bi);
                }
                Console.Write("Bạn có muốn nhập tiếp không(c/k):");
                nhapTiep = Console.ReadLine();
            } while (nhapTiep.ToUpper() == "C");
        }
        public void XuatDanhSach()
        {
            foreach (Bike bi in bikes)
            {
                bi.inThongTin();
            }
        }
        internal void XoaTheoID()
        {
            Console.WriteLine("Nhap ID Bike can xoa:");
            int id = int.Parse(Console.ReadLine());

            if (!bikes.Exists(x => x._ID == id))
            {
                Console.WriteLine("ID khong ton tai");
                return;
            }

            bikes.Remove(bikes.Find(x => x._ID == id));

            Console.WriteLine("Da xoa Bike co ID {0}", id);
        }
        private bool IsDuplicated(int IDforCheck)
        {
            if(bikes.Exists(x=> x._ID == IDforCheck))
            {
                Console.WriteLine("ID da ton tai");
                return false;
            }
            else
            {
                return true;
            }
        }
        private int GenerateID(int stepNumber)
        {
            if(!bikes.Any())
            {
                return stepNumber;
            }else 
            return bikes.Last()._ID + stepNumber;
        }
    }
}