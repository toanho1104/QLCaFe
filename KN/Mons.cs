using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN
{
    public class Thucdons
    {
        qlcfDataContext qlcf= new qlcfDataContext();
        public Thucdons()
        {

        }
        public IQueryable getthucdon()
        {
            var thucdons = from td in qlcf.Mons select td;
            return thucdons;
        }

    }
    
    
}
