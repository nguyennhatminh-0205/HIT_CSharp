using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void nhap(out float a,out int x,out int n)
        {
            Console.Write("nhap mot so thuc a: ");
            a = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("nhap mot so thuc x: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                    Console.WriteLine("so vua nhap khong thoa man vui long nhap lai!");
            }
            while (x <= 0);
            do
            {
                Console.WriteLine("nhap mot so nguyen n : ");
                n = int.Parse(Console.ReadLine());
                if (5 > n || n > 20)
                    Console.WriteLine("so vua nhap khong thoa man vui long nhap lai! ");
            } while (n < 5 || n > 20);
        }
        static void tinh1(int x,out int k)
        {
            Console.WriteLine("nhap k: ");
            k = int.Parse(Console.ReadLine());
            int s = 1;
            for (int i = 0; i < k; i++)
                s *= x;
            Console.WriteLine("can bac hai cua " + x + " mu " + k + " la: " + Math.Sqrt(s));

        }
        static void tinhS(float a,int x,int n)
        {
            double s = a;
            int kq = n;
            for(int i=0;i<n;i++)
            {
                s += (Math.Pow(-1, n) * Math.Sqrt(Math.Pow(x, i))) / kq;
                kq--;
            }
            Console.WriteLine("ket qua cua S = " + s);
        }
        static void Main(string[] args)
        {
            float a;
            int x, n, k;
            nhap(out a, out x, out n);
            tinh1(x, out k);
            tinhS(a, x, n);
            Console.ReadLine();
        }
    }
}
