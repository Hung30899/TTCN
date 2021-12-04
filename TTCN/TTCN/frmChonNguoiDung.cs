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
    public partial class frmChonNguoiDung : Form
    {
        public frmChonNguoiDung()
        {
            InitializeComponent();
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien frmGV = new frmGiangVien();
            this.Hide();
            frmGV.Show();
        }

        private void btnCanBoKyThuat_Click(object sender, EventArgs e)
        {
            frmCanBoKyThuat frmCBQL = new frmCanBoKyThuat();
            this.Hide();
            frmCBQL.Show();
        }

        private void frmChonNguoiDung_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }
    }
}
