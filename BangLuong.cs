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
    public partial class BangLuong : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        List<NhanVienModel> lstNV = new List<NhanVienModel>();
        List<ChamCongModel> lstCC = new List<ChamCongModel>();
        public BangLuong()
        {
            InitializeComponent();
            listNV();
            listCC();
            

        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            getidNV();
            viewCC();
        }
        void viewCC()
        {
            connection.Open();
            string query = "SELECT * FROM FN_ThongKe_Luong_ALL()";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            CCview.DataSource = dt;
            //Set_Column();
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

        public void listNV()
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
        void getidNV()
        {
            idnv.ValueMember = "idNV";
            idnv.DataSource = lstNV;
        }
        public void listCC()
        {
            connection.Open();
            string query = "SELECT * FROM V_ChamCong";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ChamCongModel a = new ChamCongModel(Convert.ToInt32(row["idLuong"]),
                                                    Convert.ToInt32(row["idNV"]),
                                                    Convert.ToInt32(row["thang"]),
                                                    Convert.ToInt32(row["nam"]),
                                                    Convert.ToInt32(row["SoNgayLamViec"]),
                                                    Convert.ToInt32(row["SoNgayLamThem"]),
                                                    Convert.ToInt32(row["SoGioTangCa"]),
                                                    Convert.ToInt32(row["SoLanDiTre"])
                                                        );

                lstCC.Add(a);
            }
            connection.Close();
        }
        private void idnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM FN_ThongKe_Luong_theo_NhanVien("+idnv.Text+")";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            CCview.DataSource = dt;
            Set_Column();
        }

        private void tennv_TextChanged(object sender, EventArgs e)
        {
            if (tennv.Text == "")
                viewCC();
            else
            {
                CCview.DataSource = TimKiem_TenNV(tennv.Text);
            }    
        }
        public DataTable TimKiem_TenNV(string name)
        {
            connection.Open();
            string query = "select * from FN_ThongKe_Name(N'" + name + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        private void btn_tatca_Click(object sender, EventArgs e)
        {
            idnv.Text = "";
            thang.Text = "";
            nam.Text = "";
            viewCC();
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM FN_ThongKe_Luong_thang(" + thang.Text + ")";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            CCview.DataSource = dt;
            Set_Column();
        }

        private void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM FN_ThongKe_Luong_nam(" + nam.Text + ")";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            CCview.DataSource = dt;
            Set_Column();
        }

       

       

        private void CCview_SelectionChanged(object sender, EventArgs e)
        {
            int i;
            i = CCview.CurrentRow.Index;
            int idLuong = Convert.ToInt32(CCview.Rows[i].Cells[0].Value.ToString());
            var cc = lstCC.Where(p => p.IdLuong == idLuong).Select(p => p);
            songaylv.Text = cc.FirstOrDefault().SoNgayLamViec1.ToString();
            songaylt.Text = cc.FirstOrDefault().SoNgayLamThem1.ToString();
            solanditre.Text = cc.FirstOrDefault().SoLanDiTre1.ToString();
            sogiotc.Text = cc.FirstOrDefault().SoGioTangCa1.ToString();
        }
    }
}
