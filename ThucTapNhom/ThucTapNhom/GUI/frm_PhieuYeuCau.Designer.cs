namespace ThucTapNhom
{
    partial class frm_PhieuYeuCau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnGiaiPhong = new System.Windows.Forms.Button();
            this.btnThemPYC = new System.Windows.Forms.Button();
            this.lbBan = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.lbLoaiMon = new System.Windows.Forms.Label();
            this.lbNgayPYC = new System.Windows.Forms.Label();
            this.lbMaPYC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiMon = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvThongTinPYC = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            this.grbThaoTac.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiMon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPYC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameAcc
            // 
            this.lbNameAcc.AutoSize = true;
            this.lbNameAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNameAcc.Location = new System.Drawing.Point(63, 18);
            this.lbNameAcc.Name = "lbNameAcc";
            this.lbNameAcc.Size = new System.Drawing.Size(0, 13);
            this.lbNameAcc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chào!";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnThanhToan);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.grbTimKiem.Location = new System.Drawing.Point(315, 19);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(172, 106);
            this.grbTimKiem.TabIndex = 8;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Thông tin khách hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnThanhToan.Location = new System.Drawing.Point(6, 45);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(160, 55);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTimKiem.Location = new System.Drawing.Point(6, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 20);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập SĐT khách hàng...";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // grbThaoTac
            // 
            this.grbThaoTac.Controls.Add(this.btnGiaiPhong);
            this.grbThaoTac.Controls.Add(this.btnThemPYC);
            this.grbThaoTac.Controls.Add(this.lbBan);
            this.grbThaoTac.Controls.Add(this.lbDonGia);
            this.grbThaoTac.Controls.Add(this.lbTenMon);
            this.grbThaoTac.Controls.Add(this.lbLoaiMon);
            this.grbThaoTac.Controls.Add(this.lbNgayPYC);
            this.grbThaoTac.Controls.Add(this.lbMaPYC);
            this.grbThaoTac.Location = new System.Drawing.Point(12, 45);
            this.grbThaoTac.Name = "grbThaoTac";
            this.grbThaoTac.Size = new System.Drawing.Size(975, 57);
            this.grbThaoTac.TabIndex = 9;
            this.grbThaoTac.TabStop = false;
            // 
            // btnGiaiPhong
            // 
            this.btnGiaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnGiaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnGiaiPhong.Location = new System.Drawing.Point(523, 20);
            this.btnGiaiPhong.Name = "btnGiaiPhong";
            this.btnGiaiPhong.Size = new System.Drawing.Size(118, 23);
            this.btnGiaiPhong.TabIndex = 4;
            this.btnGiaiPhong.Text = "Giải phóng bàn";
            this.btnGiaiPhong.UseVisualStyleBackColor = false;
            this.btnGiaiPhong.Visible = false;
            this.btnGiaiPhong.Click += new System.EventHandler(this.btnGiaiPhong_Click);
            // 
            // btnThemPYC
            // 
            this.btnThemPYC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnThemPYC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPYC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnThemPYC.Location = new System.Drawing.Point(389, 20);
            this.btnThemPYC.Name = "btnThemPYC";
            this.btnThemPYC.Size = new System.Drawing.Size(128, 23);
            this.btnThemPYC.TabIndex = 4;
            this.btnThemPYC.Text = "Lập phiếu order mới";
            this.btnThemPYC.UseVisualStyleBackColor = false;
            this.btnThemPYC.Click += new System.EventHandler(this.btnThemPYC_Click);
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lbBan.Location = new System.Drawing.Point(15, 25);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(37, 13);
            this.lbBan.TabIndex = 0;
            this.lbBan.Text = "Bàn: ";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbDonGia.Location = new System.Drawing.Point(855, 25);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(47, 13);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbTenMon.Location = new System.Drawing.Point(749, 25);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(52, 13);
            this.lbTenMon.TabIndex = 2;
            this.lbTenMon.Text = "Tên món:";
            // 
            // lbLoaiMon
            // 
            this.lbLoaiMon.AutoSize = true;
            this.lbLoaiMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbLoaiMon.Location = new System.Drawing.Point(647, 25);
            this.lbLoaiMon.Name = "lbLoaiMon";
            this.lbLoaiMon.Size = new System.Drawing.Size(53, 13);
            this.lbLoaiMon.TabIndex = 2;
            this.lbLoaiMon.Text = "Loại món:";
            // 
            // lbNgayPYC
            // 
            this.lbNgayPYC.AutoSize = true;
            this.lbNgayPYC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNgayPYC.Location = new System.Drawing.Point(244, 25);
            this.lbNgayPYC.Name = "lbNgayPYC";
            this.lbNgayPYC.Size = new System.Drawing.Size(108, 13);
            this.lbNgayPYC.TabIndex = 2;
            this.lbNgayPYC.Text = "Ngày lập phiếu order:";
            // 
            // lbMaPYC
            // 
            this.lbMaPYC.AutoSize = true;
            this.lbMaPYC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbMaPYC.Location = new System.Drawing.Point(117, 25);
            this.lbMaPYC.Name = "lbMaPYC";
            this.lbMaPYC.Size = new System.Drawing.Size(81, 13);
            this.lbMaPYC.TabIndex = 2;
            this.lbMaPYC.Text = "Mã phiếu order:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnThemMon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 444);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(244, 388);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(122, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSMon);
            this.groupBox3.Location = new System.Drawing.Point(238, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 336);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách món";
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.Location = new System.Drawing.Point(6, 19);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.Size = new System.Drawing.Size(215, 311);
            this.dgvDSMon.TabIndex = 0;
            this.dgvDSMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMon_CellClick);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnThemMon.Location = new System.Drawing.Point(372, 361);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(93, 71);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label5.Location = new System.Drawing.Point(257, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập số lượng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSLoaiMon);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 336);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại món";
            // 
            // dgvDSLoaiMon
            // 
            this.dgvDSLoaiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiMon.Location = new System.Drawing.Point(6, 19);
            this.dgvDSLoaiMon.Name = "dgvDSLoaiMon";
            this.dgvDSLoaiMon.Size = new System.Drawing.Size(215, 311);
            this.dgvDSLoaiMon.TabIndex = 0;
            this.dgvDSLoaiMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoaiMon_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.grbTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(493, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 444);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvThongTinPYC);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(301, 419);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin phiếu order";
            // 
            // dgvThongTinPYC
            // 
            this.dgvThongTinPYC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPYC.Location = new System.Drawing.Point(6, 19);
            this.dgvThongTinPYC.Name = "dgvThongTinPYC";
            this.dgvThongTinPYC.Size = new System.Drawing.Size(289, 394);
            this.dgvThongTinPYC.TabIndex = 0;
            // 
            // frm_PhieuYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(998, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThaoTac);
            this.Controls.Add(this.lbNameAcc);
            this.Controls.Add(this.label1);
            this.Name = "frm_PhieuYeuCau";
            this.Text = "Phiếu order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_PhieuYeuCau_FormClosing);
            this.Load += new System.EventHandler(this.frm_PhieuYeuCau_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbThaoTac.ResumeLayout(false);
            this.grbThaoTac.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiMon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPYC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbThaoTac;
        private System.Windows.Forms.Button btnGiaiPhong;
        private System.Windows.Forms.Button btnThemPYC;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label lbLoaiMon;
        private System.Windows.Forms.Label lbNgayPYC;
        private System.Windows.Forms.Label lbMaPYC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSLoaiMon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvThongTinPYC;
    }
}