using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TTCN.Class
{
    class Functions
    {
        public static SqlConnection Con;
        public static void Connect()
        {
            Con = new SqlConnection(); //Khởi tạo đối tượng kết nối
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + GetPath2("") + @"QLPM.mdf;Integrated Security=True;Connect Timeout=30";
            Con.Open();
            
        }
        public static void RunSQLDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            try
            {
                SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
                DataTable table = new DataTable();
                dap.Fill(table);
                cbo.DataSource = table;
                cbo.ValueMember = ma; //Trường giá trị
                cbo.DisplayMember = ten; //Trường hiển thị   
            }
            catch (Exception ex)
            {

            }
        }

        internal static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter();//Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            dap.SelectCommand = new SqlCommand();//Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand.Connection = Con;
            dap.SelectCommand.CommandText = sql;
            //SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static int GetID(string sql)
        {
            int id=0;
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                id = int.Parse(reader.GetValue(0).ToString());
            reader.Close();
            return id; 
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Con);
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL(update, insert,delete)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void MenuMove(Button btn, Panel pnl)
        {
            pnl.Height = btn.Height - 1;
            pnl.Top = btn.Top;
            pnl.Visible = true;
        }

        //hiển thị form
        public static void MenuClick(Form frm, Form frmM)
        {
            frm.MdiParent = frmM;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        //Đóng các form đang mở
        public static void CloseForm(Form frm)
        {
            if (frm.MdiChildren.Length > 0)
            {
                frm.ActiveMdiChild.Close();
            }
        }
        public static string GetPath2(string fname)
        {

            string startupPath = System.IO.Directory.GetCurrentDirectory();

            startupPath = AppDomain.CurrentDomain.BaseDirectory;
            startupPath = startupPath.Replace("\\bin\\Debug", "");
            return startupPath + fname.Trim();


        }

    }
}
