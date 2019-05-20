namespace ThucTapNhom.GUI
{
    partial class frm_QuanLyThucPham
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
            this.tcQLThucPham = new System.Windows.Forms.TabControl();
            this.tpDSThucPham = new System.Windows.Forms.TabPage();
            this.dgvDSThucPham = new System.Windows.Forms.DataGridView();
            this.tpThemThucPham = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSuaTP = new System.Windows.Forms.Button();
            this.btnXoaTP = new System.Windows.Forms.Button();
            this.btnThemTP = new System.Windows.Forms.Button();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGiaTP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSThemThucPham = new System.Windows.Forms.DataGridView();
            this.tpNCC = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvDSNCC = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpNhapThucPham = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnNhapThucPham = new System.Windows.Forms.Button();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC_PhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcQLThucPham.SuspendLayout();
            this.tpDSThucPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucPham)).BeginInit();
            this.tpThemThucPham.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThemThucPham)).BeginInit();
            this.tpNCC.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tpNhapThucPham.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameAcc
            // 
            this.lbNameAcc.AutoSize = true;
            this.lbNameAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNameAcc.Location = new System.Drawing.Point(63, 18);
            this.lbNameAcc.Name = "lbNameAcc";
            this.lbNameAcc.Size = new System.Drawing.Size(0, 13);
            this.lbNameAcc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chào!";
            // 
            // tcQLThucPham
            // 
            this.tcQLThucPham.Controls.Add(this.tpDSThucPham);
            this.tcQLThucPham.Controls.Add(this.tpThemThucPham);
            this.tcQLThucPham.Controls.Add(this.tpNCC);
            this.tcQLThucPham.Controls.Add(this.tpNhapThucPham);
            this.tcQLThucPham.Location = new System.Drawing.Point(1, 54);
            this.tcQLThucPham.Name = "tcQLThucPham";
            this.tcQLThucPham.SelectedIndex = 0;
            this.tcQLThucPham.Size = new System.Drawing.Size(873, 352);
            this.tcQLThucPham.TabIndex = 9;
            // 
            // tpDSThucPham
            // 
            this.tpDSThucPham.Controls.Add(this.dgvDSThucPham);
            this.tpDSThucPham.Location = new System.Drawing.Point(4, 22);
            this.tpDSThucPham.Name = "tpDSThucPham";
            this.tpDSThucPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpDSThucPham.Size = new System.Drawing.Size(865, 326);
            this.tpDSThucPham.TabIndex = 0;
            this.tpDSThucPham.Text = "Danh sách thực phẩm";
            this.tpDSThucPham.UseVisualStyleBackColor = true;
            this.tpDSThucPham.Enter += new System.EventHandler(this.tpDSThucPham_Enter);
            // 
            // dgvDSThucPham
            // 
            this.dgvDSThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThucPham.Location = new System.Drawing.Point(3, 4);
            this.dgvDSThucPham.Name = "dgvDSThucPham";
            this.dgvDSThucPham.Size = new System.Drawing.Size(859, 331);
            this.dgvDSThucPham.TabIndex = 0;
            // 
            // tpThemThucPham
            // 
            this.tpThemThucPham.Controls.Add(this.groupBox7);
            this.tpThemThucPham.Controls.Add(this.groupBox2);
            this.tpThemThucPham.Location = new System.Drawing.Point(4, 22);
            this.tpThemThucPham.Name = "tpThemThucPham";
            this.tpThemThucPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpThemThucPham.Size = new System.Drawing.Size(865, 326);
            this.tpThemThucPham.TabIndex = 1;
            this.tpThemThucPham.Text = "Quản lý thực phẩm";
            this.tpThemThucPham.UseVisualStyleBackColor = true;
            this.tpThemThucPham.Enter += new System.EventHandler(this.tpThemThucPham_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSuaTP);
            this.groupBox7.Controls.Add(this.btnXoaTP);
            this.groupBox7.Controls.Add(this.btnThemTP);
            this.groupBox7.Controls.Add(this.txtMaTP);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtDVT);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.txtDonGiaTP);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtTenTP);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(10, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(165, 318);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin thực phẩm";
            // 
            // btnSuaTP
            // 
            this.btnSuaTP.Location = new System.Drawing.Point(3, 277);
            this.btnSuaTP.Name = "btnSuaTP";
            this.btnSuaTP.Size = new System.Drawing.Size(142, 39);
            this.btnSuaTP.TabIndex = 2;
            this.btnSuaTP.Text = "Sửa thông tin";
            this.btnSuaTP.UseVisualStyleBackColor = true;
            this.btnSuaTP.Click += new System.EventHandler(this.btnSuaTP_Click);
            // 
            // btnXoaTP
            // 
            this.btnXoaTP.Location = new System.Drawing.Point(3, 234);
            this.btnXoaTP.Name = "btnXoaTP";
            this.btnXoaTP.Size = new System.Drawing.Size(142, 37);
            this.btnXoaTP.TabIndex = 2;
            this.btnXoaTP.Text = "Xoá";
            this.btnXoaTP.UseVisualStyleBackColor = true;
            this.btnXoaTP.Click += new System.EventHandler(this.btnXoaTP_Click);
            // 
            // btnThemTP
            // 
            this.btnThemTP.Location = new System.Drawing.Point(3, 192);
            this.btnThemTP.Name = "btnThemTP";
            this.btnThemTP.Size = new System.Drawing.Size(142, 37);
            this.btnThemTP.TabIndex = 2;
            this.btnThemTP.Text = "Thêm";
            this.btnThemTP.UseVisualStyleBackColor = true;
            this.btnThemTP.Click += new System.EventHandler(this.btnThemTP_Click);
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(3, 35);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(142, 20);
            this.txtMaTP.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã:";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(3, 166);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(142, 20);
            this.txtDVT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn vị tính:";
            // 
            // txtDonGiaTP
            // 
            this.txtDonGiaTP.Location = new System.Drawing.Point(3, 124);
            this.txtDonGiaTP.Name = "txtDonGiaTP";
            this.txtDonGiaTP.Size = new System.Drawing.Size(142, 20);
            this.txtDonGiaTP.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Đơn giá: ";
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(3, 78);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(142, 20);
            this.txtTenTP.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSThemThucPham);
            this.groupBox2.Location = new System.Drawing.Point(181, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thực phẩm";
            // 
            // dgvDSThemThucPham
            // 
            this.dgvDSThemThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThemThucPham.Location = new System.Drawing.Point(6, 16);
            this.dgvDSThemThucPham.Name = "dgvDSThemThucPham";
            this.dgvDSThemThucPham.Size = new System.Drawing.Size(666, 298);
            this.dgvDSThemThucPham.TabIndex = 0;
            this.dgvDSThemThucPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSThemThucPham_CellClick);
            // 
            // tpNCC
            // 
            this.tpNCC.Controls.Add(this.groupBox9);
            this.tpNCC.Controls.Add(this.groupBox8);
            this.tpNCC.Location = new System.Drawing.Point(4, 22);
            this.tpNCC.Name = "tpNCC";
            this.tpNCC.Padding = new System.Windows.Forms.Padding(3);
            this.tpNCC.Size = new System.Drawing.Size(865, 326);
            this.tpNCC.TabIndex = 4;
            this.tpNCC.Text = "Nhà cung cấp";
            this.tpNCC.UseVisualStyleBackColor = true;
            this.tpNCC.Enter += new System.EventHandler(this.tpNCC_Enter);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgvDSNCC);
            this.groupBox9.Location = new System.Drawing.Point(177, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(682, 321);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Danh sách nhà cung cấp";
            // 
            // dgvDSNCC
            // 
            this.dgvDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNCC.Location = new System.Drawing.Point(6, 15);
            this.dgvDSNCC.Name = "dgvDSNCC";
            this.dgvDSNCC.Size = new System.Drawing.Size(668, 298);
            this.dgvDSNCC.TabIndex = 0;
            this.dgvDSNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNCC_CellClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSuaNCC);
            this.groupBox8.Controls.Add(this.btnXoaNCC);
            this.groupBox8.Controls.Add(this.btnThemNCC);
            this.groupBox8.Controls.Add(this.txtMaNCC);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.txtSDT);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.txtDiaChi);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.txtTenNCC);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Location = new System.Drawing.Point(6, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(165, 318);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin nhà cung cấp";
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Location = new System.Drawing.Point(3, 271);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(142, 41);
            this.btnSuaNCC.TabIndex = 2;
            this.btnSuaNCC.Text = "Sửa thông tin";
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Location = new System.Drawing.Point(3, 229);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(142, 36);
            this.btnXoaNCC.TabIndex = 2;
            this.btnXoaNCC.Text = "Xoá";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(3, 189);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(142, 34);
            this.btnThemNCC.TabIndex = 2;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(3, 33);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(142, 20);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(3, 150);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(142, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "SĐT:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(3, 111);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(142, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Địa chỉ:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(3, 72);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(142, 20);
            this.txtTenNCC.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tên:";
            // 
            // tpNhapThucPham
            // 
            this.tpNhapThucPham.Controls.Add(this.groupBox3);
            this.tpNhapThucPham.Controls.Add(this.groupBox1);
            this.tpNhapThucPham.Location = new System.Drawing.Point(4, 22);
            this.tpNhapThucPham.Name = "tpNhapThucPham";
            this.tpNhapThucPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapThucPham.Size = new System.Drawing.Size(865, 326);
            this.tpNhapThucPham.TabIndex = 5;
            this.tpNhapThucPham.Text = "Nhập thực phẩm";
            this.tpNhapThucPham.UseVisualStyleBackColor = true;
            this.tpNhapThucPham.Enter += new System.EventHandler(this.tpNhapThucPham_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(204, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 321);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(6, 16);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(649, 298);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.btnNhapThucPham);
            this.groupBox1.Controls.Add(this.btnSuaPN);
            this.groupBox1.Controls.Add(this.btnXoaPN);
            this.groupBox1.Controls.Add(this.btnThemPN);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNCC_PhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(4, 72);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(182, 20);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // btnNhapThucPham
            // 
            this.btnNhapThucPham.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNhapThucPham.Location = new System.Drawing.Point(3, 275);
            this.btnNhapThucPham.Name = "btnNhapThucPham";
            this.btnNhapThucPham.Size = new System.Drawing.Size(183, 28);
            this.btnNhapThucPham.TabIndex = 2;
            this.btnNhapThucPham.Text = "Nhập thực phẩm";
            this.btnNhapThucPham.UseVisualStyleBackColor = true;
            this.btnNhapThucPham.Click += new System.EventHandler(this.btnNhapThucPham_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.Location = new System.Drawing.Point(3, 241);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(183, 28);
            this.btnSuaPN.TabIndex = 2;
            this.btnSuaPN.Text = "Sửa thông tin";
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Location = new System.Drawing.Point(3, 210);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(183, 25);
            this.btnXoaPN.TabIndex = 2;
            this.btnXoaPN.Text = "Xoá";
            this.btnXoaPN.UseVisualStyleBackColor = true;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnThemPN
            // 
            this.btnThemPN.Location = new System.Drawing.Point(3, 176);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(183, 28);
            this.btnThemPN.TabIndex = 2;
            this.btnThemPN.Text = "Thêm";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(3, 33);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(183, 20);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // txtMaNCC_PhieuNhap
            // 
            this.txtMaNCC_PhieuNhap.Location = new System.Drawing.Point(3, 150);
            this.txtMaNCC_PhieuNhap.Name = "txtMaNCC_PhieuNhap";
            this.txtMaNCC_PhieuNhap.Size = new System.Drawing.Size(183, 20);
            this.txtMaNCC_PhieuNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NCC:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(3, 111);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(183, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày nhập:";
            // 
            // frm_QuanLyThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(886, 418);
            this.Controls.Add(this.tcQLThucPham);
            this.Controls.Add(this.lbNameAcc);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuanLyThucPham";
            this.Text = "Quản lý thực phẩm";
            this.Load += new System.EventHandler(this.frm_QuanLyThucPham_Load);
            this.tcQLThucPham.ResumeLayout(false);
            this.tpDSThucPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucPham)).EndInit();
            this.tpThemThucPham.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThemThucPham)).EndInit();
            this.tpNCC.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tpNhapThucPham.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcQLThucPham;
        private System.Windows.Forms.TabPage tpDSThucPham;
        private System.Windows.Forms.TabPage tpThemThucPham;
        private System.Windows.Forms.DataGridView dgvDSThucPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSThemThucPham;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnThemTP;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDonGiaTP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tpNCC;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvDSNCC;
        private System.Windows.Forms.Button btnXoaTP;
        private System.Windows.Forms.Button btnSuaTP;
        private System.Windows.Forms.TabPage tpNhapThucPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNCC_PhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNhapThucPham;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
    }
}