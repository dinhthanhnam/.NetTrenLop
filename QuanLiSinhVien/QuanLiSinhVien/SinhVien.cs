using QuanLiSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    public class SinhVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private double diemLT;
        private double csdl;
        private double thietKeWeb;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public double DiemLT
        {
            get { return diemLT; }
            set { diemLT = value; }
        }

        public double CSDL
        {
            get { return csdl; }
            set { csdl = value; }
        }

        public double ThietKeWeb
        {
            get { return thietKeWeb; }
            set { thietKeWeb = value; }
        }

        public double DiemTB()
        {
            return (diemLT + csdl + thietKeWeb) / 3;
        }

        public bool LamKhoaLuan()
        {
            return DiemTB() >= 8 && diemLT >= 5 && csdl >= 5 && thietKeWeb >= 5;
        }

        public bool LamChuyenDe()
        {
            return diemLT >= 5 && csdl >= 5 && thietKeWeb >= 5;
        }

        public void NhapThongTinSinhVien()
        {
            Console.WriteLine("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Ngay sinh (yyyy-MM-dd): ");
            NgaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh: ");
            DiemLT = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem csdl: ");
            CSDL = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem thiet ke web: ");
            ThietKeWeb = Convert.ToSingle(Console.ReadLine());
        }
    }
}

class DanhSachSinhVien
{
    private List<SinhVien> danhSach = new List<SinhVien> ();

    public void ThemSinhVien (SinhVien sv)
    {
        danhSach.Add (sv); 
    }

    public void XuatDanhSach()
    {
        foreach (var sv in danhSach)
        {
            Console.WriteLine("Ho ten: " + sv.HoTen);
            Console.WriteLine("Ngay sinh: " + sv.NgaySinh.ToShortDateString());
            Console.WriteLine("Điểm Lập trình: " + sv.DiemLT);
            Console.WriteLine("Điểm Cơ sở dữ liệu: " + sv.CSDL);
            Console.WriteLine("Điểm Thiết kế web: " + sv.ThietKeWeb);
            Console.WriteLine();
        }
    }

    public int SoSinhVienKhoaLuan()
    {
        int count = 0;
        foreach (var sv in danhSach)
        {
            if (sv.LamKhoaLuan())
                count++; 
        }
        return count; 
    }

    public int SoSinhVienChuyenDe()
    {
        int count = 0;
        foreach (var sv in danhSach)
        {
            if (sv.LamChuyenDe())
                count++;
        }
        return count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        DanhSachSinhVien danhSachSV = new DanhSachSinhVien();
        Console.WriteLine("Nhap so luong sinh vien: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            SinhVien sv = new SinhVien();
            sv.NhapThongTinSinhVien();
            danhSachSV.ThemSinhVien(sv);
        }

        Console.WriteLine("Danh sach sinh vien:");
        danhSachSV.XuatDanhSach();

        Console.WriteLine("Số lượng sinh viên làm khoá luận tốt nghiệp: " + danhSachSV.SoSinhVienKhoaLuan());
        Console.WriteLine("Số lượng sinh viên làm chuyên đề tốt nghiệp: " + danhSachSV.SoSinhVienChuyenDe());
    }
}