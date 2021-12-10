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
    public partial class frmPhongMay : Form
    {
        public string user;
        public frmPhongMay()
        {
            InitializeComponent();
        }
        private void frmPhongMay_Load(object sender, EventArgs e)
        {

        }

        private void btnPhong01_Click(object sender, EventArgs e)
        {
            frmPhong01 frm = new frmPhong01();
            frm.MdiParent = this.ParentForm;
            frm.Dock = DockStyle.Fill;
            frm.userCBKT = user;
            frm.Show();
        }

        private void btnPhong07_Click(object sender, EventArgs e)
        {
            frmPhong07 frm = new frmPhong07();
            frm.MdiParent = this.ParentForm;
            frm.Dock = DockStyle.Fill;
            frm.userCBKT = user;
            frm.Show();
        }

        private void btnPhong06_Click(object sender, EventArgs e)
        {
            frmPhong06 frm = new frmPhong06();
            frm.MdiParent = this.ParentForm;
            frm.Dock = DockStyle.Fill;
            frm.userCBKT = user;
            frm.Show();
        }

        private void btnPhong09_Click(object sender, EventArgs e)
        {
            frmPhong09 frm = new frmPhong09();
            frm.MdiParent = this.ParentForm;
            frm.Dock = DockStyle.Fill;
            frm.userCBKT = user;
            frm.Show();
        }
    }
}
