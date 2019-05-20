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

namespace ThucTapNhom
{
    public partial class frm_QLNV : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        string MaNV { get; set; }
        public frm_QLNV(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        public void HienThiDSNV()
        {
            DataTable dtDSNV = DbAcessObject.HienThiDSNV(con);
            dgvDSNV.DataSource = dtDSNV;
        }
        
        public void HienThiDSChucVu()
        {
            DataTable dtDSChucVu = DbAcessObject.HienThiDSChucVu(con);
            cbbChucVu.DataSource = dtDSChucVu;
            cbbChucVu.DisplayMember = "ChucVu";
            cbbChucVu.ValueMember = "ChucVu";
        }
        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            DataTable dt = DbAcessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt.Rows[0][0];

            HienThiDSNV();
            HienThiDSChucVu();       
        }

        private void btnDanhSachNV_Click(object sender, EventArgs e)
        {
            HienThiDSNV();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.SetData(txtMaNV.Text, txtTenNV.Text, cbbGioiTinh.Text, txtDiaChi.Text, txtSĐT.Text, cbbChucVu.Text);

            try
            {
                int ret = DbAcessObject.ThemNV(con, nv);
                HienThiDSNV();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi không thêm được!");
            }            
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Chú ý",  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAcessObject.XoaNV(con, txtMaNV.Text);
                HienThiDSNV();
            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.SetData(txtMaNV.Text, txtTenNV.Text, cbbGioiTinh.Text, txtDiaChi.Text, txtSĐT.Text, cbbChucVu.Text);

            DbAcessObject.CapNhatNV(con, nv);
            HienThiDSNV();
            MessageBox.Show("Cập nhật nhân viên thành công!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(rdbTheoTen.Checked == true)
            {
                DataTable dt = DbAcessObject.TimNVTheoTen(con, txtTimKiem.Text);
                dgvDSNV.DataSource = dt;
            }
            else if(rdbTheoChucVu.Checked == true)
            {
                DataTable dt = DbAcessObject.TimNVTheoChucVu(con, txtTimKiem.Text);
                dgvDSNV.DataSource = dt;
            }
            else if(rdbTheoGioiTinh.Checked == true)
            {
                DataTable dt = DbAcessObject.TimNVTheoGioiTinh(con, txtTimKiem.Text);
                dgvDSNV.DataSource = dt;
            }
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvDSNV.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvDSNV.CurrentRow.Cells[1].Value.ToString();
            cbbGioiTinh.Text = dgvDSNV.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDSNV.CurrentRow.Cells[3].Value.ToString();
            txtSĐT.Text = dgvDSNV.CurrentRow.Cells[4].Value.ToString();
            cbbChucVu.Text = dgvDSNV.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
