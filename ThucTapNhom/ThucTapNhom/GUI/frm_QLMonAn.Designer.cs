namespace ThucTapNhom.GUI
{
    partial class frm_QLMonAn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhomMon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.btnSuaLoai = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.btnDSLoai = new System.Windows.Forms.Button();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnDSMon = new System.Windows.Forms.Button();
            this.txtThuocLoai = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhomMon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSNhomMon);
            this.groupBox4.Location = new System.Drawing.Point(7, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 240);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách loại";
            // 
            // dgvDSNhomMon
            // 
            this.dgvDSNhomMon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.dgvDSNhomMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhomMon.Location = new System.Drawing.Point(4, 19);
            this.dgvDSNhomMon.Name = "dgvDSNhomMon";
            this.dgvDSNhomMon.Size = new System.Drawing.Size(419, 215);
            this.dgvDSNhomMon.TabIndex = 0;
            this.dgvDSNhomMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhomMon_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaLoai);
            this.groupBox3.Controls.Add(this.btnSuaLoai);
            this.groupBox3.Controls.Add(this.btnThemLoai);
            this.groupBox3.Controls.Add(this.btnDSLoai);
            this.groupBox3.Controls.Add(this.txtTenLoai);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaLoai);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(7, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnXoaLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnXoaLoai.Location = new System.Drawing.Point(346, 45);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(77, 21);
            this.btnXoaLoai.TabIndex = 2;
            this.btnXoaLoai.Text = "Xoá loại";
            this.btnXoaLoai.UseVisualStyleBackColor = false;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnSuaLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnSuaLoai.Location = new System.Drawing.Point(263, 44);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(77, 21);
            this.btnSuaLoai.TabIndex = 2;
            this.btnSuaLoai.Text = "Sửa loại";
            this.btnSuaLoai.UseVisualStyleBackColor = false;
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnThemLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnThemLoai.Location = new System.Drawing.Point(180, 44);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(77, 21);
            this.btnThemLoai.TabIndex = 2;
            this.btnThemLoai.Text = "Thêm loại";
            this.btnThemLoai.UseVisualStyleBackColor = false;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // btnDSLoai
            // 
            this.btnDSLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnDSLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnDSLoai.Location = new System.Drawing.Point(180, 15);
            this.btnDSLoai.Name = "btnDSLoai";
            this.btnDSLoai.Size = new System.Drawing.Size(243, 21);
            this.btnDSLoai.TabIndex = 2;
            this.btnDSLoai.Text = "Danh sách loại";
            this.btnDSLoai.UseVisualStyleBackColor = false;
            this.btnDSLoai.Click += new System.EventHandler(this.btnDSLoai_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(57, 45);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(117, 20);
            this.txtTenLoai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên loại:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(57, 16);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(117, 20);
            this.txtMaLoai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý loại món";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(450, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 371);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDSMonAn);
            this.groupBox6.Location = new System.Drawing.Point(6, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(617, 240);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách món";
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Location = new System.Drawing.Point(6, 13);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.Size = new System.Drawing.Size(606, 221);
            this.dgvDSMonAn.TabIndex = 1;
            this.dgvDSMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonAn_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoaMon);
            this.groupBox5.Controls.Add(this.btnSuaMon);
            this.groupBox5.Controls.Add(this.btnThemMon);
            this.groupBox5.Controls.Add(this.btnDSMon);
            this.groupBox5.Controls.Add(this.txtThuocLoai);
            this.groupBox5.Controls.Add(this.txtTenMon);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtDonGia);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtMaMon);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(6, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(617, 87);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnXoaMon.Location = new System.Drawing.Point(535, 45);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(77, 21);
            this.btnXoaMon.TabIndex = 3;
            this.btnXoaMon.Text = "Xoá món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnSuaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnSuaMon.Location = new System.Drawing.Point(452, 44);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(77, 21);
            this.btnSuaMon.TabIndex = 4;
            this.btnSuaMon.Text = "Sửa món";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnThemMon.Location = new System.Drawing.Point(369, 44);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(77, 21);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnDSMon
            // 
            this.btnDSMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.btnDSMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnDSMon.Location = new System.Drawing.Point(369, 15);
            this.btnDSMon.Name = "btnDSMon";
            this.btnDSMon.Size = new System.Drawing.Size(243, 21);
            this.btnDSMon.TabIndex = 6;
            this.btnDSMon.Text = "Danh sách món";
            this.btnDSMon.UseVisualStyleBackColor = false;
            this.btnDSMon.Click += new System.EventHandler(this.btnDSMon_Click);
            // 
            // txtThuocLoai
            // 
            this.txtThuocLoai.Location = new System.Drawing.Point(246, 46);
            this.txtThuocLoai.Name = "txtThuocLoai";
            this.txtThuocLoai.Size = new System.Drawing.Size(117, 20);
            this.txtThuocLoai.TabIndex = 1;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(57, 45);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(117, 20);
            this.txtTenMon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label8.Location = new System.Drawing.Point(180, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thuộc loại:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(246, 16);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 20);
            this.txtDonGia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên món:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(180, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá:";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(57, 16);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(117, 20);
            this.txtMaMon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã món:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản lý món ăn";
            // 
            // frm_QLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_QLMonAn";
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.frm_QLMonAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhomMon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Button btnDSLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.Button btnXoaLoai;
        private System.Windows.Forms.Button btnSuaLoai;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSNhomMon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnDSMon;
        private System.Windows.Forms.TextBox txtThuocLoai;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}