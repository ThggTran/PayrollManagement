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

    public partial class TrangChu : Form
    {


        public TrangChu()
        {
            InitializeComponent();

        }
        void changeColor(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.BackColor = Color.PeachPuff;
                c.ForeColor = Color.LightSeaGreen;
            }
            Control click = (Control)sender;
            click.BackColor = Color.LightSeaGreen;
            click.ForeColor = Color.PeachPuff;
        }

        private void nhanvienBtn_Click(object sender, EventArgs e)
        {

            trangchuPanel.Controls.Clear();
            var i = new NhanVien();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(nhanvienBtn, null);
        }

        private void qlpbBtn_Click(object sender, EventArgs e)
        {

            trangchuPanel.Controls.Clear();
            var i = new PhongBan();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlpbBtn, null);
        }

        private void qlcvBtn_Click(object sender, EventArgs e)
        {

            trangchuPanel.Controls.Clear();
            var i = new ChucVu();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlcvBtn, null);
        }

        private void qlccBtn_Click(object sender, EventArgs e)
        {
            trangchuPanel.Controls.Clear();
            var i = new ChamCong();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlccBtn, null);
        }

        private void qltdBtn_Click(object sender, EventArgs e)
        {
            trangchuPanel.Controls.Clear();
            var i = new TrinhDo();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qltdBtn, null);
        }

        private void qlhdBtn_Click(object sender, EventArgs e)
        {
            trangchuPanel.Controls.Clear();
            var i = new HopDong();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlhdBtn, null);
        }

        private void qlhslBtn_Click(object sender, EventArgs e)
        {
            trangchuPanel.Controls.Clear();
            var i = new HSLuong();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlhslBtn, null);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }
        public static string type;
        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (type == "User")
            {
                nhanvienBtn.Visible = false;
                qlpbBtn.Visible = false;

                qlcvBtn.Visible = false;
                qlhdBtn.Visible = false;
                qlhslBtn.Visible = false;
                qlblBtn.Visible = true;

                qltdBtn.Visible = false;
                qlccBtn.Visible = false;
            }
            else if (type == "Admin")
            {
                nhanvienBtn.Visible = true;
                qlpbBtn.Visible = true;
                qlcvBtn.Visible = true;
                qlhdBtn.Visible = true;
                qlhslBtn.Visible = true;

                qlblBtn.Visible = true;
                qltdBtn.Visible = true;
                qlccBtn.Visible = true;
            }
        }

        private void qlblBtn_Click(object sender, EventArgs e)
        {
            trangchuPanel.Controls.Clear();
            var i = new BangLuong();
            i.TopLevel = false;
            trangchuPanel.Controls.Add(i);
            i.Show();
            changeColor(qlblBtn, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
