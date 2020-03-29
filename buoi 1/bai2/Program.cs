using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao 3 so thuc : ");
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b)
            {
                if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)

                    Console.WriteLine("day la tam giac vuong");
                else if (a == b && b == c && c == a)
                    Console.WriteLine("day la tam giac can");
                else if (a == b && b == c)
                    Console.WriteLine("day la tam giac deu");
                else
                    Console.WriteLine("day la 1 tam giac thuong");
            }
            else
                Console.WriteLine("day khong phai 1 tam giac");
            Console.ReadLine();
        }
    }
}
