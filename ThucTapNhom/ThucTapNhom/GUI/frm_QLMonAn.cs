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
    public partial class frm_QLMonAn : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAccessObject = null;
        public frm_QLMonAn()
        {
            InitializeComponent();
            DbAccessObject = new DbQuery();
        }
        private void HienThiNhomMon()
        {
            DataTable dt = DbAccessObject.HienThiNhomMon(con);
            dgvDSNhomMon.DataSource = dt;
            
        }
        private void HienThiMonAn()
        {     
            DataTable dt = DbAccessObject.HienThiMonAn(con, dgvDSNhomMon.CurrentRow.Cells[0].Value.ToString());
            dgvDSMonAn.DataSource = dt;
            

        }
        private void frm_QLMonAn_Load(object sender, EventArgs e)
        {
            HienThiNhomMon();
        }

        private void dgvDSNhomMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiMonAn();
            txtMaLoai.Text = dgvDSNhomMon.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = dgvDSNhomMon.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void btnDSLoai_Click(object sender, EventArgs e)
        {
            HienThiNhomMon();
        }

        private void btnDSMon_Click(object sender, EventArgs e)
        {
            HienThiMonAn();
        }

        private void dgvDSMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgvDSMonAn.CurrentRow.Cells[2].Value.ToString();
            txtTenMon.Text = dgvDSMonAn.CurrentRow.Cells[0].Value.ToString();
            txtDonGia.Text = dgvDSMonAn.CurrentRow.Cells[1].Value.ToString();
            txtThuocLoai.Text = dgvDSNhomMon.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccessObject.ThemNhomMonAn(con, txtMaLoai.Text, txtTenLoai.Text);
                MessageBox.Show("Thêm thành công!");
                HienThiNhomMon();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (DbAccessObject.SuaNhomMonAn(con, txtMaLoai.Text, txtTenLoai.Text) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiNhomMon();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaNhomMonAn(con, txtMaLoai.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiNhomMon();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccessObject.ThemMonAn(con, txtMaMon.Text, txtTenMon.Text, int.Parse(txtDonGia.Text), dgvDSNhomMon.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Thêm thành công!");
                HienThiNhomMon();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (DbAccessObject.SuaMonAn(con, txtMaMon.Text, txtTenMon.Text, int.Parse(txtDonGia.Text), dgvDSNhomMon.CurrentRow.Cells[0].Value.ToString()) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                HienThiMonAn();
            }
            else
            {
                MessageBox.Show("Sửa thất bại! Kiểm tra lại thông tin!");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccessObject.XoaMonAn(con, txtMaMon.Text);
                MessageBox.Show("Xoá thành công!");
                HienThiMonAn();
            }
        }
    }
}
