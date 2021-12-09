using System;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmGiangVien : Form
    {
        public string tenGV, phongHoc;
        
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTenGiangVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGiangVien.Focus();
                return;
            }
            if (cboPhongHoc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongHoc.Focus();
                return;
            }

            tenGV = txtTenGiangVien.Text;
            phongHoc = cboPhongHoc.Text;
            this.Close();
            if (phongHoc == "CNTT01")
            {
                frmPhong01 frmPhong01 = new frmPhong01();
                frmPhong01.chonND = 'g';
                frmPhong01.tenGV = tenGV;
                frmPhong01.Show();
                return;
            }
            if (phongHoc == "CNTT09")
            {
                return;
            }
            //this.Close();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChonNguoiDung frmCND = new frmChonNguoiDung();
            frmCND.Show();
        }

        private void selectClass()
        {
            string sql;
            sql = "Select * from PhongMay";
            Functions.FillCombo(sql, cboPhongHoc, "PhongMay", "PhongMay");
            cboPhongHoc.Text = "";
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            selectClass();
        }
    }
}
