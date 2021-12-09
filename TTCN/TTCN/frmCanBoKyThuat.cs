using System;
using System.Data;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmCanBoKyThuat : Form
    {
        public frmCanBoKyThuat()
        {
            InitializeComponent();
        }
        public string GetUser()
        {
            string user = "";
            try
            {
                DataTable tblLogin;
                string sql;
                sql = "SELECT * FROM NguoiDung WHERE Username = N'" + txtUser.Text.Trim() + "'AND Password = N'" + txtPass.Text.Trim() + "'";
                tblLogin = Functions.GetDataToTable(sql);
                if (tblLogin != null)
                {
                    foreach (DataRow dr in tblLogin.Rows)
                    {
                        user = dr["userName"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            return user;
        }
        
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable tblLogin;
            string sql;

            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            sql = "SELECT * FROM NguoiDung WHERE Username =N'" + txtUser.Text.Trim() + "' AND Password=N'" + txtPass.Text.Trim() + "'";
            tblLogin = Functions.GetDataToTable(sql);

            if (tblLogin.Rows.Count > 0)
            {
                frmMain frm = new frmMain();
                frm.user = GetUser();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai toài khoản hoặc mật khẩu!");
                txtUser.Focus();
            }
            
        }

        private void frmCanBoQuanLy_Load(object sender, EventArgs e)
        {
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChonNguoiDung frmCND = new frmChonNguoiDung();
            frmCND.Show();
        }
    }
}
