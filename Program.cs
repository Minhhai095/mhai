using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtuan4b1
{
    class phanso
    {
        private int tu, mau;
        public phanso()
        {
            tu = 0;
            mau = 1;
        }
        public phanso(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void XuatPhanSo()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
        public phanso Congphanso(phanso ps10)
        {
            int ts = tu * ps10.mau + mau * ps10.tu;
            int ms = mau * ps10.mau;
            phanso ketqua = new phanso(ts, ms);
            return (ketqua);
        }

        public phanso Truphanso(phanso ps1)
        {
            int ts = tu * ps1.mau - mau * ps1.tu;
            int ms = mau * ps1.mau;
            phanso ketqua = new phanso(ts, ms);
            return (ketqua);
        }
        public phanso Nhanphanso(phanso ps1)
        {
            int ts = tu * ps1.tu;
            int ms = mau * ps1.mau;
            phanso ketqua = new phanso(ts, ms);
            return (ketqua);
        }
        public phanso Chiaphanso(phanso ps1)
        {
            int ts = tu * ps1.mau;
            int ms = mau * ps1.tu;
            phanso ketqua = new phanso(ts, ms);
            return (ketqua);
        }
        public phanso RutGon()
        {
            int ts = tu;
            int ms = mau;
            while (tu != mau)
                if (tu > mau) tu = tu - mau;
                else mau = mau - tu;
            ts = ts / tu; ms = ms / tu;
            phanso ketqua = new phanso(ts, ms);
            return (ketqua);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            phanso ps = new phanso();
            phanso ps1 = new phanso(6, 2);
            phanso ps2 = new phanso(1, 2);
            Console.Write("Phan so thu nhat = "); ps1.XuatPhanSo();
            Console.Write("Phan so thu hai = "); ps2.XuatPhanSo();



            ps = ps1.Congphanso(ps2);

            Console.Write("Tong cua hai phan so : ");
            ps.RutGon();
            ps.XuatPhanSo();

            ps = ps1.Truphanso(ps2);
            Console.Write("Hieu cua hai phan so :");
            ps.XuatPhanSo();


            ps = ps1.Nhanphanso(ps2);
            Console.Write("Tich cua hai phan so :");
            ps.XuatPhanSo();

            ps = ps1.Chiaphanso(ps2);
            Console.Write("Thuong cua hai phan so :");
            ps.XuatPhanSo();

            Console.WriteLine();
            Console.Write("Phan so can rut gon: ");
            ps1.XuatPhanSo();
            ps = ps1.RutGon();
            Console.Write("Phan so sau khi rut gon: ");
            ps.XuatPhanSo();
        }
    }
}