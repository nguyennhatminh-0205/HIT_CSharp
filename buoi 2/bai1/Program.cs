using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {   
       static void nhapmang(int[]a,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());

            }

        }
        static int checkPrime(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        static void xuatmang(int[]a,int n)
        {   
            for (int i = 0; i < n; i++)
                if (checkPrime(i + 1) == 1)
                { 
                    Console.Write("a["+i+"]="+a[i] + " ");
                }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("nhap mot so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.Write("so vua nhap khong dung vui long nhap lai!");
            } while (n <= 0);
            int[] a=new int[100];
            nhapmang(a, n);
            Console.WriteLine("cac so nguyen to trong mang la: ");
            xuatmang(a, n);
            Console.ReadKey();
        }
    }
}
