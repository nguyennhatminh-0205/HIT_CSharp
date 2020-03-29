using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    public class DODUNG
    {
        string dodung;
        int soluong;
        string tinhtrang;
        public string Dodung { get => dodung; set => dodung = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public void nhap()
        {
            Console.WriteLine("nhap ten do dung: ");
            dodung = Console.ReadLine();
            Console.WriteLine("nhap so luong: ");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap tinh trang: ");
            tinhtrang = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("/t" + Dodung, soluong, tinhtrang);
        }
        public int getsoluong()
        {
            return soluong;
        }
    }
}
