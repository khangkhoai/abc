namespace ThucTapNhom
{
    partial class frm_ThanhToan
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
            this.grbThaoTac = new System.Windows.Forms.GroupBox();
            this.lbBan = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgayHD = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvThongTinHD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTongThua = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grbThaoTac.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameAcc
            // 
            this.lbNameAcc.AutoSize = true;
            this.lbNameAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNameAcc.Location = new System.Drawing.Point(63, 20);
            this.lbNameAcc.Name = "lbNameAcc";
            this.lbNameAcc.Size = new System.Drawing.Size(0, 13);
            this.lbNameAcc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào!";
            // 
            // grbThaoTac
            // 
            this.grbThaoTac.Controls.Add(this.lbBan);
            this.grbThaoTac.Controls.Add(this.lbSDT);
            this.grbThaoTac.Controls.Add(this.lbNgayHD);
            this.grbThaoTac.Controls.Add(this.lbMaHD);
            this.grbThaoTac.Location = new System.Drawing.Point(12, 54);
            this.grbThaoTac.Name = "grbThaoTac";
            this.grbThaoTac.Size = new System.Drawing.Size(690, 57);
            this.grbThaoTac.TabIndex = 3;
            this.grbThaoTac.TabStop = false;
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
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbSDT.Location = new System.Drawing.Point(454, 25);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(92, 13);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "SĐT khách hàng:";
            // 
            // lbNgayHD
            // 
            this.lbNgayHD.AutoSize = true;
            this.lbNgayHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNgayHD.Location = new System.Drawing.Point(266, 25);
            this.lbNgayHD.Name = "lbNgayHD";
            this.lbNgayHD.Size = new System.Drawing.Size(95, 13);
            this.lbNgayHD.TabIndex = 2;
            this.lbNgayHD.Text = "Ngày lập hoá đơn:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbMaHD.Location = new System.Drawing.Point(117, 25);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(68, 13);
            this.lbMaHD.TabIndex = 2;
            this.lbMaHD.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(502, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvThongTinHD);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 419);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin hoá đơn";
            // 
            // dgvThongTinHD
            // 
            this.dgvThongTinHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHD.Location = new System.Drawing.Point(6, 19);
            this.dgvThongTinHD.Name = "dgvThongTinHD";
            this.dgvThongTinHD.Size = new System.Drawing.Size(478, 394);
            this.dgvThongTinHD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(502, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền khách đưa:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(505, 41);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(169, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(502, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng thừa:";
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.Location = new System.Drawing.Point(505, 86);
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(169, 20);
            this.txtTienKhach.TabIndex = 3;
            this.txtTienKhach.Leave += new System.EventHandler(this.txtTienKhach_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.button1.Location = new System.Drawing.Point(505, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "In hoá đơn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtTongThua
            // 
            this.txtTongThua.Location = new System.Drawing.Point(505, 129);
            this.txtTongThua.Name = "txtTongThua";
            this.txtTongThua.Size = new System.Drawing.Size(169, 20);
            this.txtTongThua.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTongThua);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtTienKhach);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(15, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(687, 444);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(718, 573);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbThaoTac);
            this.Controls.Add(this.lbNameAcc);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThanhToan";
            this.Text = "Hoá đơn thanh toán";
            this.Load += new System.EventHandler(this.frm_PhucVuKH_Load);
            this.grbThaoTac.ResumeLayout(false);
            this.grbThaoTac.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThaoTac;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lbNgayHD;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvThongTinHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienKhach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTongThua;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}