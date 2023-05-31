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

namespace PayrollManagement
{
    public partial class HSLuong : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public HSLuong()
        {
            InitializeComponent();
        }

        private void HSLuong_Load(object sender, EventArgs e)
        {
            LoadHSL();
        }
        public void LoadHSL()
        {
            connection.Open();
            string query = "SELECT * FROM V_HeSoLuong";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            gv_HSL.DataSource = dt;
        }
    }
}
