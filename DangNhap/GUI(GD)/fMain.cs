using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafeApp.Models;
using QuanLyQuanCafeApp.Models.DTO;


namespace DangNhap
{
    public partial class fMain : Form
    {
        AppRepository app = new AppRepository();
        private TaiKhoan loginAccount;
        SqlDataAdapter da_Ban;
        DataSet ds;
        public fMain(TaiKhoan acc)
        {
            this.loginAccount = acc;
            InitializeComponent(); ds = new DataSet();
            adminToolStripMenuItem.Enabled = acc.Phanquyen == 1;     //Phân quyền giữa Admin và Nhân viên
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + acc.FullName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChinh f = new fChinh();
            
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThongTinTaiKhoan f = new fThongTinTaiKhoan(loginAccount);
            f.ShowDialog();
            this.Show();
        }
        //private void frm_UpdateAccount(object sender, fThongTinTaiKhoan.ControlAccessibleObject e)
        //{
        //    thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.FullName + ")";
        //}
        private void fMain_Load(object sender, EventArgs e)
        {
            loadCboLoai();
            cboLoai.SelectedIndex = 0;
            loadCboMon();
            LoadTable();
        }
        private void LoadTable()
        {
            var Tables = app.Ban.GetBans();

            foreach (var item in Tables)
            {
                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 70;
                btn.Text = item.Name.ToString() + Environment.NewLine + item.TrangThai.ToString();
                btn.Name = item.Id.ToString();

                btn.Click += btn_Click;

                switch (item.TrangThai.ToString())
                {
                    case "Trống":
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.DarkKhaki;
                        break;
                }

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string[] nameAndStatus = btn.Text.Split('\n', '\r');
            int maBan = int.Parse((sender as Button).Name);
            lsvThucdon.Tag = ((Ban)new Ban(int.Parse(btn.Name), nameAndStatus[0], nameAndStatus[2]));
            LayThongTinHoaDon(maBan);
            hienTongTien();

        }
        void LayThongTinHoaDon(int maBan)
        {
            lsvThucdon.Items.Clear();
            List<HoaDonChiTiet> dsHDCT = app.Menu.LayMenuTuBan(maBan);

            foreach (HoaDonChiTiet hdct in dsHDCT)
            {
                ListViewItem lstvItem = new ListViewItem(hdct.TenMon.ToString());
                lstvItem.SubItems.Add(hdct.GiaBan.ToString());
                lstvItem.SubItems.Add(hdct.SoLuong.ToString());

                double thanhtien = int.Parse(hdct.GiaBan.ToString()) * int.Parse(hdct.SoLuong.ToString());
                lstvItem.SubItems.Add(thanhtien.ToString());
                lsvThucdon.Items.Add(lstvItem);
            }
        }
        private void loadCboLoai()
        {
            List<ThucDon> list = app.ThucDon.GetThucDons();
            list.Insert(0, new ThucDon { Id = 0, Name = "Tất cả" });
            cboLoai.DataSource = list;
            cboLoai.DisplayMember = "Name";
            cboLoai.ValueMember = "Id";
        }
        private void loadCboMon()
        {
            List<Mon> list = app.Mon.GetMons();
            cboMon.DataSource = list;
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "Id";
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex == 0)
            {
                loadCboMon();
            }
            else
            {
                int idThucDon = int.Parse(cboLoai.SelectedValue.ToString());
                List<Mon> list = app.Mon.getMonByIdThucDon(idThucDon);
                cboMon.DataSource = list;
                cboMon.DisplayMember = "TenMon";
                cboMon.ValueMember = "Id";
            }
        }
        private void hienTongTien()
        {
            double tongtien = 0;
            for (int i = 0; i < lsvThucdon.Items.Count; i++)
            {
                tongtien = tongtien + double.Parse(lsvThucdon.Items[i].SubItems[3].Text.ToString());
            }
            txtTongTien.Text = tongtien.ToString() + " VNĐ";
        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvThucdon.Tag as Ban;
                int maHoaDon = app.HoaDon.LayMaHoaDonTheoMaBan(ban.Id);
                int maMon = int.Parse(cboMon.SelectedValue.ToString());
                int soLuong = (int)numSoluong.Value;
                if (maHoaDon == -1)
                {
                    app.HoaDon.ThemHD(ban.Id);
                    app.ChiTietHoaDon.ThemChiTietHoaDon(app.HoaDon.LayMaHDLonNhat(),
                        maMon, soLuong);
                    ThemMon(ban);
                }
                else
                {
                    var check = app.ChiTietHoaDon.KiemTraMonAnTonTai(maHoaDon, maMon);
                    if (check)
                    {
                        app.ChiTietHoaDon.CapNhapSoLuong(maHoaDon, maMon, soLuong);
                        LayThongTinHoaDon(ban.Id);

                    }
                    else
                    {
                        app.ChiTietHoaDon.ThemChiTietHoaDon(maHoaDon, maMon, soLuong);
                    }
                }
                LayThongTinHoaDon(ban.Id);
                hienTongTien();
            }
            catch
            {
                MessageBox.Show("Chưa chọn bàn");
            }
        }
        private void ThemMon(Ban ban)
        {
            foreach (var item in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (item.Name == ban.Id.ToString())
                {
                    app.Ban.CapNhatTrangThaiBan(ban.Id, "Có người");
                    item.Text = ban.Name.ToString() + Environment.NewLine + "Có người";
                    item.BackColor = Color.DarkKhaki;
                }
            }
        }

      
        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idmon;
            int.TryParse(cboMon.SelectedValue.ToString(), out idmon);
            Mon mon = app.Mon.GetMonById(idmon);
            if (mon != null)
                txtGia.Text = mon.GiaBan.ToString();
        }
        private void ThanhToan(Ban ban)
        {
            foreach (var item in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (item.Name == ban.Id.ToString())
                {
                    app.Ban.CapNhatTrangThaiBan(ban.Id, "Trống");
                    item.Text = ban.Name.ToString() + Environment.NewLine + "Trống";
                    item.BackColor = Color.LightSkyBlue;
                }
            }
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvThucdon.Tag as Ban;
                if (ban.TrangThai != "Trống")
                {
                    int id = app.HoaDon.LayMaHoaDonTheoMaBan(ban.Id);
                    DateTime time = DateTime.Now;
                    int trangthai = 1;
                    string nguoilap = loginAccount.UserName;
                    double giamgia = double.Parse(this.txtGiam.Value.ToString());
                    double tongtien = 0;
                    for (int i = 0; i < lsvThucdon.Items.Count; i++)
                    {
                        tongtien = tongtien + double.Parse(lsvThucdon.Items[i].SubItems[3].Text.ToString());
                    }
                    tongtien = tongtien - (tongtien * giamgia / 100.0);
                    app.HoaDon.CapNhatHoaDon(id, time, trangthai, nguoilap, tongtien, giamgia);
                    ThanhToan(ban);
                    this.txtTongTien.Text = tongtien.ToString() + " VNĐ";
                    //lsvThucdon.Items.Clear();
                   // using (SaveFileDialog sfd = new SaveFileDialog()) {ContainerFilterService =}
                    Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

                    xla.Visible = true;

                    Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

                    int u = 1;

                    int j = 1;

                    foreach (ListViewItem comp in lsvThucdon.Items)
                    {

                        ws.Cells[u, j] = comp.Text.ToString();

                        //MessageBox.Show(comp.Text.ToString());

                        foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                        {

                            ws.Cells[u, j] = drv.Text.ToString();

                            j++;

                        }

                        j = 1;

                        u++;

                    }
                    lsvThucdon.Items.Clear();

                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn bàn");
            }
        }

        private void btnchuyenban_Click(object sender, EventArgs e)
        {
         
        }

             
    }
}
