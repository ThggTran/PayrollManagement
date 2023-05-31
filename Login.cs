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
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        
        public Login()
        {
            InitializeComponent();
            AcceptButton = loginBtn;
        }

        



        private void loginBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SP_Login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@username", userTxt.Text);
            cmd.Parameters.AddWithValue("@password", passTxt.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                if (rd[16].ToString() == "0")
                {
                    TrangChu.type = "Admin";
                    this.Hide();
                    var f1 = new TrangChu();
                    f1.Show();
                }
                else if (rd[16].ToString() == "1")
                {
                    this.Hide();
                    int idnv = Convert.ToInt32(rd[0].ToString());
                    var f2 = new formNhanvienLogin(idnv);
                    f2.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
            }
            connection.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
