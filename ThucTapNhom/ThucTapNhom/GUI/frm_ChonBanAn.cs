using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom
{
    public partial class frm_ChonBanAn : Form
    {
        string MaNV { get; set; }
        public frm_ChonBanAn(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void HienThiFrmPYC(string idBan)
        {
            frm_PhieuYeuCau frm = new frm_PhieuYeuCau(idBan, MaNV);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HienThiFrmPYC("7");
        }
    }
}
