using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    public class nhanvien
    {
        string tennv, chucvu;
        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public void nhap()
        {
            Console.Write("nhap ten nhan vien: ");
            Tennv = Console.ReadLine();
            Console.WriteLine("nhap chuc vu cua nhan vien: ");
            Chucvu = Console.ReadLine();
        }
    }
}
