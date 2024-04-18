namespace Travel
{
    partial class UCThongTinPhongCuaKhachSan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.linklblChiTietPhong = new System.Windows.Forms.LinkLabel();
            this.lblKichThuocPhong = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblSoGiaTien = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuoc.Location = new System.Drawing.Point(11, 66);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(221, 25);
            this.lblKichThuoc.TabIndex = 1;
            this.lblKichThuoc.Text = "Kích Thước Phòng(m2):";
            // 
            // linklblChiTietPhong
            // 
            this.linklblChiTietPhong.AutoSize = true;
            this.linklblChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblChiTietPhong.LinkColor = System.Drawing.Color.Blue;
            this.linklblChiTietPhong.Location = new System.Drawing.Point(11, 15);
            this.linklblChiTietPhong.Name = "linklblChiTietPhong";
            this.linklblChiTietPhong.Size = new System.Drawing.Size(201, 29);
            this.linklblChiTietPhong.TabIndex = 5;
            this.linklblChiTietPhong.TabStop = true;
            this.linklblChiTietPhong.Text = "Phòng \"ABCDEF\"";
            this.linklblChiTietPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblChiTietPhong_LinkClicked);
            // 
            // lblKichThuocPhong
            // 
            this.lblKichThuocPhong.AutoSize = true;
            this.lblKichThuocPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuocPhong.Location = new System.Drawing.Point(238, 66);
            this.lblKichThuocPhong.Name = "lblKichThuocPhong";
            this.lblKichThuocPhong.Size = new System.Drawing.Size(34, 25);
            this.lblKichThuocPhong.TabIndex = 6;
            this.lblKichThuocPhong.Text = "10";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.lblKichThuocPhong);
            this.pnl1.Controls.Add(this.linklblChiTietPhong);
            this.pnl1.Controls.Add(this.lblKichThuoc);
            this.pnl1.Location = new System.Drawing.Point(3, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(343, 142);
            this.pnl1.TabIndex = 6;
            // 
            // lblSoGiaTien
            // 
            this.lblSoGiaTien.AutoSize = true;
            this.lblSoGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGiaTien.Location = new System.Drawing.Point(131, 15);
            this.lblSoGiaTien.Name = "lblSoGiaTien";
            this.lblSoGiaTien.Size = new System.Drawing.Size(146, 25);
            this.lblSoGiaTien.TabIndex = 1;
            this.lblSoGiaTien.Text = "1.000.000 VNĐ";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(17, 15);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(86, 25);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá Tiền";
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.lblTrangThai);
            this.pnl2.Controls.Add(this.lblGiaTien);
            this.pnl2.Controls.Add(this.lblSoGiaTien);
            this.pnl2.Location = new System.Drawing.Point(344, 2);
            this.pnl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(445, 142);
            this.pnl2.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = false;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(219, 101);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(221, 36);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCThongTinPhongCuaKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCThongTinPhongCuaKhachSan";
            this.Size = new System.Drawing.Size(791, 147);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblKichThuoc;
        public System.Windows.Forms.LinkLabel linklblChiTietPhong;
        public System.Windows.Forms.Label lblKichThuocPhong;
        public System.Windows.Forms.Panel pnl1;
        public System.Windows.Forms.Label lblSoGiaTien;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Panel pnl2;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
    }
}
