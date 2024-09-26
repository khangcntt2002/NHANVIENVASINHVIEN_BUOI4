using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIENVASINHVIEN_BUOI4
{
    internal class Nguoi
    {
        string hovaten;
        string ngaysinh;
        string gioitinh;

        public string Hovaten { get => hovaten; set => hovaten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public Nguoi() { }  

        public Nguoi(string hovaten,string ngaysinh,string gioitinh)
        {
            this.hovaten = hovaten;
            this.ngaysinh= ngaysinh;
            this.gioitinh= gioitinh;
        }
    }
}
