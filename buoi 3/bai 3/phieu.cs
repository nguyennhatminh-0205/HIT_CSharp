using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    public class phieu
    {
        int maphieu;
        date ngaythangnam = new date();
        phong phong = new phong();
        nhanvien nv  = new nhanvien();
        DODUNG[] dd;
        int n;
        public void nhap()
        {
            Console.WriteLine("nhap ma phieu: ");
            maphieu = int.Parse(Console.ReadLine());
            ngaythangnam.nhap();
            nv.nhap();
            this.phong.nhap();
            Console.WriteLine("nhap so luong tai san: ");
            n = int.Parse(Console.ReadLine());
            dd = new DODUNG[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("nhap do dung " + (i + 1));
                dd[i] = new DODUNG();
                dd[i].nhap();
            }
        }
        public int tinhtong()
        {
            int tong = 0;
            for(int i=0;i<n;i++)
            {
                tong += dd[i].getsoluong();
            }
        }
        public void xuat()
        {
            Console.WriteLine("/t/t/t/t PHIEU KIEM KE TAI SAN ");
            Console.WriteLine("/t/t maphieu : " + maphieu);
            Console.WriteLine("/t/t ngaykiemke : " + ngaythangnam.xuat());
            Console.WriteLine("/t/t nhanvienkiemke: " + nv.Tennv);
            Console.WriteLine("/t/t chucvu: " + nv.Chucvu);
            Console.WriteLine("/t/t kiemketaiphong: " + phong.Tenphong);
            Console.WriteLine("/t/t maphong: " + phong.Maphong);
            Console.WriteLine("/t/t truongphong: " + phong.Truongphong);
            Console.WriteLine();
            Console.WriteLine("{0}/t{1}/t{2}", "tentaisan", "soluong", "tinhtrang");
            for(int i=0;i<n;i++)
            {
                dd[i].xuat();
            }
            Console.WriteLine("/t soluongtaisandakiemke: " + n);
            Console.Write("/t tongsoluong: " +tinhtong());
        }

        

    }
}
