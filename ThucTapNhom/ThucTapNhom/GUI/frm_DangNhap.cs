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

namespace ThucTapNhom
{
    public partial class frm_DangNhap : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int QuyenTruyCap = DbAcessObject.LayQuyenTruyCap(con, txtMaNV.Text, txtMK.Text);
            if(QuyenTruyCap == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
            else if(QuyenTruyCap != 0)
            {
                
                frm_MenuChucNang frmMenu = new frm_MenuChucNang(txtMaNV.Text, QuyenTruyCap);         
                frmMenu.Show();
                txtMaNV.ResetText();
                txtMK.ResetText();
                this.Hide();
                
            }
        }
    }
}
