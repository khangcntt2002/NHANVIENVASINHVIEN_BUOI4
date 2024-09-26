namespace NHANVIENVASINHVIEN_BUOI4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        List<SinhVien> danhsach1 = new List<SinhVien>();

        //khai báo nút "thêm"
        private void bnt_Them_Click(object sender, EventArgs e)
        {
            double diemtb;
            if (double.TryParse(txt_diemtb.Text, out diemtb))
            {
                SinhVien sinhVien = new SinhVien(txt_hoten.Text, dt_ngaysinh.Value.ToString(), txt_gioitinh.Text, txt_mssv.Text, txt_nganhhoc.Text, diemtb);

                danhsach1.Add(sinhVien);
                dt_1.DataSource = null;
                dt_1.DataSource = danhsach1;
            }
            else
            {
                MessageBox.Show("Bạn Cần Điền Đầy Đủ Thông Tin ở bảng trên: ");
            }

        }
        // code của nút "sửa"
        private void bnt_sua_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in danhsach1)
            {
                if (i.Mssv == txt_mssv.Text)
                {
                    i.Hovaten = txt_hoten.Text;
                    i.Dtb = double.Parse(txt_diemtb.Text);
                }
                

            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;
        }
            // Code Nút Xóa 
        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in danhsach1)
            {
                if (i.Mssv == txt_mssv.Text)
                {
                    danhsach1.Remove(i);
                    break;
                }
                
            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;
        }

        List<NhanVien> danhsach2 = new List<NhanVien>();
        private void bnt_them2_Click(object sender, EventArgs e)
        {
            double luong;
            if (double.TryParse(txt_luong.Text, out luong))
            {
                NhanVien nhanVien = new NhanVien(txt_hoten2.Text, dt_ngaysinh2.Value.ToString(), txt_gioitinh2.Text, txt_msnv.Text, txt_chucvu.Text, luong.ToString());
                danhsach2.Add(nhanVien);
                dt_2.DataSource = null;
                dt_2.DataSource = danhsach2;
            }
            else
            {
                MessageBox.Show("Bạn Cần Điền Đầy Đủ Thông Tin ở Bảng Trên: ");
            }
        }

        private void bnt_sua2_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in danhsach2)
            {
                if (i.Msnv == txt_mssv.Text)
                {
                    i.Hovaten = txt_hoten2.Text;
                    i.Luong = txt_luong.Text;

                }
                
            }
            dt_2.DataSource = null;
            dt_2.DataSource = danhsach2;
        }

        private void bnt_xoa2_Click(object sender, EventArgs e)
        {
            foreach(NhanVien i in danhsach2)
            {
               if (i.Msnv == txt_msnv.Text)
                {
                    danhsach2.Remove(i);
                }
                dt_2.DataSource = null;
                dt_2.DataSource = danhsach2;

            }
            dt_2.DataSource = null;
            dt_2.DataSource = danhsach2;
        }
    }
}
