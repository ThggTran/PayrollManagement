using PayrollManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagement
{
    public partial class formThem : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        readonly SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<ChucVuModel> lstCV = new List<ChucVuModel>();
        List<TrinhDoModel> lstTD = new List<TrinhDoModel>();
        List<PhongBanModel> lstPB = new List<PhongBanModel>();
        List<HopDongModel> lstHD = new List<HopDongModel>();
        List<NhanVienModel> lstNV = new List<NhanVienModel>();
        public formThem()
        {
            InitializeComponent();
            ListCV();
            ListTD();
            ListHD();
            ListPB();
            ListNV();
        }

        private void formThem_Load(object sender, EventArgs e)
        {
            showCV();
            showTD();
            showPB();
            showHD();            
        }

        private void themnvBtn_Click(object sender, EventArgs e)
        {
            try
            {
               // var insert = db.SP_Them_NhanVien(tenTxt.Text, usernameTxt.Text, passTxt.Text, sdtTxt.Text, emailTxt.Text, gioitinhTxt.Text, Convert.ToDateTime(dateTxt.Text), Convert.ToDateTime(kyhdTxt.Text), double.Parse(hslTxt.Text), double.Parse(luongcbTxt.Text), Convert.ToInt32(tenchucvuTxt.Text), Convert.ToInt32(tenpbTxt.Text), Convert.ToInt32(tentrinhdoTxt.Text), Convert.ToInt32(tenhdTxt.Text), Convert.ToInt32(pqTxt.Text));
                var insert = db.SP_Them_NhanVien(tenTxt.Text, usernameTxt.Text, passTxt.Text, sdtTxt.Text, emailTxt.Text, gioitinhTxt.Text, Convert.ToDateTime(dateTxt.Text), Convert.ToDateTime(kyhdTxt.Text), double.Parse(hslTxt.Text), double.Parse(luongcbTxt.Text), Convert.ToInt32(tenchucvuTxt.Text), Convert.ToInt32(tenpbTxt.Text), Convert.ToInt32(tentrinhdoTxt.Text), Convert.ToInt32(hopdongTxt.Text), Convert.ToInt32(pqTxt.Text));
                MessageBox.Show("successfull");
            }
            catch
            {
                MessageBox.Show(SQL_Error());
            }
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
        private void showHD()
        {

            hopdongTxt.ValueMember = "idHD";
            hopdongTxt.DataSource = lstHD;

        }
       
        public void ListNV()
        {
            connection.Open();
            string query = "SELECT * FROM V_NhanVien";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                NhanVienModel a = new NhanVienModel(Convert.ToInt32(row["idNV"]),
                                                        row["tenNV"].ToString(),
                                                        row["username"].ToString(),
                                                        row["password"].ToString(),
                                                        row["sdt"].ToString(),
                                                        row["email"].ToString(),
                                                        row["gioiTinh"].ToString(),
                                                        Convert.ToDateTime(row["ngaySinh"]),
                                                        Convert.ToDateTime(row["ngayKyHD"]),
                                                        //Convert.ToDateTime(row["ngayHetHD"]),
                                                        Convert.ToInt32(row["HSLuong"]),
                                                        Convert.ToInt32(row["LuongCB"]),
                                                        row["tenCV"].ToString(),
                                                        row["tenTD"].ToString(),
                                                        row["tenPB"].ToString(),
                                                        Convert.ToInt32(row["idHD"]),
                                                        row["tenHD"].ToString(),
                                                        Convert.ToInt32(row["phanQuyen"]));

                lstNV.Add(a);
            }
            connection.Close();
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
                //HopDongModel a = new HopDongModel(Convert.ToInt32(row["idHD"]),
                //row["tenHD"].ToString());
                HopDongModel a = new HopDongModel(Convert.ToInt32(row["idHD"]),
                                                    row["tenHD"].ToString(),
                                                    row["loaiHD"].ToString(),
                                                    Convert.ToInt32(row["thoiHan"]));
                lstHD.Add(a);
            }
            connection.Close();
        }

        private void chucvuTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstCV.Where(p => p.TenCV == chucvuTxt.SelectedValue.ToString()).Select(p => p.IdCV);
            int id = Convert.ToInt32(a.FirstOrDefault().ToString());
            connection.Open();
            string query = "select dbo.FN_HSL(" + id.ToString() + ")";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            tenchucvuTxt.Text = id.ToString();
            hslTxt.Text = dt.Rows[0][0].ToString();
        }

        private void trinhdoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstTD.Where(p => p.TenTD == trinhdoTxt.SelectedValue.ToString()).Select(p => p.IdTD);
            tentrinhdoTxt.Text = a.FirstOrDefault().ToString();
        }

        private void pbTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lstPB.Where(p => p.TenPB == pbTxt.SelectedValue.ToString()).Select(p => p.IdPB);
            tenpbTxt.Text = a.FirstOrDefault().ToString();
        }

        private void hopdongTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var a = lstHD.Where(p => p.TenHD == hopdongTxt.SelectedValue.ToString()).Select(p => p.IdHD);
            // tenhdTxt.Text = a.FirstOrDefault().ToString();
            var a = lstHD.Where(p => p.IdHD == Convert.ToInt32(hopdongTxt.SelectedValue)).Select(p => p);
            foreach (var i in a)
            {
                richDesHDNVtxt.Text = "Tên HĐ: " + i.TenHD.ToString() + " \nThời hạn: " + i.ThoiHan.ToString() + " " + i.LoaiHD.ToString();
            }
        }

       

        private void exitFormNVbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

