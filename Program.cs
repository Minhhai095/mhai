using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtuan4b2
{
    class Diem
    {
        private double x; 
        private double y; 

        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(int a, int b)
        {
            x = a;
            y = b;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap toa do cua hai diem: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Toa do cua hai diem do la:({0};{1})", x, y);
        }
        public double KhoangCach(Diem d1, Diem d2)
        {
            double KC = new double();
            KC = Math.Sqrt(Math.Abs(d1.x - d2.y) * (d1.x - d2.y) + (d1.x - d2.y) * (d1.x - d2.y));
            return KC;
        }

        public void Xuatkc()
        {
            Diem d1 = new Diem();
            Diem d2 = new Diem();
            Console.WriteLine("Khoang cach cua hai diem do la:{0}", KhoangCach(d1, d2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double KhoangCach;
            Diem d1 = new Diem();
            d1.Nhap();
            d1.Xuat();
            Diem d2 = new Diem();
            d2.Nhap();
            d2.Xuat();
            Diem d3 = new Diem();
            d3.Xuatkc();
            Console.ReadLine();
        }
    }
}
