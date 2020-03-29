using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_1

    public class hangHoa
{
     String maHang;
     String tenHang;
     int donGia;
     int soLuong;
    public string mahang { get => mahang; set => mahang = value; }
    public string tenhang { get => tenhang; set => tenhang = value; }
    public int donGia { get => donGia; set => donGia = value; }
    public int soluong { get => soluong; set => soluong = value; }


    public void nhap()
    {
        Console.WriteLine("Nhap ma hang: ");
        this.maHang = Console.ReadLine();
        Console.WriteLine("Nhap ten hang: ");
        this.tenHang = Console.ReadLine();
        Console.WriteLine("Nhap don gia: ");
        this.donGia = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so luong: ");
        this.soLuong = int.Parse(Console.ReadLine());
    }

    public void xuat()
    {
        Console.WriteLine(this.maHang + "\t" + this.tenHang + "\t\t" + this.donGia + "\t\t" + this.soLuong + "\t\t" + thanhTien());
    }

    public int thanhTien()
    {
        return this.soLuong * this.donGia;
    }
}

