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
    public partial class frm_ThanhToan : Form
    {
        SqlConnection con = Program.con;
        string idBan { get; set; }
        string MaNV { get; set; }
        string MaPYC { get; set; }
        string SDT { set; get; }

        DbQuery DbAcessObject = null;
        public frm_ThanhToan(string idBan, string MaNV, string MaPYC, string SDT)
        {
            InitializeComponent();
            this.idBan = idBan;
            this.MaNV = MaNV;
            this.MaPYC = MaPYC;
            this.SDT = SDT;
            DbAcessObject = new DbQuery();
        }

        public void HienThiBanDau()
        {
            DataTable dt = DbAcessObject.HienThiBanAn(con, idBan);
            lbBan.Text += " " + dt.Rows[0][0] + " " + dt.Rows[0][1];

            DataTable dt1 = DbAcessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += " " + dt1.Rows[0][0];

            lbNgayHD.Text += " "+ DateTime.Now.ToString("dd/MM/yy");

            lbSDT.Text += " "+ SDT;
        }

        public void HienThiHD()
        {
            DataTable dt = DbAcessObject.HienThiDatMon(con, MaPYC);
            dgvThongTinHD.DataSource = dt;

            int TongTien = 0;
            foreach(DataRow dr in dt.Rows)
            {
                TongTien += int.Parse(dr[2].ToString())*int.Parse(dr[1].ToString());
            }
            txtTongTien.Text = TongTien.ToString();
        }

        private void frm_PhucVuKH_Load(object sender, EventArgs e)
        {
            HienThiBanDau();
            HienThiHD();
        }

        private void txtTienKhach_Leave(object sender, EventArgs e)
        {
            txtTongThua.Text = (int.Parse(txtTienKhach.Text) - int.Parse(txtTongTien.Text)).ToString();
        }
    }
}
