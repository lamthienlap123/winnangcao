namespace giaodien_Windows
{
    partial class Frm_taophieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_taophieu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dt_ngaytra = new DevExpress.XtraEditors.DateEdit();
            this.dt_ngaynhan = new DevExpress.XtraEditors.DateEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_suaphieu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_taophieu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaphieu = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_madonhang = new System.Windows.Forms.TextBox();
            this.dv_donhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_kho = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.cbo_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_khachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_DV = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.btn_themcthd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoacthd = new DevExpress.XtraEditors.SimpleButton();
            this.dv_ctdg = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_donhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_ctdg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dt_ngaytra);
            this.groupControl1.Controls.Add(this.dt_ngaynhan);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.txt_madonhang);
            this.groupControl1.Controls.Add(this.dv_donhang);
            this.groupControl1.Controls.Add(this.cbo_kho);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txt_thanhtien);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_ghichu);
            this.groupControl1.Controls.Add(this.cbo_nhanvien);
            this.groupControl1.Controls.Add(this.cbo_khachhang);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(616, 501);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đơn hàng";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // dt_ngaytra
            // 
            this.dt_ngaytra.EditValue = null;
            this.dt_ngaytra.Location = new System.Drawing.Point(424, 94);
            this.dt_ngaytra.Name = "dt_ngaytra";
            this.dt_ngaytra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytra.Size = new System.Drawing.Size(176, 20);
            this.dt_ngaytra.TabIndex = 22;
            // 
            // dt_ngaynhan
            // 
            this.dt_ngaynhan.EditValue = null;
            this.dt_ngaynhan.Location = new System.Drawing.Point(82, 89);
            this.dt_ngaynhan.Name = "dt_ngaynhan";
            this.dt_ngaynhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaynhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaynhan.Size = new System.Drawing.Size(176, 20);
            this.dt_ngaynhan.TabIndex = 22;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_suaphieu);
            this.groupControl3.Controls.Add(this.btn_taophieu);
            this.groupControl3.Controls.Add(this.btn_xoaphieu);
            this.groupControl3.Location = new System.Drawing.Point(15, 180);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(296, 76);
            this.groupControl3.TabIndex = 21;
            this.groupControl3.Text = "Xử lý";
            // 
            // btn_suaphieu
            // 
            this.btn_suaphieu.Location = new System.Drawing.Point(197, 30);
            this.btn_suaphieu.Name = "btn_suaphieu";
            this.btn_suaphieu.Size = new System.Drawing.Size(76, 41);
            this.btn_suaphieu.TabIndex = 8;
            this.btn_suaphieu.Text = "Sửa phiếu";
            this.btn_suaphieu.Click += new System.EventHandler(this.btn_suaphieu_Click);
            // 
            // btn_taophieu
            // 
            this.btn_taophieu.Location = new System.Drawing.Point(15, 30);
            this.btn_taophieu.Name = "btn_taophieu";
            this.btn_taophieu.Size = new System.Drawing.Size(64, 41);
            this.btn_taophieu.TabIndex = 8;
            this.btn_taophieu.Text = "Tạo phiếu";
            this.btn_taophieu.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btn_xoaphieu
            // 
            this.btn_xoaphieu.Location = new System.Drawing.Point(108, 30);
            this.btn_xoaphieu.Name = "btn_xoaphieu";
            this.btn_xoaphieu.Size = new System.Drawing.Size(65, 41);
            this.btn_xoaphieu.TabIndex = 8;
            this.btn_xoaphieu.Text = "Xóa phiếu";
            this.btn_xoaphieu.Click += new System.EventHandler(this.btn_xoaphieu_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(588, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_madonhang
            // 
            this.txt_madonhang.Location = new System.Drawing.Point(82, 32);
            this.txt_madonhang.Name = "txt_madonhang";
            this.txt_madonhang.Size = new System.Drawing.Size(130, 21);
            this.txt_madonhang.TabIndex = 19;
            // 
            // dv_donhang
            // 
            this.dv_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_donhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dv_donhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dv_donhang.Location = new System.Drawing.Point(2, 271);
            this.dv_donhang.Name = "dv_donhang";
            this.dv_donhang.Size = new System.Drawing.Size(612, 228);
            this.dv_donhang.TabIndex = 18;
            this.dv_donhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_cellclick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KHACHHANG";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "KHO";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NHANVIEN";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TinhTrang";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // cbo_kho
            // 
            this.cbo_kho.AccessibleDescription = "";
            this.cbo_kho.FormattingEnabled = true;
            this.cbo_kho.Location = new System.Drawing.Point(424, 59);
            this.cbo_kho.Name = "cbo_kho";
            this.cbo_kho.Size = new System.Drawing.Size(186, 21);
            this.cbo_kho.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kho lưu đồ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thành Tiền";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(480, 235);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(130, 21);
            this.txt_thanhtien.TabIndex = 12;
            this.txt_thanhtien.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Nhận";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(82, 120);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(528, 54);
            this.txt_ghichu.TabIndex = 5;
            // 
            // cbo_nhanvien
            // 
            this.cbo_nhanvien.FormattingEnabled = true;
            this.cbo_nhanvien.Location = new System.Drawing.Point(82, 59);
            this.cbo_nhanvien.Name = "cbo_nhanvien";
            this.cbo_nhanvien.Size = new System.Drawing.Size(259, 21);
            this.cbo_nhanvien.TabIndex = 3;
            // 
            // cbo_khachhang
            // 
            this.cbo_khachhang.FormattingEnabled = true;
            this.cbo_khachhang.Location = new System.Drawing.Point(299, 32);
            this.cbo_khachhang.Name = "cbo_khachhang";
            this.cbo_khachhang.Size = new System.Drawing.Size(283, 21);
            this.cbo_khachhang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // cbo_DV
            // 
            this.cbo_DV.FormattingEnabled = true;
            this.cbo_DV.Location = new System.Drawing.Point(108, 29);
            this.cbo_DV.Name = "cbo_DV";
            this.cbo_DV.Size = new System.Drawing.Size(200, 21);
            this.cbo_DV.TabIndex = 6;
            this.cbo_DV.SelectedValueChanged += new System.EventHandler(this.cbo_DV_SelectedValueChanged);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(107, 59);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(200, 21);
            this.txt_soluong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.dv_ctdg);
            this.groupControl2.Controls.Add(this.cbo_DV);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.textBox2);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.txt_soluong);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(616, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(448, 501);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi tiết đơn hàng";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btn_themcthd);
            this.groupControl5.Controls.Add(this.btn_xoacthd);
            this.groupControl5.Location = new System.Drawing.Point(36, 166);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(167, 99);
            this.groupControl5.TabIndex = 10;
            this.groupControl5.Text = "Xử lý";
            // 
            // btn_themcthd
            // 
            this.btn_themcthd.Location = new System.Drawing.Point(15, 30);
            this.btn_themcthd.Name = "btn_themcthd";
            this.btn_themcthd.Size = new System.Drawing.Size(60, 45);
            this.btn_themcthd.TabIndex = 8;
            this.btn_themcthd.Text = "Thêm";
            this.btn_themcthd.Click += new System.EventHandler(this.btn_themcthd_Click);
            // 
            // btn_xoacthd
            // 
            this.btn_xoacthd.Location = new System.Drawing.Point(92, 30);
            this.btn_xoacthd.Name = "btn_xoacthd";
            this.btn_xoacthd.Size = new System.Drawing.Size(60, 45);
            this.btn_xoacthd.TabIndex = 8;
            this.btn_xoacthd.Text = "Xóa";
            this.btn_xoacthd.Click += new System.EventHandler(this.btn_xoacthd_Click);
            // 
            // dv_ctdg
            // 
            this.dv_ctdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_ctdg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dv_ctdg.Location = new System.Drawing.Point(2, 271);
            this.dv_ctdg.Name = "dv_ctdg";
            this.dv_ctdg.Size = new System.Drawing.Size(444, 228);
            this.dv_ctdg.TabIndex = 7;
            this.dv_ctdg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_cell_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại dịch vụ";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Giá bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thành tiền";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(108, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 5;
            // 
            // Frm_taophieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 501);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_taophieu";
            this.Text = "Frm_taophieu";
            this.Load += new System.EventHandler(this.Frm_taophieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_donhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_ctdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_DV;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_nhanvien;
        private System.Windows.Forms.ComboBox cbo_khachhang;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.ComboBox cbo_kho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.TextBox txt_madonhang;
        private System.Windows.Forms.DataGridView dv_donhang;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_xoacthd;
        private DevExpress.XtraEditors.SimpleButton btn_themcthd;
        private System.Windows.Forms.DataGridView dv_ctdg;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_suaphieu;
        private DevExpress.XtraEditors.SimpleButton btn_taophieu;
        private DevExpress.XtraEditors.SimpleButton btn_xoaphieu;
        private DevExpress.XtraEditors.DateEdit dt_ngaytra;
        private DevExpress.XtraEditors.DateEdit dt_ngaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}