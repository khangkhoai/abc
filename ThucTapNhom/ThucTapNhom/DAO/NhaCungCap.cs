using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom.DAO
{
    class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public void SetData (string MaNCC, string TenNCC, string SDT, string DiaChi)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
        }
    }
}
