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
    public partial class TrinhDo : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<TrinhDoModel> lstTD = new List<TrinhDoModel>();
        public TrinhDo()
        {
            InitializeComponent();
            ListTD();
        }
        private string SQL_Error()
        {
            connection.Open();
            string query = "select dbo.FN_Return_Error()";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt.Rows[0][0].ToString();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var add = db.SP_Them_TD(tentd.Text.ToString());
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show(SQL_Error());
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var del = db.SP_Xoa_TD(Convert.ToInt32(idtd.Text));
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
                var update = db.SP_CapNhat_TD(Convert.ToInt32(idtd.Text), tentd.Text.ToString());
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show(SQL_Error());
            }
        }
        void viewTD()
        {
            ViewTD.DataSource = lstTD;
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
        void getidCV()
        {
            idtd.ValueMember = "idTD";
            idtd.DataSource = lstTD;

        }

        private void idtd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstTD.Where(p => p.IdTD == Convert.ToInt32(idtd.SelectedValue)).Select(p => p.TenTD);
            tentd.Text = a.FirstOrDefault().ToString();
        }

        private void TrinhDo_Load(object sender, EventArgs e)
        {
            getidCV();
            viewTD();
        }
    }
}
