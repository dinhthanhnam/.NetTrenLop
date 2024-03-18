using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class nhanvien
    {
        string hoten;
        int ns;
        string diachi;
        double luong;
        double phucap;
        double heso;

        public nhanvien()
        {
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoten = Console.ReadLine();

            Console.WriteLine("Nhap nam sinh: ");
            ns = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap dia chi: ");
            diachi = Console.ReadLine();

            Console.WriteLine("Nhap luong: ");
            luong = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap phu cap: ");
            phucap = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so: ");
            heso = double.Parse(Console.ReadLine());
        }
        public void InNhanVien()
        {
            Console.WriteLine("Họ và tên: " + hoten);
            Console.WriteLine("Năm sinh: " + ns);
            Console.WriteLine("Địa chỉ: " + diachi);
        }
    }

    class mangnhanvien
    {
        private nhanvien[] mangnv;
        private int number;

        public mangnhanvien(int size)
        {
            mangnv = new nhanvien[size];
            number = 0;
        }

        public void themnhanvien(nhanvien nv)
        {
            if (number < mangnv.Length)
            {
                mangnv[number] = nv;
                number++; 
            }
            else
            {
                Console.WriteLine("Mang nhan vien da day`, ko the them.");
            }    
        }

        public void hienthidanhsach()
        {
            Console.WriteLine("Danh sách nhân viên:");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Nhân viên thứ {i + 1}:");
                mangnv[i].InNhanVien();
                Console.WriteLine();
            }
        }
    }
    class program
    {
        static void Main(string[] args) 
        {
            mangnhanvien danhsachnhanvien = new mangnhanvien(3);

            for(int i = 0;i < 3;i++) 
            {
                Console.WriteLine($"Nhập thông tin cho nhân viên thứ {i + 1}:");
                nhanvien nv = new nhanvien();
                nv.nhap();
                danhsachnhanvien.themnhanvien(nv);
            }
            danhsachnhanvien.hienthidanhsach();
        }
    }
}
