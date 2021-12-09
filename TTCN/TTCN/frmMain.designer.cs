
namespace TTCN
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.btnPhanAnh = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnPhongMay = new System.Windows.Forms.Button();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPhanAnh);
            this.panel1.Controls.Add(this.btnLichSu);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnPhongMay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 870);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.picDangXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 770);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 100);
            this.panel2.TabIndex = 13;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(110, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 39);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "user";
            // 
            // picDangXuat
            // 
            this.picDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDangXuat.Image = global::TTCN.Properties.Resources.icon_dang_xuat;
            this.picDangXuat.Location = new System.Drawing.Point(7, 1);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(100, 100);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDangXuat.TabIndex = 10;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // btnPhanAnh
            // 
            this.btnPhanAnh.FlatAppearance.BorderSize = 0;
            this.btnPhanAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanAnh.Font = new System.Drawing.Font("Palatino Linotype", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanAnh.ForeColor = System.Drawing.Color.White;
            this.btnPhanAnh.Image = global::TTCN.Properties.Resources.icon_phan_anh;
            this.btnPhanAnh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhanAnh.Location = new System.Drawing.Point(0, 589);
            this.btnPhanAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhanAnh.Name = "btnPhanAnh";
            this.btnPhanAnh.Size = new System.Drawing.Size(267, 146);
            this.btnPhanAnh.TabIndex = 4;
            this.btnPhanAnh.Text = "PHẢN ÁNH";
            this.btnPhanAnh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhanAnh.UseVisualStyleBackColor = true;
            this.btnPhanAnh.Click += new System.EventHandler(this.btnPhanAnh_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Palatino Linotype", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.ForeColor = System.Drawing.Color.White;
            this.btnLichSu.Image = global::TTCN.Properties.Resources.icon_lich_su;
            this.btnLichSu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLichSu.Location = new System.Drawing.Point(0, 437);
            this.btnLichSu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(267, 146);
            this.btnLichSu.TabIndex = 3;
            this.btnLichSu.Text = "LỊCH SỬ SỬA ĐỔI";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Image = global::TTCN.Properties.Resources.icon_rai_khoan;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaiKhoan.Location = new System.Drawing.Point(5, 279);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(262, 148);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "NGƯỜI DÙNG";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::TTCN.Properties.Resources.logo_Oschool;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.picLogo.Size = new System.Drawing.Size(267, 141);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnPhongMay
            // 
            this.btnPhongMay.FlatAppearance.BorderSize = 0;
            this.btnPhongMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongMay.Font = new System.Drawing.Font("Palatino Linotype", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongMay.ForeColor = System.Drawing.Color.White;
            this.btnPhongMay.Image = global::TTCN.Properties.Resources.icon_phong_may;
            this.btnPhongMay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhongMay.Location = new System.Drawing.Point(0, 145);
            this.btnPhongMay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhongMay.Name = "btnPhongMay";
            this.btnPhongMay.Size = new System.Drawing.Size(262, 135);
            this.btnPhongMay.TabIndex = 1;
            this.btnPhongMay.Text = "PHÒNG MÁY";
            this.btnPhongMay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhongMay.UseVisualStyleBackColor = true;
            this.btnPhongMay.Click += new System.EventHandler(this.btnPhongMay_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlMove.Location = new System.Drawing.Point(256, 92);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(10, 100);
            this.pnlMove.TabIndex = 2;
            this.pnlMove.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1339, 870);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Oschool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.Panel pnlMove;
        public System.Windows.Forms.Button btnPhongMay;
        public System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.PictureBox picDangXuat;
        public System.Windows.Forms.Button btnLichSu;
        public System.Windows.Forms.Button btnPhanAnh;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
    }
}

