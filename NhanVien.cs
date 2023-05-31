using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PayrollManagement.Model;

namespace PayrollManagement
{
    public partial class NhanVien : Form
    {
        
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        readonly SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<ChucVuModel> lstCV = new List<ChucVuModel>();
        List<TrinhDoModel> lstTD = new List<TrinhDoModel>();
        List<PhongBanModel> lstPB = new List<PhongBanModel>();
        
        int idNhanvien=0;
        public NhanVien()
        {
            InitializeComponent();
            ListCV();
            ListTD();           
            ListPB();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            
            showCV();
            showTD();
            showPB();
            ViewNV();
        }
        private void showCV()
        {

            chucvuTxt.ValueMember = "tenCV";
            chucvuTxt.DataSource = lstCV;

        }
        private void showTD()
        {

            trinhdoTxt.ValueMember = "tenTD";
            trinhdoTxt.DataSource = lstTD;

        }
        private void showPB()
        {

            pbTxt.ValueMember = "tenPB";
            pbTxt.DataSource = lstPB;

        }
        public void ListCV()
        {
            connection.Open();
            string query = "SELECT * FROM V_ChucVu";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ChucVuModel a = new ChucVuModel(Convert.ToInt32(row["idCV"]),
                                                row["tenCV"].ToString());
                lstCV.Add(a);
            }
            connection.Close();
        }
        public void ListTD()
        {
            connection.Open();
            string query = "SELECT * FROM V_TrinhDo";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                TrinhDoModel a = new TrinhDoModel(Convert.ToInt32(row["idTD"]),
                                                    row["tenTD"].ToString());
                lstTD.Add(a);
            }
            connection.Close();
        }
        public void ListPB()
        {
            connection.Open();
            string query = "SELECT * FROM V_PhongBan";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                PhongBanModel a = new PhongBanModel(Convert.ToInt32(row["idPB"]),
                                                    row["tenPB"].ToString());
                lstPB.Add(a);
            }
            connection.Close();
        }
        public DataTable TimKiem_TenNV(string name)
        {
            connection.Open();
            string query = "select * from FN_NhanVien_Name(N'" + name + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        void ViewNV()
        {
            connection.Open();
            var query = "select * from V_NhanVien";
            var q = new SqlDataAdapter(query, connection);
            var ds = new DataSet();
            q.Fill(ds,"nhanvien");
            nhanvienView.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void themnvBtn_Click(object sender, EventArgs e)
        {
            var nv = new formSua(idNhanvien);
            nv.Show();
        }

        private void reLoadView_Click(object sender, EventArgs e)
        {
            ViewNV();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                ViewNV();
            }
            else
            {
                nhanvienView.DataSource = TimKiem_TenNV(searchTxt.Text);
            }
        }

        private void ReloadImg_Click(object sender, EventArgs e)
        {
            ViewNV();
        }

        private void nhanvienView_SelectionChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {

                i = nhanvienView.CurrentRow.Index;
                idNhanvien = Convert.ToInt32(nhanvienView.Rows[i].Cells[0].Value.ToString());
            }
            catch
            {
                return;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var nv = new formThem();
            nv.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (nhanvienView.SelectedRows.Count > 0)
            {
                int i = nhanvienView.CurrentRow.Index;
                string strMaNV = nhanvienView.Rows[i].Cells[0].Value.ToString();
                string strTenNV = nhanvienView.Rows[i].Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên mã " + strMaNV + " có tên là " + strTenNV + " không ?","Hỏi lại",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var del = db.SP_Xoa_NhanVien(idNhanvien);
                        MessageBox.Show("successfull");
                        ViewNV();
                    }
                    catch
                    {
                        MessageBox.Show("failed");
                    }
                }
            }  
            
        }

        

        private void chucvuTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstCV.Where(p => p.TenCV == chucvuTxt.SelectedValue.ToString()).Select(p => p.TenCV);
            connection.Open();
            string query = "select * from FN_NhanVien_CV(N'" + a.FirstOrDefault().ToString() + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            nhanvienView.DataSource = dt;
        }

        private void trinhdoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstTD.Where(p => p.TenTD == trinhdoTxt.SelectedValue.ToString()).Select(p => p.TenTD);
            connection.Open();
            string query = "select * from FN_NhanVien_TD(N'" + a.FirstOrDefault().ToString() + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            nhanvienView.DataSource = dt;
        }

        private void pbTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstPB.Where(p => p.TenPB == pbTxt.SelectedValue.ToString()).Select(p => p.TenPB);
            connection.Open();
            string query = "select * from FN_NhanVien_PB(N'" + a.FirstOrDefault().ToString() + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            nhanvienView.DataSource = dt;
        }
    }
}
