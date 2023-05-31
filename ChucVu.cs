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
    public partial class ChucVu : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<ChucVuModel> lstCV = new List<ChucVuModel>();
        public ChucVu()
        {
            InitializeComponent();
            ListCV();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            viewPB();
            getidCV();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var add = db.SP_Them_CV( tencv.Text.ToString());
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
                var del = db.SP_Xoa_CV(Convert.ToInt32(idcv.Text));
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var update = db.SP_CapNhat_CV(Convert.ToInt32(idcv.Text), tencv.Text.ToString());
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }
        void viewPB()
        {
            ViewCV.DataSource = lstCV;
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
        void getidCV()
        {
            idcv.ValueMember = "idCV";
            idcv.DataSource = lstCV;

        }
        private void idcv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstCV.Where(p => p.IdCV == Convert.ToInt32(idcv.SelectedValue)).Select(p => p.TenCV);
            tencv.Text = a.FirstOrDefault().ToString();
        }
    }
}
