using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_part2
{
    public class TienDien
    {
        public string TenChuHo;
        public string DiaChi;
        public int SoTruoc;
        public int SoNay;

        public TienDien()
        {
        }

        public TienDien(string tenChuHo, string diaChi, int soTruoc, int soNay)
        {
            TenChuHo = tenChuHo;
            DiaChi = diaChi;
            SoTruoc = soTruoc;
            SoNay = soNay;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin tien dien: ");
            Console.Write("Ten chu ho: ");
            TenChuHo = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("So cong to thang truoc: ");
            SoTruoc = int.Parse(Console.ReadLine());
            Console.Write("So cong to thang nay: ");
            SoNay = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten chu ho: {TenChuHo}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"So cong to thang truoc: {SoTruoc}");
            Console.WriteLine($"So cong to thang nay: {SoNay}");
        }
        public int DaDung
        {
            get
            {
                return SoNay - SoTruoc;
            }
        }

        public virtual int TinhTienDien()
        {
            return DaDung * 500;
        }
    }
    public class TienDienMoi : TienDien
    {
        int DinhMuc;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap dinh muc: ");
            DinhMuc = int.Parse(Console.ReadLine()); 
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Dinh muc la: {DinhMuc}");

        }
        public override int TinhTienDien()
        {
            if (DaDung <= DinhMuc)
                return DaDung * 500; // Giá tiền là 500 VND cho mỗi số điện trong định mức
            else
                return DaDung * 600; // Giá tiền là 600 VND cho mỗi số điện vượt quá định mức
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            TienDienMoi tienDienMoi = new TienDienMoi();   
            tienDienMoi.Nhap();
            tienDienMoi.HienThi();
            Console.WriteLine($"Tien dien la: {tienDienMoi.TinhTienDien()}");
        }
    }
        
}
