using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafeApp.Models;
namespace DangNhap
{
    public partial class fDangNhap : Form
    {
        AppRepository app = new AppRepository();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txttendangnhap.Text) || string.IsNullOrEmpty(this.txtmatkhau.Text))
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin");
            }
            else
            {
                int ret;
                TaiKhoan obj = app.TaiKhoan.Login(this.txttendangnhap.Text, this.txtmatkhau.Text, out ret);
                if (obj == null)
                {
                    string[] error = { "UserName Không tồn tại", "Sai mật khẩu" };
                    MessageBox.Show(error[ret]);
                }
                else
                {
                    if (obj.Hoatdong == 0)
                    {
                        MessageBox.Show("Tài Khoản hiện tại đã bị khóa!!!");
                    }
                    else
                    {
                        this.Hide();
                        fMain frm = new fMain(obj);
                        frm.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy thao tác và đóng chương trình", "thông bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
