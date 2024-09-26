using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIENVASINHVIEN_BUOI4
{
    internal class SinhVien : Nguoi
    {
        string mssv;
        string nganhhoc;
        double dtb;

        public string Mssv { get => mssv; set => mssv = value; }
        public string Nganhhoc { get => nganhhoc; set => nganhhoc = value; }
        public double Dtb { get => dtb; set => dtb = value; }

        public SinhVien() { }

        public SinhVien (string hovaten, string ngaysinh, string gioitinh,string mssv,string nganhhoc,double dtb) 
            : base(hovaten, ngaysinh, gioitinh)
        {
            this.Mssv = mssv;
            this.Nganhhoc= nganhhoc;
            this.Dtb = dtb;
        }

    }
}
