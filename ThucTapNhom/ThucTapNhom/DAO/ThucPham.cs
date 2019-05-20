using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom.DAO
{
    class ThucPham
    {
        public string MaThucPham { get; set; }
        public string TenThucPham { get; set; }
        public int DonGia { get; set; }
        public string DVT { get; set; }

        public void SetData(string MaTP, string TenTP, int DonGia, string DVT)
        {
            MaThucPham = MaTP;
            TenThucPham = TenTP;
            this.DonGia = DonGia;
            this.DVT = DVT;
        }
    }
}
