using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_DinhThanhNam_24A4042599
{
    using System;

    namespace QuanLiNhanVien
    {
        class Nguoi
        {
            public string HoTen_ThanhNam { get; set; }
            public DateTime NgaySinh_ThanhNam { get; set; }

            public virtual void NhapThongTin()
            {
                Console.Write("Ho ten: ");
                HoTen_ThanhNam = Console.ReadLine();
                Console.Write("Ngay sinh (yyyy/MM/dd): ");
                NgaySinh_ThanhNam = DateTime.Parse(Console.ReadLine());
            }

            public virtual void XuatThongTin()
            {
                Console.WriteLine($"Ho ten: {HoTen_ThanhNam}");
                Console.WriteLine($"Ngay sinh: {NgaySinh_ThanhNam.ToShortDateString()}");
            }
        }

        class NhanVien : Nguoi
        {
            public string MaNV_24a4042599 { get; set; }
            public string ChucVu { get; set; }
            public string PhongBan { get; set; }
            public double HeSoLuong { get; set; }

            public override void NhapThongTin()
            {
                base.NhapThongTin();
                Console.Write("Ma nhan vien: ");
                MaNV_24a4042599 = Console.ReadLine();
                do
                {
                    Console.Write("Chuc vu (TP/NV): ");
                    ChucVu = Console.ReadLine().ToUpper();
                } while (ChucVu != "TP" && ChucVu != "NV");
                Console.Write("Phong ban: ");
                PhongBan = Console.ReadLine();
                Console.Write("He so luong: ");
                HeSoLuong = Convert.ToDouble(Console.ReadLine());
            }

            public double TinhThuNhap()
            {
                if (ChucVu == "TP")
                    return HeSoLuong * 1150000 + 500000;
                else
                    return HeSoLuong * 1150000;
            }

            public override void XuatThongTin()
            {
                base.XuatThongTin();
                Console.WriteLine($"Ma nhan vien: {MaNV_24a4042599}");
                Console.WriteLine($"Chuc vu: {ChucVu}");
                Console.WriteLine($"Phong ban: {PhongBan}");
                Console.WriteLine($"He so luong: {HeSoLuong}");
                Console.WriteLine($"Luong: {TinhThuNhap()}");
            }
        }

        class DanhSachNhanVien
        {
            public int SoLuongNhanVien { get; set; }
            public List<NhanVien> ListNhanVien { get; set; }

            public DanhSachNhanVien()
            {
                SoLuongNhanVien = 0;
                ListNhanVien = new List<NhanVien>();
            }

            public void NhapDanhSachNhanVien()
            {
                Console.Write("Nhap so luong nhan vien: ");
                SoLuongNhanVien = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < SoLuongNhanVien; i++)
                {
                    NhanVien nv = new NhanVien();
                    Console.WriteLine($"\nNhap thong tin nhan vien thu {i + 1}:");
                    nv.NhapThongTin();
                    ListNhanVien.Add(nv);
                }
            }

            public void XuatDanhSachNhanVien()
            {
                Console.WriteLine("\nDanh sach nhan vien:");
                int i = 1;
                
                foreach (var nv in ListNhanVien)
                {
                    Console.WriteLine($"Nhan vien thu {i}:");
                    nv.XuatThongTin();
                    Console.WriteLine();
                    i++;
                }
            }

            public void HienThiNhanVienChucVuTruongPhong()
            {
                Console.WriteLine("\nDanh sach nhan vien co chuc vu TP:");
                int i = 1;
                foreach (var nv in ListNhanVien)
                {

                    if (nv.ChucVu == "TP")
                        {
                        Console.WriteLine($"Nhan vien thu {i}:");
                        nv.XuatThongTin();
                        i++;
                        }    
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                DanhSachNhanVien danhSach = new DanhSachNhanVien();
                danhSach.NhapDanhSachNhanVien();

                danhSach.HienThiNhanVienChucVuTruongPhong();

                danhSach.XuatDanhSachNhanVien();

                Console.ReadLine();
            }
        }

        
    }

}
