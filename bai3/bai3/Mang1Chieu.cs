using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Mang1Chieu
    {
        private int n;
        private int[] a;

        public Mang1Chieu()
        {
            n = 0;
        }

        public Mang1Chieu(int n)
        {
            this.n = n;
            a = new int[n];
        }

        public void nhap()
        {
            Console.Write("Nhap so pt cua mang: ");
            this.n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Nhap a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine()); ;
            }

        }
        public void xuat()
        {
            Console.WriteLine("mang vua nhap la:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
        }

        public void sx(int tt)
        {
            if (tt == 0)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] > a[j])
                        {
                            int tg = a[i];
                            a[i] = a[j];
                            a[j] = tg;
                        }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] < a[j])
                        {
                            int tg = a[i];
                            a[i] = a[j];
                            a[j] = tg;
                        }
            }
            Console.WriteLine("Mang sau khi sx la:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
        }

        public int tk(int m)
        {
            for (int i = 0; i < n; i++)
                if (a[i] == m)
                {
                    return i;
                }
            return -1;
        }
        public static void Main(string[] args)
        {
            Mang1Chieu x = new Mang1Chieu();
            x.nhap();
            x.xuat();
            //int tt;
            //do
            //{
            //    Console.Write("Ban muon sx tang/giam");
            //    tt = Convert.ToInt32(Console.ReadLine());
            //} while (tt != 0 && tt != 1);
            //x.sx(tt);
            int n;
            Console.Write("Nhap gtri can tim:");
            n = Convert.ToInt32(Console.ReadLine());

            if (x.tk(n) == -1) Console.Write("ko tim thay");
            else Console.Write("Vi tri thay {0}", x.tk(n));
        }
    }
}

