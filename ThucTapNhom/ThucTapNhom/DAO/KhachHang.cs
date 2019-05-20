using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom.DAO
{
    class KhachHang
    {
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public void SetData(string TenKH, string GioiTinh, string DiaChi, string SDT)
        {
            this.TenKH = TenKH;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
