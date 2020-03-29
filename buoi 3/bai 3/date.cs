using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    public class date
    {
        int ngay, thang, nam;
        public int Ngay { get => ngay; set => ngay = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public void nhap()
        {
            Console.WriteLine("nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam: ");
            nam = int.Parse(Console.ReadLine());
        }
        public string xuat()
        {
            string s = ngay + "/" + thang + "/" + nam;
            return s;
        }
    }
}
