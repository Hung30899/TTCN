using System;
using System.Data;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmPhanAnh : Form
    {
        DataTable tblPhanAnh;
        char  rbt;      

        public frmPhanAnh()
        {
            InitializeComponent();
        }

        private void frmPhanAnh_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM PhanAnh order by TinhTrang, Ngay desc";
            tblPhanAnh = Functions.GetDataToTable(sql); //Lấy dữ liệu
            dgvPA.DataSource = tblPhanAnh; //Hiển thị vào dataGridView
            dgvPA.Columns[0].HeaderText = "ID";
            dgvPA.Columns[1].HeaderText = "Tên giảng viên";
            dgvPA.Columns[2].HeaderText = "Phòng máy";
            dgvPA.Columns[3].HeaderText = "Mã máy";
            dgvPA.Columns[4].HeaderText = "Ngày";
            dgvPA.Columns[5].HeaderText = "Nội dung";
            dgvPA.Columns[6].HeaderText = "Tình trạng";

            dgvPA.Columns[0].Width = 20;
            dgvPA.Columns[1].Width = 100;
            dgvPA.Columns[2].Width = 70;
            dgvPA.Columns[3].Width = 50;
            dgvPA.Columns[4].Width = 50;
            dgvPA.Columns[5].Width = 500;
            dgvPA.Columns[6].Width = 150;
            dgvPA.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True; //Xuống dòng ô nội dung trong datagridview

            dgvPA.AllowUserToAddRows = false;
            dgvPA.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void dgvPA_Click_1(object sender, EventArgs e)
        {
            if (tblPhanAnh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboTinhTrang.Text = dgvPA.CurrentRow.Cells[6].Value.ToString();
            lblID.Text = dgvPA.CurrentRow.Cells[0].Value.ToString();
            lblPhongMay.Text = dgvPA.CurrentRow.Cells[2].Value.ToString();
            lblMay.Text = dgvPA.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboSearch.Text == "CNTT01")
            {
                sql = "SELECT * FROM PhanAnh Where PhongMay = 'CNTT01' order by TinhTrang";
                tblPhanAnh = Functions.GetDataToTable(sql);
            }
            if (cboSearch.Text == "CNTT06")
            {
                sql = "SELECT * FROM PhanAnh Where PhongMay = 'CNTT06' order by TinhTrang";
                tblPhanAnh = Functions.GetDataToTable(sql);
            }
            if (cboSearch.Text == "CNTT07")
            {
                sql = "SELECT * FROM PhanAnh Where PhongMay = 'CNTT07' order by TinhTrang";
                tblPhanAnh = Functions.GetDataToTable(sql);
            }
            if (cboSearch.Text == "CNTT09")
            {
                sql = "SELECT * FROM PhanAnh Where PhongMay = 'CNTT08' order by TinhTrang";
                tblPhanAnh = Functions.GetDataToTable(sql);
            }
            dgvPA.DataSource = tblPhanAnh;
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PhanAnh order by TinhTrang";
            tblPhanAnh = Functions.GetDataToTable(sql);
            dgvPA.DataSource = tblPhanAnh;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu chỉnh sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (cboTinhTrang.Text == "Đã xử lý")
                {
                    string sql = "Update PhanAnh Set TinhTrang = N'" + cboTinhTrang.Text.Trim() + "'" +
                       " where id ='" + lblID.Text + "' ";
                    Functions.RunSQL(sql);
                    sql = "Update MayTinh Set TinhTrang = N'Hoạt động'" +
                       " where PhongMay = N'" + lblPhongMay.Text + "' AND MaMay =N'" + lblMay.Text + "'";
                    Functions.RunSQL(sql);
                }
                if (cboTinhTrang.Text == "Chưa xử lý")
                {
                    string sql = "Update PhanAnh Set TinhTrang = N'" + cboTinhTrang.Text.Trim() + "'" +
                       " where id ='" + lblID.Text + "' ";
                    Functions.RunSQL(sql);
                    sql = "Update MayTinh Set TinhTrang = N'Không hoạt động'" +
                       " where PhongMay = N'" + lblPhongMay.Text + "' AND MaMay =N'" + lblMay.Text + "'";
                    Functions.RunSQL(sql);
                }

                MessageBox.Show("Đã lưu chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            cboTinhTrang.Text = "";
            lblID.Text = "";
            lblMay.Text = "";
            lblPhongMay.Text = "";
        }
    }
}
