using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class SinhVien
    {
        string masv;
        string hoten;
        int ns;
        string quequan;
        float lt, dl, tb;

        public SinhVien()
        {
            masv = "";
            hoten = "";
            quequan = "";
            ns = 0; lt = 0; dl = 0; tb = 0;
        }

        public SinhVien(
            string masv, string hoten, int ns, string quequan, float lt, float dl, float tb)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ns = ns;
            this.quequan = quequan;
            this.lt = lt;
            this.dl = dl;
            this.tb = tb;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ma sv: ");
            masv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            ns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.WriteLine("Nhap diem lap trinh: ");
            lt = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem du lieu: ");
            dl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem tb: ");
            tb = Convert.ToSingle(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", masv, hoten, ns, quequan, lt, dl, tb);
        }
    }
    public class DanhSach
    {
        private int n;
        private SinhVien[] a;

        public void nhapDS()
        {
            Console.WriteLine("Nhap so luong sv: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                a[i].nhap();
            }
        }

        public void xuatDS()
        {
            for(int i = 0; i < n;i++)
            {
                a[i].xuat();
            }
        }
    }
    
}
