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
    public partial class formNhanvienLogin : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        List<ChucVuModel> lstCV = new List<ChucVuModel>();
        List<TrinhDoModel> lstTD = new List<TrinhDoModel>();
        List<PhongBanModel> lstPB = new List<PhongBanModel>();
        List<HopDongModel> lstHD = new List<HopDongModel>();
        List<NhanVienModel> lstNV = new List<NhanVienModel>();
        int idNhanVien;
        public formNhanvienLogin(int idNV)
        {
            InitializeComponent();
            this.idNhanVien = idNV;
            ListCV();
            ListTD();
            ListHD();
            ListPB();
            ListNV();
        }

        private void formNhanvienLogin_Load(object sender, EventArgs e)
        {
            //showCV();
            //showTD();
            //showPB();
            //showHD();
            //showID();
            //ListHD();
            //getID.Text = idNhanVien.ToString();
            var a = lstNV.Where(p => p.IdNV == idNhanVien).Select(p => p);
            var b = lstHD.Where(p => p.IdHD == idNhanVien).Select(p => p);
            foreach (var i in a)
            {
                pqTxt.Text = i.PhanQuyen.ToString();
                tenTxt.Text = i.TenNV.ToString();                
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
                trinhdoTxt.Text = i.TenTD.ToString();                
                pbTxt.Text = i.TenPB.ToString();                
                hopdongTxt.Text = i.IdHD.ToString();
                getID.Text = i.IdNV.ToString();
            }
            foreach (var i in b)
            {
                RichDesHDNVtxt.Text = "Tên HĐ: " + i.TenHD.ToString() + " \nThời hạn: " + i.ThoiHan.ToString() + " " + i.LoaiHD.ToString();
            }
            viewCC();
        }
        void viewCC()
        {
            connection.Open();
            string query = "SELECT * FROM FN_ThongKe_Luong_theo_NhanVien("+idNhanVien.ToString()+")";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            CCview.DataSource = dt;
            Set_Column();
        }
        private void Set_Column()
        {
            CCview.Columns[0].HeaderText = "ID Lương";
            CCview.Columns[0].Width = 50;
            CCview.Columns[1].HeaderText = "ID Nhân viên";
            CCview.Columns[1].Width = 50;
            CCview.Columns[2].HeaderText = "Tên nhân viên";
            CCview.Columns[2].Width = 90;
            CCview.Columns[3].HeaderText = "tháng";
            CCview.Columns[3].Width = 50;
            CCview.Columns[4].HeaderText = "năm";
            CCview.Columns[4].Width = 50;
            CCview.Columns[5].HeaderText = "Lương CB";
            CCview.Columns[5].Width = 70;
            CCview.Columns[6].HeaderText = "Hệ Số";
            CCview.Columns[6].Width = 50;
            CCview.Columns[7].HeaderText = "Ngày làm việc";
            CCview.Columns[7].Width = 70;
            CCview.Columns[8].HeaderText = "Tăng ca ngày";
            CCview.Columns[8].Width = 70;
            CCview.Columns[9].HeaderText = "Tăng ca giờ";
            CCview.Columns[9].Width = 70;
            CCview.Columns[10].HeaderText = "Tiền trừ";
            CCview.Columns[10].Width = 50;
            CCview.Columns[11].HeaderText = "Tạm tính";
            CCview.Columns[11].Width = 80;
            CCview.Columns[12].HeaderText = "Phụ cấp";
            CCview.Columns[12].Width = 70;
            CCview.Columns[13].HeaderText = "Chính thức";
            // CCview.Columns[13].Width = 50;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
