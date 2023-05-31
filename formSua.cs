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
    public partial class formSua : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        readonly SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<ChucVuModel> lstCV = new List<ChucVuModel>();
        List<TrinhDoModel> lstTD = new List<TrinhDoModel>();
        List<PhongBanModel> lstPB = new List<PhongBanModel>();
        List<HopDongModel> lstHD = new List<HopDongModel>();
        List<NhanVienModel> lstNV = new List<NhanVienModel>();
        int idNhanVien;
        public formSua(int idNV)
        {
            InitializeComponent();
            this.idNhanVien = idNV;
            ListCV();
            ListTD();
            ListHD();
            ListPB();
            ListNV();            
        }
       
        private void themnvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var insert = db.SP_Them_NhanVien(tenTxt.Text, usernameTxt.Text, passTxt.Text, sdtTxt.Text, emailTxt.Text, gioitinhTxt.Text, Convert.ToDateTime(dateTxt.Text), Convert.ToDateTime(kyhdTxt.Text), double.Parse(hslTxt.Text), double.Parse(luongcbTxt.Text), Convert.ToInt32(tenchucvuTxt.Text), Convert.ToInt32(tenpbTxt.Text), Convert.ToInt32(tentrinhdoTxt.Text), Convert.ToInt32(hopdongTxt.Text), Convert.ToInt32(pqTxt.Text));
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
                var update = db.SP_CapNhat_NhanVien(Convert.ToInt32(getID.Text), tenTxt.Text, usernameTxt.Text, passTxt.Text, sdtTxt.Text, emailTxt.Text, gioitinhTxt.Text, Convert.ToDateTime(dateTxt.Text), Convert.ToDateTime(kyhdTxt.Text), double.Parse(hslTxt.Text), double.Parse(luongcbTxt.Text), Convert.ToInt32(tenchucvuTxt.Text), Convert.ToInt32(tenpbTxt.Text), Convert.ToInt32(tentrinhdoTxt.Text), Convert.ToInt32(hopdongTxt.Text), Convert.ToInt32(pqTxt.Text));
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

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            showCV();
            showTD();
            showPB();
            showHD();
            showID();
            ListHD();
            getID.Text = idNhanVien.ToString();
            getID_SelectionChangeCommitted(sender, e);
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

            connection.Open();
            //  string query = "SELECT idHD FROM NHANVIEN where idNV=" + idNhanVien.ToString();
            string query = "SELECT * FROM NHANVIEN where idNV=" + idNhanVien.ToString();
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            hopdongTxt.Text = dt.Rows[0][0].ToString();
            hopdongTxt.ValueMember = "idHD";
            hopdongTxt.DataSource = lstHD;
        }
        private void showID()
        {
            
            getID.ValueMember = "idNV";
            getID.DataSource = lstNV;
            
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
                HopDongModel a = new HopDongModel(Convert.ToInt32(row["idHD"]), 
                                                    row["tenHD"].ToString(),
                                                    row["loaiHD"].ToString(),
                                                    Convert.ToInt32(row["thoiHan"]));
                lstHD.Add(a);
            }
            connection.Close();
            RichDesHDNVtxt.Text = "Tên HĐ: " + dt.Rows[0][1].ToString() + " \nThời hạn: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][2].ToString();
        }
        
        private void chucvuTxt_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void trinhdoTxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstTD.Where(p => p.TenTD == trinhdoTxt.SelectedValue.ToString()).Select(p => p.IdTD);
            tentrinhdoTxt.Text = a.FirstOrDefault().ToString();
        }

        private void pbTxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstPB.Where(p => p.TenPB == pbTxt.SelectedValue.ToString()).Select(p => p.IdPB);
            tenpbTxt.Text = a.FirstOrDefault().ToString();
        }       
        
        private void getID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstNV.Where(p => p.IdNV == Convert.ToInt32(getID.SelectedValue)).Select(p => p);
            var b = lstHD.Where(p => p.IdHD == Convert.ToInt32(getID.SelectedValue)).Select(p => p);
            foreach (var i in a)
            {
                pqTxt.Text = i.PhanQuyen.ToString();
                tenTxt.Text = i.TenNV.ToString();
                tenHeadtxt.Text = i.TenNV.ToString();
                sdtTxt.Text = i.Sdt.ToString();
                emailTxt.Text = i.Email.ToString();
                usernameTxt.Text = i.Username.ToString();
                passTxt.Text = i.Password.ToString();
                gioitinhTxt.Text = i.GioiTinh.ToString();
                dateTxt.Text = i.NgaySinh.ToString();
                kyhdTxt.Text = i.NgayKyHD.ToString();
                hslTxt.Text = i.HSLuong1.ToString();
                luongcbTxt.Text = i.LuongCB1.ToString();
                chucvuTxt.Text = i.TenCV.ToString();
                chucvuTxt_SelectionChangeCommitted(sender, e);
                trinhdoTxt.Text = i.TenTD.ToString();
                trinhdoTxt_SelectionChangeCommitted(sender, e);
                pbTxt.Text = i.TenPB.ToString();
                pbTxt_SelectionChangeCommitted(sender, e);
                hopdongTxt.Text = i.IdHD.ToString();
            }
            foreach (var i in b)
            {
                RichDesHDNVtxt.Text = "Tên HĐ: " + i.TenHD.ToString() + " \nThời hạn: " + i.ThoiHan.ToString() + " " + i.LoaiHD.ToString();
            }
        }

        private void exitFrmEditNVbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hopdongTxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstHD.Where(p => p.IdHD == Convert.ToInt32(hopdongTxt.SelectedValue)).Select(p => p);
            foreach (var i in a)
            {
                RichDesHDNVtxt.Text = "Tên HĐ: " + i.TenHD.ToString() + " \nThời hạn: " + i.ThoiHan.ToString() + " " + i.LoaiHD.ToString();
            }
        }
    }
}
