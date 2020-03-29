using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    public class phong
    {
        string maphong, truongphong, tenphong;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Truongphong { get => truongphong; set => truongphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public void nhap()
        {
            Console.WriteLine("nhap ma phong: ");
            maphong = Console.ReadLine();
            Console.WriteLine("nhap ten truong phong: ");
            truongphong = Console.ReadLine();
            Console.WriteLine("nhap ten phong: ");
            tenphong = Console.ReadLine();

        }
    }
}
