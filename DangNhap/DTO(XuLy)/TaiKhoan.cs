namespace QuanLyQuanCafeApp.Models
{
    public class TaiKhoan
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string MatKhau { get; set; }
        public int Hoatdong { get; set; }
        public int Phanquyen { get; set; }
        public string _PhanQuyen
        {
            get
            {
                if (Phanquyen == 1)
                    return "Admin";
                else
                    return "Staff";
            }
        }
        public string _HoatDong
        {
            get
            {
                if (Hoatdong == 1)
                    return "Active";
                else
                    return "Block";
            }
        }

    }
}
