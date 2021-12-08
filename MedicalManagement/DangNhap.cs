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
    public partial class DangNhap : Form
    {
        function func = new function();
        String query;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            query = "select count(*) from TaiKhoan where username = '" + txtTK.Text + "' and password = '" + txtMK.Text + "' and role = '"+cbQuyen.SelectedIndex+"'";
            DataSet ds = func.getData(query);
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if(count == 1)
            {
                if(cbQuyen.SelectedItem.ToString() == "Admin")
                {
                    Home frmhome = new Home("Admin", txtTK.Text);
                    frmhome.Show();
                    this.Hide();
                } else if(cbQuyen.SelectedItem.ToString() == "User")
                {
                    Home frmhome = new Home("User", txtTK.Text);
                    frmhome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("abc");
                }

            } else if (txtTK.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tài khoản/mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                txtMK.Clear();
            }
            
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            // btn close Application
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTK.Focus();
        }
    }
}
