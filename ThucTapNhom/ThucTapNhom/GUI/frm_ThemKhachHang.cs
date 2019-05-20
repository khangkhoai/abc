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
    public partial class frm_ThemKhachHang : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = null;
        string SDT { get; set; }
        public frm_ThemKhachHang(string SDT)
        {
            InitializeComponent();
            DbAcessObject = new DbQuery();
            this.SDT = SDT;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.SetData(txtTenKH.Text, cbbGioiTinh.Text, txtDiaChi.Text, txtSĐT.Text);

            DbAcessObject.ThemKH(con, kh);

            if (MessageBox.Show("Thêm khách hàng thành công!") == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frm_ThemKhachHang_Load(object sender, EventArgs e)
        {
            txtSĐT.Text = SDT;
        }
    }
}
