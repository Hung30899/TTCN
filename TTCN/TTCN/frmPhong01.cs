using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmPhong01 : Form
    {
        public char chonND;
        public string tenGV, userCBKT;

        private string mainboard, cpu, ram, ocung, manhinh, banphim, chuot, hdh,phanmem, tinhtrang;
  
        public frmPhong01()
        {
            InitializeComponent();
        }

        private void cboChon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chonND == 'g')
            {
                if (cboChon.Text == "CNTT06")
                {
                    frmPhong06 frm = new frmPhong06();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;                   
                    frm.Show();
                    this.Close();
                    return;
                }
                if (cboChon.Text == "CNTT07")
                {
                    frmPhong07 frm = new frmPhong07();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;
                    frm.Show();
                    this.Close();
                    return;
                }
                if (cboChon.Text == "CNTT09")
                {
                    frmPhong09 frm = new frmPhong09();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;
                    frm.Show();
                    this.Close();
                    return;
                }

            }
            else
            {
                if (cboChon.Text == "CNTT06")
                {
                    frmPhong06 frm = new frmPhong06();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;
                    frm.MdiParent = this.ParentForm;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    this.Close();
                    return;
                }
                if (cboChon.Text == "CNTT07")
                {
                    frmPhong07 frm = new frmPhong07();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;
                    frm.MdiParent = this.ParentForm;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    this.Close();
                    return;
                }
                if (cboChon.Text == "CNTT09")
                {
                    frmPhong09 frm = new frmPhong09();
                    frm.chonND = chonND;
                    frm.tenGV = tenGV;
                    frm.userCBKT = userCBKT;
                    frm.MdiParent = this.ParentForm;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void cboChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (chonND == 'g')
            {
                frmGiangVien frm = new frmGiangVien();
                frm.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        //sự kiện load hình ảnh cho nút máy tính
        private void setImage()
        {
            List<Button> btns = grbSoDo.Controls.OfType<Button>().ToList<Button>();
            foreach (Button btn in btns)
            {
                string tt = Functions.GetFieldValues("Select TinhTrang from MayTinh where mamay='" + btn.Text.Trim() + "' and phongmay ='CNTT01'");
                if (tt == "Hoạt động")
                    btn.Image = Properties.Resources.mt_tt_tot1;
                else
                    btn.Image = Properties.Resources.mt_tt_hong1;
            }
        }

        private void frmPhong01_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            setImage();
            lblTen.Text = Functions.GetFieldValues("Select TenPhongMay from PhongMay where phongmay ='CNTT01'");
            lblViTri.Text = Functions.GetFieldValues("Select DiaChi from PhongMay where phongmay ='CNTT01'");
            lblMayTot.Text = Functions.GetFieldValues("Select count(MaMay) from MayTinh where phongmay ='CNTT01' and TinhTrang =N'Hoạt động'");
            lblMayHong.Text = Functions.GetFieldValues("Select count(MaMay) from MayTinh where phongmay ='CNTT01' and TinhTrang =N'Không hoạt động'");
            lblTinhTrang.Text = Functions.GetFieldValues("Select TrangThai from PhongMay where phongmay ='CNTT01'");
            lblPMM.Text = Functions.GetFieldValues("Select CacPhanMem from MayTinh where phongmay ='CNTT01' and mamay ='M01'");
            lblSoLuong.Text = Functions.GetFieldValues("Select count(MaMay) from MayTinh where phongmay ='CNTT01'");
            //Functions.FillCombo("Select TenPhongMay from PhongMay", cboChon, "TenPhongMay", "TenPhongMay");
            cboChon.Text = "CNTT01";
            if (chonND != 'g')
            {
                grbGV.Visible = false;
                cboChon.Visible = true;
                lblChon.Visible = true;
            }
        }

        //Sự kiện bắt các nút máy tính
        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblSoMay.Text = btn.Text;
            txtSoMay.Text = btn.Text;
            lblMain.Text = Functions.GetFieldValues("Select Mainboard from MayTinh where mamay='" + btn.Text.Trim() + "' and phongmay ='CNTT01'");
            txtMain.Text = lblMain.Text;
            mainboard = lblMain.Text;
            lblCPU.Text = Functions.GetFieldValues("Select CPU from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtCPU.Text = lblCPU.Text;
            cpu = lblCPU.Text;
            lblRAM.Text = Functions.GetFieldValues("Select RAM from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtRAM.Text = lblRAM.Text;
            ram = lblRAM.Text;
            lblOCung.Text = Functions.GetFieldValues("Select OCung from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtOCung.Text = lblOCung.Text;
            ocung = lblOCung.Text;
            lblManHinh.Text = Functions.GetFieldValues("Select ManHinh from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtManHinh.Text = lblManHinh.Text;
            manhinh = lblManHinh.Text;
            lblBanPhim.Text = Functions.GetFieldValues("Select BanPhim from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtBanPhim.Text = lblBanPhim.Text;
            banphim = lblBanPhim.Text;
            lblChuot.Text = Functions.GetFieldValues("Select Chuot from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtChuot.Text = lblChuot.Text;
            chuot = lblChuot.Text;
            lblHDH.Text = Functions.GetFieldValues("Select HeDieuHanh from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtHDH.Text = lblHDH.Text;
            hdh = lblHDH.Text;
            lblPM.Text = Functions.GetFieldValues("Select CacPhanMem from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtPM.Text = lblPM.Text;
            phanmem = lblPM.Text;
            cboTT.Text = Functions.GetFieldValues("Select TinhTrang from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            cboTinhTrang.Text = cboTT.Text;
            tinhtrang = cboTT.Text;
        }

        private void btnPhananh_Click(object sender, EventArgs e)
        {
            string sql;
            if (lblSoMay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn số máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPhanAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin phản ánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanAnh.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn gửi phản ánh không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "INSERT INTO PHANANH(Ten, PhongMay,MaMay,Ngay,NoiDung,TinhTrang)" +
                " VALUES (N'" + tenGV + "',N'" + "CNTT01" + "',N'" + lblSoMay.Text + "',(SELECT GETDATE()),N'" + txtPhanAnh.Text.Trim() + "',N'Chưa xử lý')";
                Functions.RunSQL(sql);
                MessageBox.Show("Đã gửi phản ánh máy: " + lblSoMay.Text + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql = "Update MayTinh Set TinhTrang = N'Không hoạt động' where PhongMay = 'CNTT01' AND MaMay = N'" + lblSoMay.Text + "'";
                Functions.RunSQL(sql);
                reset();
                setImage();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            lblSoMay.Text = "";
            lblMain.Text = "";
            lblCPU.Text = "";
            lblRAM.Text = "";
            lblManHinh.Text = "";
            lblBanPhim.Text = "";
            lblOCung.Text = "";
            lblChuot.Text = "";
            lblHDH.Text = "";
            lblPM.Text = "";
            cboTT.Text = "";
            txtPhanAnh.Text = "";
        }
        private void reset1()
        {
            txtSoMay.Text = "";
            txtMain.Text = "";
            txtCPU.Text = "";
            txtRAM.Text = "";
            txtManHinh.Text = "";
            txtBanPhim.Text = "";
            txtOCung.Text = "";
            txtChuot.Text = "";
            txtHDH.Text = "";
            txtPM.Text = "";
            cboTinhTrang.Text = "";
        }


        private void btnHuy2_Click(object sender, EventArgs e)
        {
            reset1();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSoMay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn số máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMain.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mainboard!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMain.Focus();
                return;
            }
            if (txtCPU.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập CPU!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPU.Focus();
                return;
            }
            if (txtRAM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Ram!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRAM.Focus();
                return;
            }
            if (txtOCung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Ổ cứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOCung.Focus();
                return;
            }
            if (txtManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Màn hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManHinh.Focus();
                return;
            }
            if (txtBanPhim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Bàn phím!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanPhim.Focus();
                return;
            }
            if (txtChuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Chuột!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChuot.Focus();
                return;
            }
            if (txtHDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Hệ điều hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHDH.Focus();
                return;
            }
            if (txtPM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Phầm mềm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPM.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn cập nhật máy " + txtSoMay.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                sql = "Insert into LichSu(Ten,PhongMay,MaMay,Ngay,NoiDung)" +
                    " Values(N'" + userCBKT + "',N'CNTT01',N'" + txtSoMay.Text + "',(SELECT GETDATE())," +
                    "N'" + mainboard + " --> " + txtMain.Text.Trim() + ";" +
                    " " + cpu + " --> " + txtCPU.Text.Trim() + ";" +
                    " " + ram + " --> " + txtRAM.Text.Trim() + ";" +
                    " " + ocung + " --> " + txtOCung.Text.Trim() + ";" +
                    " " + manhinh + " --> " + txtManHinh.Text.Trim() + ";" +
                    " " + banphim + " --> " + txtBanPhim.Text.Trim() + ";" +
                    " " + chuot + " --> " + txtChuot.Text.Trim() + ";" +
                    " " + hdh + " --> " + txtHDH.Text.Trim() + ";" +
                    " " + phanmem + " --> " + txtPM.Text.Trim() + ";" +
                    " " + tinhtrang + " --> " + cboTinhTrang.Text.Trim() + ";')";
                Functions.RunSQL(sql);

                sql = "Update MayTinh Set TinhTrang = N'"+cboTinhTrang.Text+"'," +
                    "Mainboard = N'"+txtMain.Text+"'," +
                    "CPU = N'"+txtCPU.Text+"'," +
                    "RAM = N'"+txtRAM.Text+"'," +
                    "Ocung = N'"+txtOCung.Text+"'," +
                    "ManHinh = N'"+txtManHinh.Text+"'," +
                    "BanPhim = N'"+txtBanPhim.Text+"'," +
                    "Chuot = N'"+txtChuot.Text+"'," +
                    "HeDieuHanh = N'"+txtHDH.Text+"'," +
                    "CacPhanMem = N'"+txtPM.Text+"'" +
                    " where PhongMay = 'CNTT01' AND MaMay = N'" + txtSoMay.Text + "'";
                MessageBox.Show("Đã cập nhật máy: " + lblSoMay.Text + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Functions.RunSQL(sql);
                setImage();

                //sửa tình trạng các phản ánh
                if (cboTinhTrang.Text.Trim() == "Hoạt động")
                {
                    sql = "Select * from PhanAnh Where PhongMay = 'CNTT01' AND MaMay = N'" + txtSoMay.Text + "'";

                    if (Functions.CheckKey(sql))
                    {
                        sql = "Update PhanAnh Set TinhTrang = N'Đã xử lý'" +
                             " where PhongMay = 'CNTT01' AND MaMay = N'" + txtSoMay.Text + "'";
                        Functions.RunSQL(sql);
                    }
                }
                reset1();
            }
        }
    }
}
