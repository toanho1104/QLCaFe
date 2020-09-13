using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN
{
    public class TaiKhoans
    {
        qlcfDataContext dt = new qlcfDataContext();
        public TaiKhoans()
        {

        }
        public IQueryable gettaikhoans()
        {
            var taikhoan = from tk in dt.TaiKhoans select tk;
            return taikhoan;
        }
    }
    
}
