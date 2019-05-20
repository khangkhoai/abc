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
using ThucTapNhom.DAO;

namespace ThucTapNhom.GUI
{
    public partial class frm_QuanLyThucPham : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAccessObject = null;
        public string MaNV { get; set; }
        public frm_QuanLyThucPham(string MaNV)
        {
            InitializeComponent();
            DbAccessObject = new DbQuery();
            this.MaNV = MaNV;
        }

        private void tpDSThucPham_Enter(object sender, EventArgs e)
        {
            DataTable dt = DbAccessObject.HienThiDSThucPham(con);
            dgvDSThucPham.DataSource = dt;
        }

        private void HienThiDSTP()
        {
            DataTable dt = DbAccessObject.HienThiThucPhamKhongBaoGomSoLuong(con);
            dgvDSThemThucPham.DataSource = dt;
        }

        private void tpThemThucPham_Enter(object sender, EventArgs e)
        {
            HienThiDSTP();
        }

        private void btnThemTP_Click(object sender, EventArgs e)
        {
            ThucPham tp = new ThucPham();
            tp.SetData(txtMaTP.Text, txtTenTP.Text, int.Parse(txtDonGiaTP.Text), txtDVT.Text);

            try
            {
                DbAccessObject.ThemThucPham(con, tp);
                MessageBox.Show("Thêm thành công!");
                HienThiDSTP();
            }
            catch(SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
            
        }

        private void dgvDSThemThucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTP.Text = dgvDSThemThucPham.CurrentRow.Cells[0].Value.ToString();
            txtTenTP.Text = dgvDSThemThucPham.CurrentRow.Cells[1].Value.ToString();
            txtDonGiaTP.Text = dgvDSThemThucPham.CurrentRow.Cells[2].Value.ToString();
            txtDVT.Text = dgvDSThemThucPham.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoaTP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaThucPham(con, txtMaTP.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiDSTP();
            }          
        }

        private void btnSuaTP_Click(object sender, EventArgs e)
        {
            ThucPham tp = new ThucPham();
            tp.SetData(txtMaTP.Text, txtTenTP.Text, int.Parse(txtDonGiaTP.Text), txtDVT.Text);

            if(DbAccessObject.SuaThucPham(con, tp) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiDSTP();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
            
        }

        private void HienThiNCC()
        {
            DataTable dt = DbAccessObject.HienThiNhaCungCap(con);
            dgvDSNCC.DataSource = dt;
        }

        private void tpNCC_Enter(object sender, EventArgs e)
        {
            HienThiNCC();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.SetData(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);

            try
            {
                DbAccessObject.ThemNCC(con, ncc);
                MessageBox.Show("Thêm thành công!");
                HienThiNCC();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvDSNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvDSNCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDSNCC.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvDSNCC.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.SetData(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);

            if (DbAccessObject.SuaNCC(con, ncc) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiNCC();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaNCC(con, txtMaNCC.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiNCC();
            }
        }

        private void HienThiPhieuNhap()
        {
            DataTable dt = DbAccessObject.HienThiPhieuNhap(con);
            dgvPhieuNhap.DataSource = dt;
        }

        private void tpNhapThucPham_Enter(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            dtpNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            txtMaNCC_PhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccessObject.ThemPhieuNhap(con, txtMaPhieuNhap.Text, dtpNgayNhap.Value, txtMaNV.Text, txtMaNCC_PhieuNhap.Text);
                MessageBox.Show("Thêm thành công!");
                HienThiPhieuNhap();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            if (DbAccessObject.SuaPhieuNhap(con, txtMaPhieuNhap.Text, dtpNgayNhap.Value, txtMaNV.Text, txtMaNCC_PhieuNhap.Text) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiPhieuNhap();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaPhieuNhap(con, txtMaPhieuNhap.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiPhieuNhap();
            }
        }

        private void btnNhapThucPham_Click(object sender, EventArgs e)
        {
            frm_NhapThucPhamVaoPhieuNhap frmNhapTPvaoPN = new frm_NhapThucPhamVaoPhieuNhap(txtMaPhieuNhap.Text, MaNV);
            frmNhapTPvaoPN.ShowDialog();
        }

        private void frm_QuanLyThucPham_Load(object sender, EventArgs e)
        {
            DataTable dt = DbAccessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt.Rows[0][0];
        }
    }
}
