namespace DoAnCuoiKy_KeoDuaVinhLong_LTW
{
    partial class FormNhanVien
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
            this.nutTimKiem = new System.Windows.Forms.Button();
            this.nutThem = new System.Windows.Forms.Button();
            this.nutXoa = new System.Windows.Forms.Button();
            this.nutSua = new System.Windows.Forms.Button();
            this.BangNhanVien = new System.Windows.Forms.DataGridView();
            this.ThanhTimKiem = new System.Windows.Forms.TextBox();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BangNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // nutTimKiem
            // 
            this.nutTimKiem.Location = new System.Drawing.Point(511, 28);
            this.nutTimKiem.Name = "nutTimKiem";
            this.nutTimKiem.Size = new System.Drawing.Size(115, 51);
            this.nutTimKiem.TabIndex = 0;
            this.nutTimKiem.Text = "TimKiem";
            this.nutTimKiem.UseVisualStyleBackColor = true;
            this.nutTimKiem.Click += new System.EventHandler(this.nutTimKiem_Click);
            // 
            // nutThem
            // 
            this.nutThem.Location = new System.Drawing.Point(1359, 28);
            this.nutThem.Name = "nutThem";
            this.nutThem.Size = new System.Drawing.Size(115, 51);
            this.nutThem.TabIndex = 0;
            this.nutThem.Text = "Them";
            this.nutThem.UseVisualStyleBackColor = true;
            this.nutThem.Click += new System.EventHandler(this.nutThem_Click);
            // 
            // nutXoa
            // 
            this.nutXoa.Location = new System.Drawing.Point(1500, 28);
            this.nutXoa.Name = "nutXoa";
            this.nutXoa.Size = new System.Drawing.Size(115, 51);
            this.nutXoa.TabIndex = 0;
            this.nutXoa.Text = "Xoa";
            this.nutXoa.UseVisualStyleBackColor = true;
            this.nutXoa.Click += new System.EventHandler(this.nutXoa_Click);
            // 
            // nutSua
            // 
            this.nutSua.Location = new System.Drawing.Point(1639, 28);
            this.nutSua.Name = "nutSua";
            this.nutSua.Size = new System.Drawing.Size(115, 51);
            this.nutSua.TabIndex = 0;
            this.nutSua.Text = "Sua";
            this.nutSua.UseVisualStyleBackColor = true;
            this.nutSua.Click += new System.EventHandler(this.nutSua_Click);
            // 
            // BangNhanVien
            // 
            this.BangNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.SoDienThoai,
            this.DiaChi,
            this.TenDangNhap,
            this.MatKhau,
            this.MaQuyen});
            this.BangNhanVien.Location = new System.Drawing.Point(1, 111);
            this.BangNhanVien.Name = "BangNhanVien";
            this.BangNhanVien.RowHeadersWidth = 82;
            this.BangNhanVien.RowTemplate.Height = 33;
            this.BangNhanVien.Size = new System.Drawing.Size(1929, 439);
            this.BangNhanVien.TabIndex = 1;
            // 
            // ThanhTimKiem
            // 
            this.ThanhTimKiem.Location = new System.Drawing.Point(24, 38);
            this.ThanhTimKiem.Name = "ThanhTimKiem";
            this.ThanhTimKiem.Size = new System.Drawing.Size(463, 31);
            this.ThanhTimKiem.TabIndex = 2;
            this.ThanhTimKiem.TextChanged += new System.EventHandler(this.ThanhTimKiem_TextChanged);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "MaNhanVien";
            this.MaNhanVien.MinimumWidth = 10;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 10;
            this.HoTen.Name = "HoTen";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "SoDienThoai";
            this.SoDienThoai.MinimumWidth = 10;
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 10;
            this.DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.HeaderText = "TenDangNhap";
            this.TenDangNhap.MinimumWidth = 10;
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.MinimumWidth = 10;
            this.MatKhau.Name = "MatKhau";
            // 
            // MaQuyen
            // 
            this.MaQuyen.HeaderText = "MaQuyen";
            this.MaQuyen.MinimumWidth = 10;
            this.MaQuyen.Name = "MaQuyen";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1931, 547);
            this.Controls.Add(this.ThanhTimKiem);
            this.Controls.Add(this.BangNhanVien);
            this.Controls.Add(this.nutSua);
            this.Controls.Add(this.nutXoa);
            this.Controls.Add(this.nutThem);
            this.Controls.Add(this.nutTimKiem);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nutTimKiem;
        private System.Windows.Forms.Button nutThem;
        private System.Windows.Forms.Button nutXoa;
        private System.Windows.Forms.Button nutSua;
        private System.Windows.Forms.DataGridView BangNhanVien;
        private System.Windows.Forms.TextBox ThanhTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
    }
}