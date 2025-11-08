namespace DoAnCuoiKy_KeoDuaVinhLong_LTW
{
    partial class FormNhaCungCap
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
            this.BangNhaCungCap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BangNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // BangNhaCungCap
            // 
            this.BangNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangNhaCungCap.Location = new System.Drawing.Point(2, 134);
            this.BangNhaCungCap.Name = "BangNhaCungCap";
            this.BangNhaCungCap.RowHeadersWidth = 82;
            this.BangNhaCungCap.RowTemplate.Height = 33;
            this.BangNhaCungCap.Size = new System.Drawing.Size(1928, 250);
            this.BangNhaCungCap.TabIndex = 0;
            this.BangNhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BangNhaCungCap_CellContentClick);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1931, 646);
            this.Controls.Add(this.BangNhaCungCap);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BangNhaCungCap;
    }
}