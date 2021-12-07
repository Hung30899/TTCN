using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmPhong01 : Form
    {
        public frmPhong01()
        {
            InitializeComponent();
        }

        private void setImage()
        {
            List<Button> btns = grbSoDo.Controls.OfType<Button>().ToList<Button>();
            foreach(Button btn in btns)
            {
                string tt = Functions.GetFieldValues("Select TinhTrang form MayTinh where mamay='" + btn.Text.Trim() + "' and phongmay ='CNTT01'");
                if(tt =="Hoạt động")
                    btn.Image = Properties.Resources.mt_tt_tot1;
                else
                    btn.Image = Properties.Resources.mt_tt_hong1;
            }
        }
        private void frmPhong01_Load(object sender, EventArgs e)
        {
            setImage();
            lblTen.Text = Functions.GetFieldValues("Select TenPhongMay from PhongMay where phongmay ='CNTT01'");
            lblViTri.Text = Functions.GetFieldValues("Select DiaChi from PhongMay where phongmay ='CNTT01'");
            lblMayTot.Text = Functions.GetFieldValues("Select count(MaMay) from MayTinh where phongmay ='CNTT01' and TinhTrang =N'Hoạt động'");
            lblMayHong.Text = Functions.GetFieldValues("Select count(MaMay) from MayTinh where phongmay ='CNTT01' and TinhTrang =N'Không hoạt động'");
            lblTT.Text = Functions.GetFieldValues("Select TrangThai from PhongMay where phongmay ='CNTT01'");
            lblPMM.Text = Functions.GetFieldValues("Select CacPhanMem from MayTinh where phongmay ='CNTT01' and mamay ='MAY01'");
            cboChon.Text = "CNTT01";
            Functions.FillCombo("Select TenPhongMay from PhongMay", cboTT, "TenPhongMay", "TenPhongMay");

        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblSoMay.Text = btn.Text;
            txtSoMay.Text = btn.Text;
            lblMain.Text = Functions.GetFieldValues("Select Mainborad from MayTinh where mamay='" + btn.Text.Trim() + "' and phongmay ='CNTT01'");
            txtMain.Text = lblMain.Text;
            lblCPU.Text = Functions.GetFieldValues("Select CPU from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtCPU.Text = lblCPU.Text;
            lblRam.Text = Functions.GetFieldValues("Select RAM from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtRAM.Text = lblRam.Text;
            lblOCung.Text = Functions.GetFieldValues("Select OCung from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtOCung.Text = lblOCung.Text;
            lblManHinh.Text = Functions.GetFieldValues("Select ManHinh from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtManHinh.Text = lblManHinh.Text;
            lblBanPhim.Text = Functions.GetFieldValues("Select BanPhim from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtBanPhim.Text = lblBanPhim.Text;
            lblChuot.Text = Functions.GetFieldValues("Select Chuot from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtChuot.Text = lblChuot.Text;
            lblHDH.Text = Functions.GetFieldValues("Select HeDieuHanh from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtHDH.Text = lblHDH.Text;
            lblPM.Text = Functions.GetFieldValues("Select CacPhanMem from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            txtPM.Text = lblPM.Text;
            Functions.FillCombo("Select TinhTrang from MayTinh", cboTT, "TinhTrang", "TinhTrang");
            Functions.FillCombo("Select TinhTrang from MayTinh", cboTinhTrang, "TinhTrang", "TinhTrang");
            cboTT.Text = Functions.GetFieldValues("Select TinhTrang from MayTinh where mamay = '" + btn.Text.Trim() + "' and phongmay = 'CNTT01'");
            cboTinhTrang.Text = cboTT.Text;

        }

        private void cboChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
