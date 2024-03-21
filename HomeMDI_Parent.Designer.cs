namespace QLBHX
{
    partial class formHome
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cuaHangtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsChiNhanhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qlSanPhamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNhanVienToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qlkhoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuaHangtoolStripMenuItem1,
            this.qlNhanVienToolStripMenuItem2,
            this.qlkhoToolStripMenuItem3,
            this.hoaDonBanHangToolStripMenuItem,
            this.taiKhoanToolStripMenuItem4});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1182, 36);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // cuaHangtoolStripMenuItem1
            // 
            this.cuaHangtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsChiNhanhToolStripMenuItem1,
            this.qlSanPhamToolStripMenuItem1});
            this.cuaHangtoolStripMenuItem1.Name = "cuaHangtoolStripMenuItem1";
            this.cuaHangtoolStripMenuItem1.Size = new System.Drawing.Size(112, 32);
            this.cuaHangtoolStripMenuItem1.Text = "Cửa Hàng";
            this.cuaHangtoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dsChiNhanhToolStripMenuItem1
            // 
            this.dsChiNhanhToolStripMenuItem1.Name = "dsChiNhanhToolStripMenuItem1";
            this.dsChiNhanhToolStripMenuItem1.Size = new System.Drawing.Size(286, 32);
            this.dsChiNhanhToolStripMenuItem1.Text = "Danh Sách Chi Nhánh";
            // 
            // qlSanPhamToolStripMenuItem1
            // 
            this.qlSanPhamToolStripMenuItem1.Name = "qlSanPhamToolStripMenuItem1";
            this.qlSanPhamToolStripMenuItem1.Size = new System.Drawing.Size(286, 32);
            this.qlSanPhamToolStripMenuItem1.Text = "Quản Lý Sản Phẩm";
            // 
            // qlNhanVienToolStripMenuItem2
            // 
            this.qlNhanVienToolStripMenuItem2.Name = "qlNhanVienToolStripMenuItem2";
            this.qlNhanVienToolStripMenuItem2.Size = new System.Drawing.Size(191, 32);
            this.qlNhanVienToolStripMenuItem2.Text = "Quản Lý Nhân Viên";
            // 
            // qlkhoToolStripMenuItem3
            // 
            this.qlkhoToolStripMenuItem3.Name = "qlkhoToolStripMenuItem3";
            this.qlkhoToolStripMenuItem3.Size = new System.Drawing.Size(136, 32);
            this.qlkhoToolStripMenuItem3.Text = "Quản Lý Kho";
            this.qlkhoToolStripMenuItem3.Click += new System.EventHandler(this.qlKhoToolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem4
            // 
            this.taiKhoanToolStripMenuItem4.Name = "taiKhoanToolStripMenuItem4";
            this.taiKhoanToolStripMenuItem4.Size = new System.Drawing.Size(110, 32);
            this.taiKhoanToolStripMenuItem4.Text = "Tài Khoản";
            this.taiKhoanToolStripMenuItem4.Click += new System.EventHandler(this.taiKhoanToolStripMenuItem_Click);
            // 
            // hoaDonBanHangToolStripMenuItem
            // 
            this.hoaDonBanHangToolStripMenuItem.Name = "hoaDonBanHangToolStripMenuItem";
            this.hoaDonBanHangToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.hoaDonBanHangToolStripMenuItem.Text = "Hoá Đơn Bán Hàng";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formHome";
            this.Text = "Quản Lý Bách Hoá Xanh";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cuaHangtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qlNhanVienToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qlkhoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem dsChiNhanhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qlSanPhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hoaDonBanHangToolStripMenuItem;
    }
}

