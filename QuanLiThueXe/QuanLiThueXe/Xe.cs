using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThueXe
{
    abstract class Xe
    {
        public abstract void Nhap();
        public abstract void Hien();
        public abstract double TinhTien(int soGioThue);
    }

    class XeTai : Xe
    {
        public override void Nhap()
        {
           
        }

        public override void Hien() 
        { 
        
        }

        public override double TinhTien(int soGioThue)
        {
            double giaGioDau = 220000;
            double giaoGioTiepTheo = 85000;
            double tongTien = giaGioDau + giaoGioTiepTheo * (soGioThue - 1);
            return tongTien;
        }
    }
    class XeKhach : Xe
    {

        public override void Nhap()
        {
        
        }
        public override void Hien()
        {

        }

        public override double TinhTien(int soGioThue)
        {
            double giaGioDau = 250000;
            double giaGioTiepTheo = 70000;

            double tongTien = giaGioDau + giaGioTiepTheo * (soGioThue - 1);
            return tongTien;
        }
    }
    class Khach
    {
        private string hoTen;
        private int soGioThue;
        private Xe loaiXe;
              
        public Khach()
        {
            hoTen = "";
            soGioThue = 0;
            loaiXe = null;
        }

        public void NhapThongTin()
        {
            Console.Write("Nhap ho ten khach hang: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap so gio thue: ");
            soGioThue = int.Parse(Console.ReadLine());

            Console.Write("Loai xe (1 - Xe Tai, 2 - Xe Khach): ");
            int loaiXeChon = int.Parse(Console.ReadLine());

            if (loaiXeChon == 1)
                loaiXe = new XeTai();
            else if (loaiXeChon == 2)
                loaiXe = new XeKhach();

        }

        public void HienThongTin()
        {
            Console.WriteLine("Ho ten khach hang: " + hoTen);
            Console.WriteLine("So gio thue: " + soGioThue);
            loaiXe.Hien();
            Console.WriteLine("Thanh tien: " + loaiXe.TinhTien(soGioThue));
        }
    }
    class QuanLy
    {
        private Khach[] danhSachKhach;

        public void NhapDanhSachKhach(int soLuongKhach)
        {
            danhSachKhach = new Khach[soLuongKhach];
            for (int i = 0; i < soLuongKhach; i++)
            {
                danhSachKhach[i] = new Khach();
                danhSachKhach[i].NhapThongTin();
            }
        }

        public void HienThongTinDanhSachKhach()
        {
            Console.WriteLine("Danh sach thong tin khach hang:");
            foreach (Khach khach in danhSachKhach)
            {
                khach.HienThongTin();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLy quanLy = new QuanLy();
            Console.Write("Nhap so luong khach hang: ");
            int soLuongKhach = int.Parse(Console.ReadLine());
            quanLy.NhapDanhSachKhach(soLuongKhach);
            quanLy.HienThongTinDanhSachKhach();
        }
    }
}
