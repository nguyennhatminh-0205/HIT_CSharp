using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("cac uoc cua so vua nhap la: ");
            for(int i=1;i<n;i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
