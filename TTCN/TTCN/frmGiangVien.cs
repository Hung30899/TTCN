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
            if (cboTenGV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên giảng viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTenGV.Focus();
                return;
            }
            if (cboPhongHoc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongHoc.Focus();
                return;
            }
            tenGV = cboTenGV.Text;
            phongHoc = cboPhongHoc.Text;
            if (phongHoc != "CNTT01" && phongHoc != "CNTT06" && phongHoc != "CNTT07" && phongHoc != "CNTT09")
            {
                MessageBox.Show("Bạn cần chọn đúng tên phòng học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongHoc.Focus();
                return;
            }
            this.Close();
            if (phongHoc == "CNTT01")
            {
                frmPhong01 frmPhong01 = new frmPhong01();
                frmPhong01.chonND = 'g';
                frmPhong01.tenGV = tenGV;
                frmPhong01.Show();
                return;
            }
            if (phongHoc == "CNTT06")
            {
                frmPhong06 frmPhong06 = new frmPhong06();
                frmPhong06.chonND = 'g';
                frmPhong06.tenGV = tenGV;
                frmPhong06.Show();
                return;            
            }
            if (phongHoc == "CNTT07")
            {
                frmPhong07 frmPhong07 = new frmPhong07();
                frmPhong07.chonND = 'g';
                frmPhong07.tenGV = tenGV;
                frmPhong07.Show();
                return;
            }
            if (phongHoc == "CNTT09")
            {
                frmPhong09 frmPhong09 = new frmPhong09();
                frmPhong09.chonND = 'g';
                frmPhong09.tenGV = tenGV;
                frmPhong09.Show();
                return;
            }
            
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
