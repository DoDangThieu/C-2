using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    [Serializable]
    internal class Bike
    {
        private int ID { get; set; }
        private string Ten { get; set; }
        private string HSX { get; set; }
        public Bike(int iD, string ten, string hSX)
        {
            ID = iD;
            Ten = ten;
            HSX = hSX;
        }
        public Bike()
        {
            
        }

        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string _Ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public string _HSX
        {
            get { return HSX; }
            set { HSX = value; }
        }
        public virtual void nhap()
        {
            Console.Write("Tên: ");
            Ten = Console.ReadLine();
            Console.Write("Hãng sản xuất: ");
            HSX = Console.ReadLine();
        }
        public void inThongTin()
        {
            Console.WriteLine($"ID: {ID} - Ten: {Ten} - HSX: {HSX}");
        }
    }
}
