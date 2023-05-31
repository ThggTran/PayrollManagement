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
    public partial class PhongBan : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<PhongBanModel> lstPB = new List<PhongBanModel>();
        public PhongBan()
        {
            InitializeComponent();
            //ListPB();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            viewPB();
            getidPB();
        }
        void viewPB()
        {
            ViewPB.DataSource = ListPB();
            SetColumn();
        }
        void SetColumn()
        {
            ViewPB.Columns[1].Width = 150;
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
        public DataTable ListPB()
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
            return dt;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var insert = db.SP_Them_PB(tenpb.Text.ToString());
                
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show(SQL_Error());
            }
            viewPB();
        }
        
        void getidPB()
        {
            idpb.ValueMember = "idPB";
            idpb.DataSource = lstPB;

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var update = db.SP_CapNhat_PB(Convert.ToInt32(idpb.Text),tenpb.Text.ToString());
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show(SQL_Error());
            }
            
        }

        private void idpb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstPB.Where(p => p.IdPB == Convert.ToInt32(idpb.SelectedValue)).Select(p => p.TenPB);
            tenpb.Text = a.FirstOrDefault().ToString();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var del = db.SP_Xoa_PB(Convert.ToInt32(idpb.Text));
                
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show("failed");

            }
            
        }

        private void ViewPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.ViewPB.Rows[e.RowIndex];
                tenpb.Text = row.Cells[1].Value.ToString();
                idpb.Text = row.Cells[0].Value.ToString();
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchPBTxt.Text == "")
            {
                viewPB();
            }
            else
            {
                ViewPB.DataSource = TimKiem_TenPB(searchPBTxt.Text);
            }
        }
        public DataTable TimKiem_TenPB(string name)
        {
            connection.Open(); 
            string query = "select * from FN_PhongBan_Name(N'" + name + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        private void idpb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
