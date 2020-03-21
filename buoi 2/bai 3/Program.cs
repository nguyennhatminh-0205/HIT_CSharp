using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    class Program
    {
        static void Nhap(String s)
        {
            a = s.Split(' ');
            Console.Write("arr[]={'");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "','");
            }
            Console.WriteLine("'}");
        }
        static void xuat()
        {
            Console.WriteLine("Ho: " + a[0]);
            Console.WriteLine("Ten Dem: " + a[1]);
            Console.WriteLine("Ten: " + a[2]);
            Console.WriteLine("nam Sinh: " + a[3]);
        }
        static String[] a;
        static int tuoi()
        {
            return 2020 - int.Parse(a[a.Length - 1]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("nhap Ho , ten dem , ten , nam sinh : ");
            String s = Console.ReadLine();
            Nhap(s);
            xuat();
            Console.WriteLine("Nam nay: " + tuoi()+" Tuoi");
            Console.ReadKey();

        }
    }
}
