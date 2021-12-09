using System;
using System.Windows.Forms;
using TTCN.Class;


namespace TTCN
{
    public partial class frmMain : Form
    {
        public string user;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhongMay_Click(object sender, EventArgs e)
        {
            Functions.CloseForm(this);
            Functions.MenuMove(btnPhongMay, pnlMove);
            frmPhongMay frm = new frmPhongMay();
            frm.user = user;
            Functions.MenuClick(frm, this);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Functions.CloseForm(this);
            Functions.MenuMove(btnTaiKhoan, pnlMove);
            frmNguoiDung frm = new frmNguoiDung();
            Functions.MenuClick(frm, this);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Functions.CloseForm(this);
            Functions.MenuMove(btnLichSu, pnlMove);
            frmLichSu frm = new frmLichSu();
            Functions.MenuClick(frm, this);
        }

        private void btnPhanAnh_Click(object sender, EventArgs e)
        {
            Functions.CloseForm(this);
            Functions.MenuMove(btnPhanAnh, pnlMove);
            frmPhanAnh frm = new frmPhanAnh();
            Functions.MenuClick(frm, this);
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            lblUser.Text = "";
            frmCanBoKyThuat frmCanBoKyThuat = new frmCanBoKyThuat();
            frmCanBoKyThuat.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = user;
        }
    }
}
