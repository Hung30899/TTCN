
namespace TTCN
{
    partial class frmPhongMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongMay));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhong01 = new System.Windows.Forms.Button();
            this.btnPhong07 = new System.Windows.Forms.Button();
            this.btnPhong06 = new System.Windows.Forms.Button();
            this.btnPhong09 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 109);
            this.panel3.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::TTCN.Properties.Resources.icon_phong_may;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG MÁY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPhong01
            // 
            this.btnPhong01.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong01.Image")));
            this.btnPhong01.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhong01.Location = new System.Drawing.Point(314, 292);
            this.btnPhong01.Name = "btnPhong01";
            this.btnPhong01.Size = new System.Drawing.Size(186, 167);
            this.btnPhong01.TabIndex = 31;
            this.btnPhong01.Text = "Phòng CNTT01";
            this.btnPhong01.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong01.UseVisualStyleBackColor = true;
            this.btnPhong01.Click += new System.EventHandler(this.btnPhong01_Click);
            // 
            // btnPhong07
            // 
            this.btnPhong07.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong07.Image")));
            this.btnPhong07.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhong07.Location = new System.Drawing.Point(840, 292);
            this.btnPhong07.Name = "btnPhong07";
            this.btnPhong07.Size = new System.Drawing.Size(186, 167);
            this.btnPhong07.TabIndex = 32;
            this.btnPhong07.Text = "Phòng CNTT07";
            this.btnPhong07.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong07.UseVisualStyleBackColor = true;
            this.btnPhong07.Click += new System.EventHandler(this.btnPhong07_Click);
            // 
            // btnPhong06
            // 
            this.btnPhong06.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong06.Image")));
            this.btnPhong06.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhong06.Location = new System.Drawing.Point(314, 583);
            this.btnPhong06.Name = "btnPhong06";
            this.btnPhong06.Size = new System.Drawing.Size(186, 167);
            this.btnPhong06.TabIndex = 33;
            this.btnPhong06.Text = "Phòng CNTT06";
            this.btnPhong06.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong06.UseVisualStyleBackColor = true;
            this.btnPhong06.Click += new System.EventHandler(this.btnPhong06_Click);
            // 
            // btnPhong09
            // 
            this.btnPhong09.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong09.Image")));
            this.btnPhong09.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhong09.Location = new System.Drawing.Point(840, 572);
            this.btnPhong09.Name = "btnPhong09";
            this.btnPhong09.Size = new System.Drawing.Size(186, 167);
            this.btnPhong09.TabIndex = 34;
            this.btnPhong09.Text = "Phòng CNTT09";
            this.btnPhong09.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong09.UseVisualStyleBackColor = true;
            this.btnPhong09.Click += new System.EventHandler(this.btnPhong09_Click);
            // 
            // frmPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TTCN.Properties.Resources.nen_pmay;
            this.ClientSize = new System.Drawing.Size(1387, 1061);
            this.Controls.Add(this.btnPhong09);
            this.Controls.Add(this.btnPhong06);
            this.Controls.Add(this.btnPhong07);
            this.Controls.Add(this.btnPhong01);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmPhongMay";
            this.Text = "Phòng máy";
            this.Load += new System.EventHandler(this.frmPhongMay_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhong01;
        private System.Windows.Forms.Button btnPhong07;
        private System.Windows.Forms.Button btnPhong06;
        private System.Windows.Forms.Button btnPhong09;
    }
}