using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so tu nhien n: ");
            int n = int.Parse(Console.ReadLine());
            long S1=0, S2=1, S3=1;
            for (int i = 1; i < n; i++)
            { S1 += i; }
            for (int i = 1; i < n; i++)
            { S2 *= i; }
            for (int i = 1; i < n; i++)
            { S3 += (i - 1) * i; }
            Console.WriteLine("s1= " + S1);
            Console.WriteLine("s2= " + S2);
            Console.WriteLine("s3= " + S3);
            Console.ReadLine();
        }
    }
}
