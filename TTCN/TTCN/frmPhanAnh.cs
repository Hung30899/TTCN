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

        private void rbnpm_CheckedChanged(object sender, EventArgs e)
        {
            //string sql;
            //rbt = 'p';
            //sql = "SELECT * fROM PhongMay";
            //tblPhanAnh = Functions.GetDataToTable(sql); //Lấy dữ liệu
            //cboSearch.DataSource = tblPhanAnh;
            //cboSearch.DisplayMember = "PhongMay";
            //cboSearch.ValueMember = "PhongMay";
            //cboSearch.Text = "";
        }

        private void rbnmm_CheckedChanged(object sender, EventArgs e)
        {
            //string sql;
            //rbt = 'm';
            //sql = "SELECT DISTINCT MaMay fROM PhanAnh";
            //tblPhanAnh = Functions.GetDataToTable(sql); //Lấy dữ liệu
            //cboSearch.DataSource = tblPhanAnh;
            //cboSearch.DisplayMember = "MaMay";
            //cboSearch.ValueMember = "MaMay";
            //cboSearch.Text = "";
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //string sql;
            //if (cboSearch.Text.Trim() == "")
            //{
            //    sql = "SELECT * FROM PhanAnh";
            //    tblPhanAnh = Functions.GetDataToTable(sql);
            //}
            //if (rbt == 'm')
            //{
            //    sql = "SELECT * FROM PhanAnh WHERE MaMay LIKE N'%" + cboSearch.Text + "%'";
            //    tblPhanAnh = Functions.GetDataToTable(sql);
            //}
            //if (rbt == 'p')
            //{
            //    sql = "SELECT * FROM PhanAnh WHERE PhongMay LIKE N'%" + cboSearch.Text + "%'";
            //    tblPhanAnh = Functions.GetDataToTable(sql);
            //}
            //if (tblPhanAnh.Rows.Count == 0)
            //    MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else MessageBox.Show("Có " + tblPhanAnh.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dgvPA.DataSource = tblPhanAnh;
        }

        private void frmPhanAnh_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadDataGridView();
            rbnpm_CheckedChanged(sender, e);
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

        //private void btnLuu_Click(object sender, EventArgs e)
        //{ 
        //    string sql;
        //    {
        //        if (cbotrangthai.Text.Trim().Length == 0)
        //        {
        //            MessageBox.Show("Trạng thái không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            cbotrangthai.Focus();
        //        }

        //        if (cbotrangthai.Text.Trim().Length != 0)
        //        {
        //            if (MessageBox.Show("Bạn có muốn lưu chỉnh sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //            {
        //                sql = "UPDATE PhanAnh SET TinhTrang=N'" + cbotrangthai.Text.Trim() + "' WHERE ID=N'" + txtid.Text + "'";
        //                Functions.RunSQL(sql);
        //                LoadDataGridView();
        //                MessageBox.Show("Đã cập nhật Phản ánh:" + txtid.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            }
        //        }
        //    }
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PhanAnh order by TinhTrang";
            tblPhanAnh = Functions.GetDataToTable(sql);
            dgvPA.DataSource = tblPhanAnh;
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboTinhTrang.Text = "";
            lblID.Text = "";
            lblMay.Text = "";
            lblPhongMay.Text = "";
        }
    }
}
