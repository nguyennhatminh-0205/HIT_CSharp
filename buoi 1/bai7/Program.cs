using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float n = 1, s;
            int i = 1;
            s = x;
            while (s > 0.000001)
            {
                n += s;
                i++;
                s *= x / i;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
