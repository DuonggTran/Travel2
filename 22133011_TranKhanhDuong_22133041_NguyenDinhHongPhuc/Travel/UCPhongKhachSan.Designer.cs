namespace Travel
{
    partial class UCPhongKhachSan
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
            this.linklblTenPhong = new System.Windows.Forms.LinkLabel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lbSoGiaTien = new System.Windows.Forms.Label();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbKichThuocPhong = new System.Windows.Forms.Label();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklblTenPhong
            // 
            this.linklblTenPhong.AutoSize = true;
            this.linklblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblTenPhong.LinkColor = System.Drawing.Color.Blue;
            this.linklblTenPhong.Location = new System.Drawing.Point(11, 15);
            this.linklblTenPhong.Name = "linklblTenPhong";
            this.linklblTenPhong.Size = new System.Drawing.Size(169, 25);
            this.linklblTenPhong.TabIndex = 5;
            this.linklblTenPhong.TabStop = true;
            this.linklblTenPhong.Text = "Phòng \"ABCDEF\"";
            this.linklblTenPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblChiTietPhong_LinkClicked);
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.lblGiaTien);
            this.pnl2.Controls.Add(this.lbSoGiaTien);
            this.pnl2.Location = new System.Drawing.Point(344, 2);
            this.pnl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(445, 142);
            this.pnl2.TabIndex = 9;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(219, 116);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(72, 20);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá Tiền";
            // 
            // lbSoGiaTien
            // 
            this.lbSoGiaTien.AutoSize = true;
            this.lbSoGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoGiaTien.Location = new System.Drawing.Point(307, 116);
            this.lbSoGiaTien.Name = "lbSoGiaTien";
            this.lbSoGiaTien.Size = new System.Drawing.Size(120, 20);
            this.lbSoGiaTien.TabIndex = 1;
            this.lbSoGiaTien.Text = "1.000.000 VNĐ";
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuoc.Location = new System.Drawing.Point(12, 57);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(185, 20);
            this.lblKichThuoc.TabIndex = 1;
            this.lblKichThuoc.Text = "Kích Thước Phòng(m2):";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.lbKichThuocPhong);
            this.pnl1.Controls.Add(this.linklblTenPhong);
            this.pnl1.Controls.Add(this.lblKichThuoc);
            this.pnl1.Location = new System.Drawing.Point(3, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(343, 142);
            this.pnl1.TabIndex = 8;
            // 
            // lbKichThuocPhong
            // 
            this.lbKichThuocPhong.AutoSize = true;
            this.lbKichThuocPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKichThuocPhong.Location = new System.Drawing.Point(227, 57);
            this.lbKichThuocPhong.Name = "lbKichThuocPhong";
            this.lbKichThuocPhong.Size = new System.Drawing.Size(27, 20);
            this.lbKichThuocPhong.TabIndex = 6;
            this.lbKichThuocPhong.Text = "10";
            // 
            // UCPhongKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCPhongKhachSan";
            this.Size = new System.Drawing.Size(792, 148);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklblTenPhong;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lbSoGiaTien;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lbKichThuocPhong;
    }
}
