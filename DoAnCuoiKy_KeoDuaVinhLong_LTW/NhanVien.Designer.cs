namespace DoAnCuoiKy_KeoDuaVinhLong_LTW
{
    partial class NhanVien
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
            this.components = new System.ComponentModel.Container();
            this.nutTimKiem = new System.Windows.Forms.Button();
            this.ThanhTimKiem = new System.Windows.Forms.TextBox();
            this.nutXoa = new System.Windows.Forms.Button();
            this.nutSua = new System.Windows.Forms.Button();
            this.nutThem = new System.Windows.Forms.Button();
            this.quanLyCuaHangDataSet = new DoAnCuoiKy_KeoDuaVinhLong_LTW.QuanLyCuaHangDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new DoAnCuoiKy_KeoDuaVinhLong_LTW.QuanLyCuaHangDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new DoAnCuoiKy_KeoDuaVinhLong_LTW.QuanLyCuaHangDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nutTimKiem
            // 
            this.nutTimKiem.Location = new System.Drawing.Point(525, 39);
            this.nutTimKiem.Name = "nutTimKiem";
            this.nutTimKiem.Size = new System.Drawing.Size(128, 44);
            this.nutTimKiem.TabIndex = 1;
            this.nutTimKiem.Text = "TimKiem";
            this.nutTimKiem.UseVisualStyleBackColor = true;
            // 
            // ThanhTimKiem
            // 
            this.ThanhTimKiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ThanhTimKiem.Location = new System.Drawing.Point(12, 46);
            this.ThanhTimKiem.Name = "ThanhTimKiem";
            this.ThanhTimKiem.Size = new System.Drawing.Size(493, 31);
            this.ThanhTimKiem.TabIndex = 2;
            // 
            // nutXoa
            // 
            this.nutXoa.Location = new System.Drawing.Point(1512, 46);
            this.nutXoa.Name = "nutXoa";
            this.nutXoa.Size = new System.Drawing.Size(128, 44);
            this.nutXoa.TabIndex = 1;
            this.nutXoa.Text = "Xoa";
            this.nutXoa.UseVisualStyleBackColor = true;
            // 
            // nutSua
            // 
            this.nutSua.Location = new System.Drawing.Point(1646, 46);
            this.nutSua.Name = "nutSua";
            this.nutSua.Size = new System.Drawing.Size(128, 44);
            this.nutSua.TabIndex = 1;
            this.nutSua.Text = "Sua";
            this.nutSua.UseVisualStyleBackColor = true;
            // 
            // nutThem
            // 
            this.nutThem.Location = new System.Drawing.Point(1378, 46);
            this.nutThem.Name = "nutThem";
            this.nutThem.Size = new System.Drawing.Size(128, 44);
            this.nutThem.TabIndex = 1;
            this.nutThem.Text = "Them";
            this.nutThem.UseVisualStyleBackColor = true;
            // 
            // quanLyCuaHangDataSet
            // 
            this.quanLyCuaHangDataSet.DataSetName = "QuanLyCuaHangDataSet";
            this.quanLyCuaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyCuaHangDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.ChiTietThuNhapTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnCuoiKy_KeoDuaVinhLong_LTW.QuanLyCuaHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.maQuyenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1854, 597);
            this.dataGridView1.TabIndex = 3;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // maQuyenDataGridViewTextBoxColumn
            // 
            this.maQuyenDataGridViewTextBoxColumn.DataPropertyName = "MaQuyen";
            this.maQuyenDataGridViewTextBoxColumn.HeaderText = "MaQuyen";
            this.maQuyenDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maQuyenDataGridViewTextBoxColumn.Name = "maQuyenDataGridViewTextBoxColumn";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ThanhTimKiem);
            this.Controls.Add(this.nutSua);
            this.Controls.Add(this.nutThem);
            this.Controls.Add(this.nutXoa);
            this.Controls.Add(this.nutTimKiem);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nutTimKiem;
        private System.Windows.Forms.TextBox ThanhTimKiem;
        private System.Windows.Forms.Button nutXoa;
        private System.Windows.Forms.Button nutSua;
        private System.Windows.Forms.Button nutThem;
        private QuanLyCuaHangDataSet quanLyCuaHangDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyCuaHangDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QuanLyCuaHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyenDataGridViewTextBoxColumn;
    }
}