using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom.GUI;

namespace ThucTapNhom
{
    public partial class frm_MenuChucNang : Form
    {
        public string MaNV { get; set; }
        private int QuyenTruyCap { get; set; }
        public frm_MenuChucNang(string MaNV, int QuyenTruyCap)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.QuyenTruyCap = QuyenTruyCap;
        }

        private void frm_MenuChucNang_Load(object sender, EventArgs e)
        {
            if(QuyenTruyCap == 3)
            {
                picQLNV.Visible = false;
                lbQLNV.Visible = false;
                picQLTP.Visible = false;
                lbQLTP.Visible = false;
                picQLMonAn.Visible = false;
                lbQLMonAn.Visible = false;
            }
            else if(QuyenTruyCap == 5)
            {
                picQLNV.Visible = false;
                lbQLNV.Visible = false;
                picQLOrder.Visible = false;
                lbQLOrder.Visible = false;
                picQLMonAn.Visible = false;
                lbQLMonAn.Visible = false;
            }
            else if(QuyenTruyCap == 4)
            {
                picQLNV.Visible = false;
                lbQLNV.Visible = false;
                picQLOrder.Visible = false;
                lbQLOrder.Visible = false;
                picQLTP.Visible = false;
                lbQLTP.Visible = false;
            }
            else if(QuyenTruyCap == 2)
            {
                picQLOrder.Visible = false;
                lbQLOrder.Visible = false;
                picQLTP.Visible = false;
                lbQLTP.Visible = false;
                picQLMonAn.Visible = false;
                lbQLMonAn.Visible = false;
            }
        }

        private void picQLOrder_Click(object sender, EventArgs e)
        {
            frm_ChonBanAn frmBanAn = new frm_ChonBanAn(MaNV);
            frmBanAn.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms.OfType<frm_DangNhap>().ToList()[0].Show();        
        }

        private void picQLNV_Click(object sender, EventArgs e)
        {
            frm_QLNV frmQLNV = new frm_QLNV(MaNV);
            frmQLNV.ShowDialog();
        }

        private void picQLTP_Click(object sender, EventArgs e)
        {
            frm_QuanLyThucPham frmQLTP = new frm_QuanLyThucPham(MaNV);
            frmQLTP.ShowDialog();
        }

        private void picQLMonAn_Click(object sender, EventArgs e)
        {
            frm_QLMonAn frmQLMonAn = new frm_QLMonAn();
            frmQLMonAn.ShowDialog();
        }
    }
}
