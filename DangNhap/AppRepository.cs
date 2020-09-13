using QuanLyQuanCafeApp.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models
{
    public class AppRepository
    {
        TaiKhoanRepository taiKhoan;
        MonRepository mon;
        ThucDonRepository thucDon;
        BanRepository ban;
        MenuDAO menu;
        HoaDonDAO hoadon;
        ChiTietHoaDonDAO chitiethoadon;

        //
        public ChiTietHoaDonDAO ChiTietHoaDon
        {
            get
            {
                if (chitiethoadon == null)
                {
                    chitiethoadon = new ChiTietHoaDonDAO();
                }
                return chitiethoadon;
            }
        }
        public HoaDonDAO HoaDon
        {
            get
            {
                if (hoadon == null)
                {
                    hoadon = new HoaDonDAO();
                }
                return hoadon;
            }
        }
        public MenuDAO Menu
        {
            get
            {
                if (menu == null)
                {
                    menu = new MenuDAO();
                }
                return menu;
            }
        }
        public TaiKhoanRepository TaiKhoan
        {
            get
            {
                if(taiKhoan ==null )
                {
                    taiKhoan = new TaiKhoanRepository();
                }
                return taiKhoan;
            }
        }
        public MonRepository Mon
        {
            get
            {
                if(mon == null)
                {
                    mon = new MonRepository();
                }
                return mon;
            }
        }
        public ThucDonRepository ThucDon
        {
            get
            {
                if(thucDon == null)
                {
                    thucDon = new ThucDonRepository();
                }
                return thucDon;
            }
        }
        public BanRepository Ban
        {
            get
            {
                if(ban == null)
                {
                    ban = new BanRepository();
                }
                return ban;
            }
        }
    }
}
