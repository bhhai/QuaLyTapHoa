using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class Home : Form
    {
        function func = new function();
        String query;
        public Home()
        {
            InitializeComponent();
        }
        String username;
        String displayName;
        public Home(String s, String Name)
        {
            InitializeComponent();
            username = s;
            displayName = Name;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            uC_BanHang1.Visible = true;
            uC_BanHang1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(username == "User")
            {
                btnDanhMucHang.Hide();
                NCC.Hide();
                btnHangHoa.Hide();
            }

            uC_BanHang1.Visible = false;
            uC__KhachHang1.Visible = false;
            uC_NCC1.Visible = false;
            uC_LoaiHang1.Visible = false;
            uC_HangHoa1.Visible = false;
            uC_NhapHang1.Visible = false;
            uC_ThongKe1.Visible = false;
            lbDisplayName.Text = displayName;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            uC__KhachHang1.Visible = true;
            uC__KhachHang1.BringToFront();
        }

        private void NCC_Click(object sender, EventArgs e)
        {
            uC_NCC1.Visible = true;
            uC_NCC1.BringToFront();
        }

        private void btnDanhMucHang_Click(object sender, EventArgs e)
        {
            uC_LoaiHang1.Visible = true;
            uC_LoaiHang1.BringToFront();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            uC_HangHoa1.Visible = true;
            uC_HangHoa1.BringToFront();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            uC_NhapHang1.Visible = true;
            uC_NhapHang1.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            uC_ThongKe1.Visible = true;
            uC_ThongKe1.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.Show();
        }
    }  
}
