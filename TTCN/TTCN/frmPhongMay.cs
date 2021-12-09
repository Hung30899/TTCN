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

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
