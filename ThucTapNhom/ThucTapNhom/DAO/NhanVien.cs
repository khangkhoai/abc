using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom.DAO
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }

        public void SetData(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SDT, string ChucVu)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.ChucVu = ChucVu;
        }
    }
}
