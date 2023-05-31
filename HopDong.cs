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
    public partial class HopDong : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<HDModel> lstHD = new List<HDModel>();
        public HopDong()
        {
            InitializeComponent();
            ListHD();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            getidHD();
            viewHD();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var add = db.SP_Them_HD(tenhd.Text.ToString(),loaihd.Text.ToString(),Convert.ToInt32(thoihan.Text));
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var update = db.SP_CapNhat_HD(Convert.ToInt32(mahd.Text), tenhd.Text.ToString(),loaihd.Text.ToString(),Convert.ToInt32(thoihan.Text));
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var del = db.SP_Xoa_HD(Convert.ToInt32(mahd.Text));
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }
        void viewHD()
        {
            viewhd.DataSource = lstHD;
        }
        public void ListHD()
        {
            connection.Open();
            string query = "SELECT * FROM V_HopDong";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                HDModel a = new HDModel(Convert.ToInt32(row["idHD"]),
                                                    row["tenHD"].ToString(),
                                                    row["loaiHD"].ToString(),
                                                    Convert.ToInt32(row["thoiHan"]));
                lstHD.Add(a);
            }
            connection.Close();
        }
        void getidHD()
        {
            mahd.ValueMember = "idHD";
            mahd.DataSource = lstHD;

        }
        private void mahd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstHD.Where(p => p.IdHD == Convert.ToInt32(mahd.SelectedValue)).Select(p => (p.TenHD,p.LoaiHD,p.ThoiHan));
            foreach(var i in a)
            {
                tenhd.Text = i.TenHD.ToString();
                loaihd.Text = i.LoaiHD.ToString();
                thoihan.Text = i.ThoiHan.ToString();
            }
        }
    }
}
