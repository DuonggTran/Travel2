namespace Travel
{
    partial class DanhGia
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
            this.flpDanhGia = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVietDanhGia = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblBaiDanhGia = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.pnlDanhGia = new System.Windows.Forms.Panel();
            this.pnlTieuDe.SuspendLayout();
            this.pnlDanhGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpDanhGia
            // 
            this.flpDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDanhGia.Location = new System.Drawing.Point(-1, 52);
            this.flpDanhGia.Name = "flpDanhGia";
            this.flpDanhGia.Size = new System.Drawing.Size(811, 559);
            this.flpDanhGia.TabIndex = 4;
            // 
            // btnVietDanhGia
            // 
            this.btnVietDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVietDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietDanhGia.Location = new System.Drawing.Point(664, 8);
            this.btnVietDanhGia.Name = "btnVietDanhGia";
            this.btnVietDanhGia.Size = new System.Drawing.Size(134, 39);
            this.btnVietDanhGia.TabIndex = 1;
            this.btnVietDanhGia.Text = "Viết đánh giá";
            this.btnVietDanhGia.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(72, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(484, 25);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Chúng tôi cố gắng mang đến 100% đánh giá chân thật";
            // 
            // lblBaiDanhGia
            // 
            this.lblBaiDanhGia.AutoSize = true;
            this.lblBaiDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiDanhGia.Location = new System.Drawing.Point(3, 12);
            this.lblBaiDanhGia.Name = "lblBaiDanhGia";
            this.lblBaiDanhGia.Size = new System.Drawing.Size(264, 25);
            this.lblBaiDanhGia.TabIndex = 3;
            this.lblBaiDanhGia.Text = "Bài đánh giá của khách hàng";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.btnVietDanhGia);
            this.pnlTieuDe.Location = new System.Drawing.Point(2, 3);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(811, 54);
            this.pnlTieuDe.TabIndex = 7;
            // 
            // pnlDanhGia
            // 
            this.pnlDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhGia.Controls.Add(this.flpDanhGia);
            this.pnlDanhGia.Controls.Add(this.lblBaiDanhGia);
            this.pnlDanhGia.Location = new System.Drawing.Point(2, 56);
            this.pnlDanhGia.Name = "pnlDanhGia";
            this.pnlDanhGia.Size = new System.Drawing.Size(811, 612);
            this.pnlDanhGia.TabIndex = 8;
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 671);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.pnlDanhGia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhGia";
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlDanhGia.ResumeLayout(false);
            this.pnlDanhGia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDanhGia;
        private System.Windows.Forms.Button btnVietDanhGia;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblBaiDanhGia;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Panel pnlDanhGia;
    }
}