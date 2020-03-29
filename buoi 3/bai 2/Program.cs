using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ptBac2 a = new ptBac2(-1, 2, -3);
            ptBac2 b = new ptBac2(4, -5, 6);
            Console.Write("Phuong trinh 1 : ");
            a.xuat();
            Console.Write("Phuong trinh 2 : ");
            b.xuat();
            ptBac2 tong = a + b;
            ptBac2 hieu = a - b;
            a--;
            b--;
            Console.Write("Phuong trinh 1 dao nguoc: ");
            a.xuat();
            Console.Write("Phuong trinh 2 dao nguoc: ");
            b.xuat();
            Console.Write("Phuong trinh tong : ");
            tong.xuat();
            Console.Write("Phuong trinh hieu : ");
            hieu.xuat();

            Console.ReadKey();
        }
    }
}
