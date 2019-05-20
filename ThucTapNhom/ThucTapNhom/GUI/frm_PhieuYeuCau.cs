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
    public partial class frm_PhieuYeuCau : Form
    {
        SqlConnection con = Program.con;
        private DbQuery DbAccessObject = null;
        string MaSoBan = "";
        string MaNV { get; set; }
        public frm_PhieuYeuCau(string idBan, string MaNV)
        {
            InitializeComponent();
            MaSoBan = idBan;
            this.MaNV = MaNV;
            DbAccessObject = new DbQuery();
        }
        // Placeholder cho textbox TimKiem
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập SĐT khách hàng...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập SĐT khách hàng...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }
        // Thay doi mau sac cho button Bàn ăn khi lap phieu yeu cau moi
        public void ChangeColorOfBtnChonBanAn(Color color)
        {
            foreach (frm_ChonBanAn oFrm in Application.OpenForms.OfType<frm_ChonBanAn>())
            {
                switch (MaSoBan)
                {
                    case "1":
                        oFrm.button1.BackColor = color;
                        break;
                    case "2":
                        oFrm.button2.BackColor = color;
                        break;
                    case "3":
                        oFrm.button3.BackColor = color;
                        break;
                    case "4":
                        oFrm.button4.BackColor = color;
                        break;
                    case "5":
                        oFrm.button5.BackColor = color;
                        break;
                    case "6":
                        oFrm.button6.BackColor = color;
                        break;
                    case "7":
                        oFrm.button7.BackColor = color;
                        break;
                    default:
                        break;
                }
            }
        }

        public void HienThiBanDau()
        {
            DataTable dt = DbAccessObject.HienThiBanAn(con, MaSoBan);
            lbBan.Text += " " + dt.Rows[0][0] + " " + dt.Rows[0][1];

            DataTable dt1 = DbAccessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt1.Rows[0][0];
        }

        public void HienThiNhomMon()
        {
            DataTable dt = DbAccessObject.HienThiNhomMon(con);
            dgvDSLoaiMon.DataSource = dt;
        }

        public void HienThiMonAn(string MaNhomMon)
        {
            DataTable dt = DbAccessObject.HienThiMonAn(con, MaNhomMon);
            dgvDSMon.DataSource = dt;
        }
        public void HienThiDatMon(string MaPYC)
        {
            DataTable dt = DbAccessObject.HienThiDatMon(con, MaPYC);
            dgvThongTinPYC.DataSource = dt;
        }
        public void HienThiPYC()
        {
            DataTable dt = DbAccessObject.HienThiPYC(con);
            lbMaPYC.Text += dt.Rows[0][0];
        }
        private void frm_PhieuYeuCau_Load(object sender, EventArgs e)
        {
            HienThiBanDau();
            int MaPYC = DbAccessObject.KiemTraBanAnDuocDatChua(con, int.Parse(MaSoBan));
            if (MaPYC != 0)
            {
                HienThiNhomMon();
                HienThiDatMon(MaPYC.ToString());
                lbMaPYC.Text += MaPYC.ToString();
                lbNgayPYC.Text += " " + DateTime.Now.ToString("dd/MM/yy"); ;
                btnThemPYC.Visible = false;
                btnGiaiPhong.Visible = true;
            }
        }

        private void btnThemPYC_Click(object sender, EventArgs e)
        {
            string dateNow = DateTime.Now.ToString("dd/MM/yy");
            lbNgayPYC.Text += " " + dateNow;
            btnGiaiPhong.Visible = true;
            btnThemPYC.Visible = false;

            HienThiNhomMon();

            DbAccessObject.ThemPYC(con, int.Parse(MaSoBan));
            HienThiPYC();

            ChangeColorOfBtnChonBanAn(Color.Red);         
        }

        private void dgvDSLoaiMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiMonAn(dgvDSLoaiMon.CurrentRow.Cells[0].Value.ToString());
            lbLoaiMon.Text = "Loại món: " + dgvDSLoaiMon.CurrentRow.Cells[1].Value.ToString();
        }  

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!");
            }
            else
            {
                string MaPYC = lbMaPYC.Text.Split(':')[1];
                DbAccessObject.ThemDatMon(con, int.Parse(MaPYC), dgvDSMon.CurrentRow.Cells[2].Value.ToString(), int.Parse(txtSoLuong.Text));     
                HienThiDatMon(MaPYC);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int ret = DbAccessObject.KiemTraKHCoTrongDbKhong(con, txtTimKiem.Text);
            if(ret == 0)
            {
                if(MessageBox.Show("Khách hàng không tồn tại! Nhấn để thêm thông tin khách hàng") == DialogResult.OK);
                {
                    frm_ThemKhachHang frmThemKH = new frm_ThemKhachHang(txtTimKiem.Text);
                    frmThemKH.ShowDialog();
                }
            }
            else
            {
                string MaPYC = lbMaPYC.Text.Split(':')[1];
                DbAccessObject.ThanhToanHoaDon(con, int.Parse(MaPYC), MaNV, txtTimKiem.Text);

                frm_ThanhToan frmThanhToan = new frm_ThanhToan(MaSoBan, MaNV, MaPYC, txtTimKiem.Text);
                frmThanhToan.Show();
            }
        }

        private void frm_PhieuYeuCau_FormClosing(object sender, FormClosingEventArgs e)
        {
                      
        }

        public void GiaiPhongDuLieuTrenForm()
        {
            dgvDSLoaiMon.DataSource = null;
            dgvThongTinPYC.DataSource = null;
            dgvDSMon.DataSource = null;
            lbMaPYC.Text = "Mã phiếu order:";
            lbNgayPYC.Text = "Ngày lập phiếu order:";
            lbLoaiMon.Text = "Loại món:";
            lbTenMon.Text = "Tên món:";
            lbDonGia.Text = "Đơn giá:";
        }

        private void btnGiaiPhong_Click(object sender, EventArgs e)
        {
            DbAccessObject.GiaiPhongBan(con, MaSoBan);

            btnGiaiPhong.Visible = false;
            btnThemPYC.Visible = true;
            ChangeColorOfBtnChonBanAn(Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(126)))), ((int)(((byte)(3))))));
            GiaiPhongDuLieuTrenForm();
        }

        private void dgvDSMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTenMon.Text = "Tên món: " + dgvDSMon.CurrentRow.Cells[0].Value.ToString();
            lbDonGia.Text = "Đơn giá: " + dgvDSMon.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
