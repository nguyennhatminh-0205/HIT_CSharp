using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("nhap vao 5 chu so nguyen: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            int min = a;
            if (b < max && min < b) min = b;
            if (c < max && min < c) min = c;
            if (d < max && min < d) min = d;
            if (e < max && min < e) min = e;
            Console.WriteLine("so lon thu 2 la: " + min);
            Console.ReadLine();
            

        }
    }
}
