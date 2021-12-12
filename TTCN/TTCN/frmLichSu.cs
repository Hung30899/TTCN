using System;
using System.Data;
using System.Windows.Forms;
using TTCN.Class;

namespace TTCN
{
    public partial class frmLichSu : Form
    {

        DataTable tblLichSu;
        char rbt;

        public frmLichSu()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM LichSu";
            tblLichSu = Functions.GetDataToTable(sql); //Lấy dữ liệu
            dgvLS.DataSource = tblLichSu; //Hiển thị vào dataGridView
            dgvLS.Columns[0].HeaderText = "ID";
            dgvLS.Columns[1].HeaderText = "Tên";
            dgvLS.Columns[2].HeaderText = "Phòng máy";
            dgvLS.Columns[3].HeaderText = "Mã máy";
            dgvLS.Columns[4].HeaderText = "Ngày";
            dgvLS.Columns[5].HeaderText = "Nội dung";

            dgvLS.Columns[0].Width = 50;
            dgvLS.Columns[1].Width = 50;
            dgvLS.Columns[2].Width = 50;
            dgvLS.Columns[3].Width = 50;
            dgvLS.Columns[4].Width = 50;
            dgvLS.Columns[5].Width = 500;
            dgvLS.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True; //Xuống dòng ô nội dung trong datagridview
            dgvLS.AllowUserToAddRows = false;
            dgvLS.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void rbnpm_CheckedChanged(object sender, EventArgs e)
        {
            string sql;
            rbt = 'p';
            sql = "SELECT * fROM PhongMay";
            tblLichSu = Functions.GetDataToTable(sql); //Lấy dữ liệu
            cboSearch.DataSource = tblLichSu;
            cboSearch.DisplayMember = "PhongMay";
            cboSearch.ValueMember = "PhongMay";
            cboSearch.Text = "";
        }

        private void rbnmm_CheckedChanged(object sender, EventArgs e)
        {
            string sql;
            rbt = 'm';
            sql = "SELECT DISTINCT MaMay fROM LichSu";
            tblLichSu = Functions.GetDataToTable(sql); //Lấy dữ liệu
            cboSearch.DataSource = tblLichSu;
            cboSearch.DisplayMember = "MaMay";
            cboSearch.ValueMember = "MaMay";
            cboSearch.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboSearch.Text.Trim() == "")
            {
                sql = "SELECT * FROM LichSu";
                tblLichSu = Functions.GetDataToTable(sql);
            }
            if (rbt == 'm')
            {
                sql = "SELECT * FROM LichSu WHERE MaMay LIKE N'%" + cboSearch.Text + "%'";
                tblLichSu = Functions.GetDataToTable(sql);
            }
            if (rbt == 'p') 
            {
                sql = "SELECT * FROM LichSu WHERE PhongMay LIKE N'%" + cboSearch.Text + "%'";
                tblLichSu = Functions.GetDataToTable(sql);
            }
            if (tblLichSu.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblLichSu.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvLS.DataSource = tblLichSu;
        }

        private void frmLichSu_Load_1(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadDataGridView();
            rbnpm_CheckedChanged(sender, e);
        }
    }
}
