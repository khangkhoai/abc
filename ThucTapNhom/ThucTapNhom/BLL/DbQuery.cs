using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom.DAO;

namespace ThucTapNhom.BLL
{
    class DbQuery
    {
        public int LayQuyenTruyCap(SqlConnection con, string MaNV, string MK)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_LayQuyenTruyCap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            cmd.Parameters.AddWithValue("MK", MK);
            SqlParameter QuyenTruyCapParam = new SqlParameter("@Permission", SqlDbType.Int);
            QuyenTruyCapParam.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(QuyenTruyCapParam);
            cmd.ExecuteNonQuery();
            int QuyenTruyCap = int.Parse(QuyenTruyCapParam.Value.ToString());
            return QuyenTruyCap;
        }
        public DataTable HienThiDSNV(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiDSChucVu(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSChucVu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemNV(SqlConnection con, NhanVien nv)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("DiaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("DienThoai", nv.SDT);
            cmd.Parameters.AddWithValue("ChucVu", nv.ChucVu);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaNV(SqlConnection con, string MaNV)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int CapNhatNV(SqlConnection con, NhanVien nv)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("DiaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("DienThoai", nv.SDT);
            cmd.Parameters.AddWithValue("ChucVu", nv.ChucVu);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public DataTable TimNVTheoTen(SqlConnection con, string TenNV)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoTen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TenNV", "%" + TenNV + "%");
            cmd.Parameters["TenNV"].Direction = ParameterDirection.Input;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimNVTheoChucVu(SqlConnection con, string ChucVu)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoChucVu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ChucVu", "%" + ChucVu + "%");
            cmd.Parameters["ChucVu"].Direction = ParameterDirection.Input;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimNVTheoGioiTinh(SqlConnection con, string GioiTinh)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoGioiTinh", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("GioiTinh", "%" + GioiTinh + "%");
            cmd.Parameters["GioiTinh"].Direction = ParameterDirection.Input;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiBanAn(SqlConnection con, string MaSoBan)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiBanAn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaSoBan", MaSoBan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiTenNV(SqlConnection con, string MaNV)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiTenNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiNhomMon(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiNhomMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiMonAn(SqlConnection con, string MaNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiMonAn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemPYC(SqlConnection con, int MaSoBan)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemPYC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NgayYC", DateTime.Now);
            cmd.Parameters.AddWithValue("MaBan", MaSoBan);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public DataTable HienThiPYC(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiMaPhieuYeuCau", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NgayYC", DateTime.Now);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int KiemTraBanAnDuocDatChua(SqlConnection con, int MaSoBan)
        {           
            SqlCommand cmd = new SqlCommand("QLNhaHang_KiemTraBanAnDuocDatChua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaBan", MaSoBan);
            SqlParameter MaPYCParam = new SqlParameter("@MaPYC", SqlDbType.Int);
            MaPYCParam.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(MaPYCParam);
            cmd.ExecuteNonQuery();
            int MaPYC = int.Parse(MaPYCParam.Value.ToString());
            return MaPYC;
        }

        public DataTable HienThiDatMon(SqlConnection con, string MaPYC)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDatMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPYC", MaPYC);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ThemDatMon(SqlConnection con, int MaPYC, string MaMon, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemDatMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPYC", MaPYC);
            cmd.Parameters.AddWithValue("MaMon", MaMon);
            cmd.Parameters.AddWithValue("SoLuong", SoLuong);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public int KiemTraKHCoTrongDbKhong(SqlConnection con, string SDT)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_KiemTraKHcotrongDbkhong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SDT", SDT);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            int ret = da.Fill(dt);
            return ret;
        }

        public int ThanhToanHoaDon(SqlConnection con, int MaPYC, string MaNV, string SDT)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThanhToanHoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NgayHD", DateTime.Now);
            cmd.Parameters.AddWithValue("MaPYC", MaPYC);
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            cmd.Parameters.AddWithValue("SDT", SDT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public int GiaiPhongBan(SqlConnection con, string MaBan)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_GiaiPhongBan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaBan", MaBan);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public int ThemKH(SqlConnection con, KhachHang kh)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("GioiTinh", kh.GioiTinh);
            cmd.Parameters.AddWithValue("DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("SDT", kh.SDT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public DataTable HienThiDSThucPham(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiThucPhamKhongBaoGomSoLuong(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from ThucPham", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemThucPham(SqlConnection con, ThucPham tp)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaTP", tp.MaThucPham);
            cmd.Parameters.AddWithValue("TenTP", tp.TenThucPham);
            cmd.Parameters.AddWithValue("DonGia", tp.DonGia);
            cmd.Parameters.AddWithValue("DVT", tp.DVT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaThucPham(SqlConnection con, string MaTP)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaTP", MaTP);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaThucPham(SqlConnection con, ThucPham tp)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaTP", tp.MaThucPham);
            cmd.Parameters.AddWithValue("TenTP", tp.TenThucPham);
            cmd.Parameters.AddWithValue("DonGia", tp.DonGia);
            cmd.Parameters.AddWithValue("DVT", tp.DVT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public DataTable HienThiNhaCungCap(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemNCC(SqlConnection con, NhaCungCap ncc)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNCC", ncc.MaNCC);
            cmd.Parameters.AddWithValue("TenNCC", ncc.TenNCC);
            cmd.Parameters.AddWithValue("DiaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("SDT", ncc.SDT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaNCC(SqlConnection con, NhaCungCap ncc)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNCC", ncc.MaNCC);
            cmd.Parameters.AddWithValue("TenNCC", ncc.TenNCC);
            cmd.Parameters.AddWithValue("DiaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("SDT", ncc.SDT);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaNCC(SqlConnection con, string MaNCC)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNCC",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNCC", MaNCC);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public DataTable HienThiPhieuNhap(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemPhieuNhap(SqlConnection con, string MaPN, DateTime NgayNhap, string MaNV, string MaNCC)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPhieuNhap", MaPN);
            cmd.Parameters.AddWithValue("NgayNhap", NgayNhap);
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            cmd.Parameters.AddWithValue("MaNCC", MaNCC);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaPhieuNhap(SqlConnection con, string MaPN, DateTime NgayNhap, string MaNV, string MaNCC)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPhieuNhap", MaPN);
            cmd.Parameters.AddWithValue("NgayNhap", NgayNhap);
            cmd.Parameters.AddWithValue("MaNV", MaNV);
            cmd.Parameters.AddWithValue("MaNCC", MaNCC);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaPhieuNhap(SqlConnection con, string MaPN)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPhieuNhap", MaPN);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public DataTable HienThiNhapThucPham (SqlConnection con, string MaPN)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiNhapThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPhieuNhap", MaPN);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemNhapThucPham(SqlConnection con, string MaPN, string MaTP, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNhapThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPN", MaPN);
            cmd.Parameters.AddWithValue("MaThucPham", MaTP);
            cmd.Parameters.AddWithValue("SoLuong", SoLuong);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaNhapThucPham(SqlConnection con, string MaPN, string MaTP, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNhapThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPN", MaPN);
            cmd.Parameters.AddWithValue("MaThucPham", MaTP);
            cmd.Parameters.AddWithValue("SoLuong", SoLuong);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaNhapThucPham(SqlConnection con, string MaPN, string MaTP)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNhapThucPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaPN", MaPN);
            cmd.Parameters.AddWithValue("MaThucPham", MaTP);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int ThemNhomMonAn(SqlConnection con, string MaNhomMon, string TenNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNhomMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            cmd.Parameters.AddWithValue("TenNhomMOn", TenNhomMon);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaNhomMonAn(SqlConnection con, string MaNhomMon, string TenNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNhomMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            cmd.Parameters.AddWithValue("TenNhomMOn", TenNhomMon);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaNhomMonAn(SqlConnection con, string MaNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNhomMon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int ThemMonAn(SqlConnection con, string MaMon, string TenMon, int DonGia, string MaNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemMonAn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            cmd.Parameters.AddWithValue("MaMon", MaMon);
            cmd.Parameters.AddWithValue("TenMon", TenMon);
            cmd.Parameters.AddWithValue("DonGia", DonGia);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int SuaMonAn(SqlConnection con, string MaMon, string TenMon, int DonGia, string MaNhomMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaMonAn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaNhomMon", MaNhomMon);
            cmd.Parameters.AddWithValue("MaMon", MaMon);
            cmd.Parameters.AddWithValue("TenMon", TenMon);
            cmd.Parameters.AddWithValue("DonGia", DonGia);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int XoaMonAn(SqlConnection con, string MaMon)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_XoaMonAn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaMon", MaMon);
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }
    }
}
