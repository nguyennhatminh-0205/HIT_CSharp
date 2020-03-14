using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 2;
            Console.WriteLine(dem + "=");
            while (n != 1)
            {
                if (n % dem == 0)
                {
                    if (n == dem)
                    {
                        Console.Write(dem);
                    }

                    else
                    {
                        Console.Write(dem + "  x  ");
                    }
                    n /= dem;
                }
                else
                    dem++;
            }
            Console.ReadLine();
        }
    }
}
