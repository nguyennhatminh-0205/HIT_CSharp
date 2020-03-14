using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for(int i=1;i<n;i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 2)
                Console.WriteLine("day la so nguyen to!");
            else
                Console.WriteLine("day khong phai so nguyen to!");
            Console.ReadLine();
        }
    }
}
