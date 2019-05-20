using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom.BLL;

namespace ThucTapNhom.GUI
{
    public partial class frm_NhapThucPhamVaoPhieuNhap : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAccessObject = new DbQuery();
        string MaPhieuNhap { get; set; }
        string MaNV { get; set; }
        public frm_NhapThucPhamVaoPhieuNhap(string MaPhieuNhap, string MaNV)
        {
            InitializeComponent();
            this.MaPhieuNhap = MaPhieuNhap;
            this.MaNV = MaNV;
        }

        private void HienThiNhapThucPham()
        {
            DataTable dt = DbAccessObject.HienThiNhapThucPham(con, MaPhieuNhap);
            dgvNhapThucPham.DataSource = dt;
        }

        private void frm_NhapThucPhamVaoPhieuNhap_Load(object sender, EventArgs e)
        {
            lbMaPN.Text += " " + MaPhieuNhap;
            HienThiNhapThucPham();

            DataTable dt = DbAccessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt.Rows[0][0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccessObject.ThemNhapThucPham(con, MaPhieuNhap, txtMaTP.Text, int.Parse(txtSoLuong.Text));
                MessageBox.Show("Thêm thành công!");
                HienThiNhapThucPham();
            }
            catch(SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void dgvNhapThucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTP.Text = dgvNhapThucPham.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvNhapThucPham.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(DbAccessObject.SuaNhapThucPham(con, MaPhieuNhap, txtMaTP.Text, int.Parse(txtSoLuong.Text)) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiNhapThucPham();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaNhapThucPham(con, MaPhieuNhap, txtMaTP.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiNhapThucPham();
            }
        }
    }
}
