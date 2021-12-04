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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhongMay_Click(object sender, EventArgs e)
        {
            Functions.CloseForm(this);
            Functions.MenuMove(btnPhongMay, pnlMove);
            frmPhongMay frm = new frmPhongMay();
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

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
