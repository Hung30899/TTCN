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
    public partial class frmNguoiDung : Form
    {
        DataTable tblUser; // Lưu dữ liệu bảng người dùng;
        Char btn, rbt;

       
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGridView();
            Disable();
            rbnUser_CheckedChanged(sender, e);
        }

        private void Disable()
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtHoTen.Enabled = false;
            txtBoMon.Enabled = false;
            txtSDT.Enabled = false;

            rbnNam.Enabled = false;
            rbnNu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            Disable();
        }
        private void ResetValues()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtBoMon.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            string sql, gt;
            {
                if (txtUser.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                if (txtPass.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    return;
                }
                if (txtBoMon.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoMon.Focus();
                    return;
                }
                if (txtHoTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }

              
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return;
                }
               

                if (rbnNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                //Thêm người dùng
                if (btn == 't')
                {
                    sql = "SELECT Username FROM NguoiDung WHERE Username=N'" + txtUser.Text.Trim() + "'";
                    if (Functions.CheckKey(sql))
                    {
                        MessageBox.Show("Username này đã có, bạn phải nhập Username khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Focus();
                        txtUser.Text = "";
                        return;
                    }

                    sql = "INSERT INTO NguoiDung(Username,Password,HoTen,GioiTinh,BoMon,SDT) VALUES" +
                       "(N'" + txtUser.Text.Trim() + "',N'" + txtPass.Text.Trim() + "',N'" + txtHoTen.Text.Trim() + "',N'"
                       + gt + "','" + txtBoMon.Text + "','" + txtSDT.Text.Trim() + "')";


                    Functions.RunSQL(sql);
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm người dùng mới: "+txtUser.Text+" !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    btnXoa.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    Disable();
                }
                //Sửa người dùng
                if (btn == 's')
                {
                    if (MessageBox.Show("Bạn có muốn lưu chỉnh sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        sql = "UPDATE NguoiDung SET Password=N'" + txtPass.Text.Trim() + "',HoTen=N'" + txtHoTen.Text.Trim() + "'," +
                        "GioiTinh=N'" + gt + "',BoMon='" + txtBoMon.Text + "'," +
                        "SDT=N'" + txtSDT.Text.Trim() + "' WHERE Username=N'" + txtUser.Text + "'";

                        Functions.RunSQL(sql);
                        LoadDataGridView();
                        MessageBox.Show("Đã cập nhật User: " + txtUser.Text + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetValues();
                        btnXoa.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        Disable();
                    }
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btn = 's';
            if (tblUser.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (txtUser.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            Enable();
            txtUser.Enabled = false;
            
        }

        private void Enable()
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtHoTen.Enabled = true;
            txtBoMon.Enabled = true;
            txtSDT.Enabled = true;
           
            rbnNam.Enabled = true;
            rbnNu.Enabled = true;
       
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            btn = 't';
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            Enable();
            txtUser.Focus();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (tblUser.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NguoiDung WHERE Username=N'" + txtUser.Text + "'";
                Functions.RunSQLDel(sql);
                LoadDataGridView();
                ResetValues();
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (cboSearch.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSearch.Focus();
                return;
            }
            if (rbt == 'u') //Tìm kiếm theo Username
            {
                sql = "SELECT * FROM NguoiDung WHERE Username LIKE N'%" + cboSearch.Text + "%'";
                tblUser = Functions.GetDataToTable(sql);
            }
            if (rbt == 'n') //Tìm kiếm theo Tên
            {
                sql = "SELECT * FROM NguoiDung WHERE HoTen LIKE N'%" + cboSearch.Text + "%'";
                tblUser = Functions.GetDataToTable(sql);
            }
            if (tblUser.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblUser.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUser.DataSource = tblUser;
            ResetValues();
            
        }

        private void rbnUser_CheckedChanged(object sender, EventArgs e)
        {
            string sql;
            rbt = 'u';
            sql = "SELECT * fROM NguoiDung";
            tblUser = Functions.GetDataToTable(sql); //Lấy dữ liệu
            cboSearch.DataSource = tblUser;
            cboSearch.DisplayMember = "Username";
            cboSearch.ValueMember = "Username";
            cboSearch.Text = "";
        }

        private void rbnTen_CheckedChanged(object sender, EventArgs e)
        {

            string sql;
            rbt = 'n';
            sql = "SELECT * fROM NguoiDung";
            tblUser = Functions.GetDataToTable(sql); //Lấy dữ liệu
            cboSearch.DataSource = tblUser;
            cboSearch.DisplayMember = "HoTen";
            cboSearch.ValueMember = "HoTen";
            cboSearch.Text = "";
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();  
                return;
            }
            if (tblUser.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            if (dgvUser.CurrentRow.Cells[3].Value.ToString() == "Nam")
                rbnNam.Checked = true;
            else rbnNu.Checked = true;
            txtBoMon.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            Disable();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NguoiDung";
            tblUser = Functions.GetDataToTable(sql); //Lấy dữ liệu
            dgvUser.DataSource = tblUser; //Hiển thị vào dataGridView
            dgvUser.Columns[0].HeaderText = "Username";
            dgvUser.Columns[1].HeaderText = "Password";
            dgvUser.Columns[2].HeaderText = "Họ tên";
            dgvUser.Columns[3].HeaderText = "Giới tính";
            dgvUser.Columns[4].HeaderText = "Bộ môn";
            dgvUser.Columns[5].HeaderText = "SDT";

            dgvUser.Columns[0].Width = 260;
            dgvUser.Columns[1].Width = 260;
            dgvUser.Columns[2].Width = 260;
            dgvUser.Columns[3].Width = 260;
            dgvUser.Columns[4].Width = 260;
            dgvUser.Columns[5].Width = 260;

            dgvUser.AllowUserToAddRows = false;
            dgvUser.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
