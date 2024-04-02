namespace Travel
{
    partial class XemPhongCuaKhachSan
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
            this.pnlTienDe = new System.Windows.Forms.Panel();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblLuongKhach = new System.Windows.Forms.Label();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.lblNgayNhanPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.flpTrangChuKhachSan = new System.Windows.Forms.FlowLayoutPanel();
            this.ucThongTinPhongCuaKhachSan1 = new Travel.UCThongTinPhongCuaKhachSan();
            this.ucThongTinPhongCuaKhachSan2 = new Travel.UCThongTinPhongCuaKhachSan();
            this.ucThongTinPhongCuaKhachSan3 = new Travel.UCThongTinPhongCuaKhachSan();
            this.ucThongTinPhongCuaKhachSan4 = new Travel.UCThongTinPhongCuaKhachSan();
            this.pnlTienDe.SuspendLayout();
            this.flpTrangChuKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTienDe
            // 
            this.pnlTienDe.Controls.Add(this.btnTimKiemPhong);
            this.pnlTienDe.Controls.Add(this.cboLoaiPhong);
            this.pnlTienDe.Controls.Add(this.dateTimePickerNgayTra);
            this.pnlTienDe.Controls.Add(this.dateTimePickerNgayNhan);
            this.pnlTienDe.Controls.Add(this.lblLuongKhach);
            this.pnlTienDe.Controls.Add(this.lblNgayTraPhong);
            this.pnlTienDe.Controls.Add(this.lblNgayNhanPhong);
            this.pnlTienDe.Controls.Add(this.lblPhong);
            this.pnlTienDe.Location = new System.Drawing.Point(2, 2);
            this.pnlTienDe.Name = "pnlTienDe";
            this.pnlTienDe.Size = new System.Drawing.Size(794, 133);
            this.pnlTienDe.TabIndex = 2;
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhong.Location = new System.Drawing.Point(679, 77);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(108, 34);
            this.btnTimKiemPhong.TabIndex = 12;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Phong Giuong Doi",
            "Phong Giuong Don"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(535, 87);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiPhong.TabIndex = 11;
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(276, 89);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerNgayTra.TabIndex = 10;
            // 
            // dateTimePickerNgayNhan
            // 
            this.dateTimePickerNgayNhan.Location = new System.Drawing.Point(13, 89);
            this.dateTimePickerNgayNhan.Name = "dateTimePickerNgayNhan";
            this.dateTimePickerNgayNhan.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerNgayNhan.TabIndex = 9;
            // 
            // lblLuongKhach
            // 
            this.lblLuongKhach.AutoSize = true;
            this.lblLuongKhach.Location = new System.Drawing.Point(532, 59);
            this.lblLuongKhach.Name = "lblLuongKhach";
            this.lblLuongKhach.Size = new System.Drawing.Size(75, 16);
            this.lblLuongKhach.TabIndex = 8;
            this.lblLuongKhach.Text = "Loại Phòng";
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Location = new System.Drawing.Point(273, 59);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(99, 16);
            this.lblNgayTraPhong.TabIndex = 6;
            this.lblNgayTraPhong.Text = "Ngày trả phòng";
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.AutoSize = true;
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(10, 59);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(113, 16);
            this.lblNgayNhanPhong.TabIndex = 5;
            this.lblNgayNhanPhong.Text = "Ngày nhận phòng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(10, 6);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(169, 32);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng trống";
            // 
            // flpTrangChuKhachSan
            // 
            this.flpTrangChuKhachSan.Controls.Add(this.ucThongTinPhongCuaKhachSan4);
            this.flpTrangChuKhachSan.Controls.Add(this.ucThongTinPhongCuaKhachSan1);
            this.flpTrangChuKhachSan.Controls.Add(this.ucThongTinPhongCuaKhachSan2);
            this.flpTrangChuKhachSan.Controls.Add(this.ucThongTinPhongCuaKhachSan3);
            this.flpTrangChuKhachSan.Location = new System.Drawing.Point(2, 153);
            this.flpTrangChuKhachSan.Name = "flpTrangChuKhachSan";
            this.flpTrangChuKhachSan.Size = new System.Drawing.Size(794, 615);
            this.flpTrangChuKhachSan.TabIndex = 3;
            // 
            // ucThongTinPhongCuaKhachSan1
            // 
            this.ucThongTinPhongCuaKhachSan1.Location = new System.Drawing.Point(3, 161);
            this.ucThongTinPhongCuaKhachSan1.Name = "ucThongTinPhongCuaKhachSan1";
            this.ucThongTinPhongCuaKhachSan1.Size = new System.Drawing.Size(791, 147);
            this.ucThongTinPhongCuaKhachSan1.TabIndex = 0;
            // 
            // ucThongTinPhongCuaKhachSan2
            // 
            this.ucThongTinPhongCuaKhachSan2.Location = new System.Drawing.Point(3, 314);
            this.ucThongTinPhongCuaKhachSan2.Name = "ucThongTinPhongCuaKhachSan2";
            this.ucThongTinPhongCuaKhachSan2.Size = new System.Drawing.Size(791, 147);
            this.ucThongTinPhongCuaKhachSan2.TabIndex = 1;
            // 
            // ucThongTinPhongCuaKhachSan3
            // 
            this.ucThongTinPhongCuaKhachSan3.Location = new System.Drawing.Point(3, 467);
            this.ucThongTinPhongCuaKhachSan3.Name = "ucThongTinPhongCuaKhachSan3";
            this.ucThongTinPhongCuaKhachSan3.Size = new System.Drawing.Size(791, 147);
            this.ucThongTinPhongCuaKhachSan3.TabIndex = 2;
            // 
            // ucThongTinPhongCuaKhachSan4
            // 
            this.ucThongTinPhongCuaKhachSan4.Location = new System.Drawing.Point(3, 3);
            this.ucThongTinPhongCuaKhachSan4.Name = "ucThongTinPhongCuaKhachSan4";
            this.ucThongTinPhongCuaKhachSan4.Size = new System.Drawing.Size(791, 152);
            this.ucThongTinPhongCuaKhachSan4.TabIndex = 3;
            // 
            // XemPhongCuaKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 772);
            this.Controls.Add(this.pnlTienDe);
            this.Controls.Add(this.flpTrangChuKhachSan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XemPhongCuaKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemPhongCuaKhachSan";
            this.pnlTienDe.ResumeLayout(false);
            this.pnlTienDe.PerformLayout();
            this.flpTrangChuKhachSan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTienDe;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhan;
        private System.Windows.Forms.Label lblLuongKhach;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.FlowLayoutPanel flpTrangChuKhachSan;
        private UCThongTinPhongCuaKhachSan ucThongTinPhongCuaKhachSan4;
        private UCThongTinPhongCuaKhachSan ucThongTinPhongCuaKhachSan1;
        private UCThongTinPhongCuaKhachSan ucThongTinPhongCuaKhachSan2;
        private UCThongTinPhongCuaKhachSan ucThongTinPhongCuaKhachSan3;
    }
}