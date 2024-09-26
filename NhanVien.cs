using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIENVASINHVIEN_BUOI4
{
    internal class NhanVien : Nguoi
    {
        string msnv;
        string chucvu;
        string luong;

        public string Msnv { get => msnv; set => msnv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Luong { get => luong; set => luong = value; }

        public NhanVien() { }   

        public NhanVien(string hovaten,string ngaysinh,string gioitinh,string msnv,string chucvu, string luong)
            :base(hovaten,ngaysinh,gioitinh)
        {
            this.Msnv = msnv;
            this.Chucvu = chucvu;   
            this.Luong = luong;
        }


    }
}
