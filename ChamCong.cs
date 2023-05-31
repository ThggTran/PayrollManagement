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
    public partial class ChamCong : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        readonly SP_ThemNVDataContext db = new SP_ThemNVDataContext();
        List<ChamCongModel> lstCC = new List<ChamCongModel>();
        List<NhanVienModel> lstNV = new List<NhanVienModel>();
        public ChamCong()
        {
            InitializeComponent();
            listNV();
            
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            viewCC();
            getidNV(); 
        }
        void viewCC()
        {
            connection.Open();
            string query = "SELECT * FROM FN_Luong_ALL()";
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
            CCview.Columns[1].Width = 70;
            CCview.Columns[2].HeaderText = "Tên nhân viên";
            CCview.Columns[3].HeaderText = "tháng";
            CCview.Columns[3].Width = 50;
            CCview.Columns[4].HeaderText = "năm";
            CCview.Columns[4].Width = 50;
            CCview.Columns[5].HeaderText = "Lương CB";
            CCview.Columns[5].Width = 100;
            CCview.Columns[6].HeaderText = "Phụ Cấp";
            CCview.Columns[7].HeaderText = "Hệ Số";
            CCview.Columns[7].Width = 70;
            CCview.Columns[8].HeaderText = "Ngày làm việc";
            CCview.Columns[8].Width = 70;
            CCview.Columns[9].HeaderText = "Ngày làm thêm";
            CCview.Columns[9].Width = 70;
            CCview.Columns[10].HeaderText = "Giờ tăng ca";
            CCview.Columns[10].Width = 70;
            CCview.Columns[11].HeaderText = "Đi trễ";
            CCview.Columns[11].Width = 50;
            CCview.Columns[12].HeaderText = "Tổng lương";
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
                                                       Convert.ToInt32( row["phanQuyen"])
                                                        );

                lstNV.Add(a);
            }
            connection.Close();
        }
        void getidNV()
        {
            idnv.ValueMember = "idNV";
            idnv.DataSource = lstNV;
        }

        private string SQL_Error()
        {
            string query = "select dbo.FN_Return_Error()";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        public int Add(int idnv, int thang,int nam, int songaylv, int songaylt, int sogiotc, int solanditre)
        {
            const string query = @"SP_Them_ChamCong @idNV,@thang,@nam,@songaylv,@songaylt,@sogiotc,@solanditre ";
            int data = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@idNV", idnv);
                    command.Parameters.AddWithValue("@thang", thang);
                    command.Parameters.AddWithValue("@nam", nam);
                    command.Parameters.AddWithValue("@songaylv", songaylv);
                    command.Parameters.AddWithValue("@songaylt", songaylt);
                    command.Parameters.AddWithValue("@sogiotc", sogiotc);
                    command.Parameters.AddWithValue("@solanditre", solanditre);
                    data = command.ExecuteNonQuery();
                    return data;
                }
                catch
                {
                    MessageBox.Show(SQL_Error());
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }
        void ThemChamCong(int idnv, int thang,int nam, int songaylv, int songaylt, int sogiotc, int solanditre)
        {
            int status = Add(idnv, thang,nam, songaylv, songaylt, sogiotc, solanditre);
            if (status == 0)
                MessageBox.Show("Thêm thất bại");
            else
                MessageBox.Show("Thêm thành công");
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            ThemChamCong(Convert.ToInt32(idnv.Text), Convert.ToInt32(thang.Text), Convert.ToInt32(nam.Text), Convert.ToInt32(songaylv.Text), Convert.ToInt32(songaylt.Text), Convert.ToInt32(sogiotc.Text), Convert.ToInt32(solanditre.Text));
            viewCC();
        }
        void CapNhatChamCong(int maluong,int thang,int nam,int songaylv,int songaylt,int sogiotc,int solanditre)
        {
            int status = Update(maluong, thang,nam, songaylv, songaylt, sogiotc, solanditre);
            if (status == 0)
                MessageBox.Show("Cập nhật thất bại");
            else
                MessageBox.Show("Cập nhật thành công");
        }
        public int Update(int maluong, int thang,int nam, int songaylv, int songaylt, int sogiotc, int solanditre)
        {
            const string query = @"SP_CapNhat_ChamCong @idLuong,@thang,@nam,@songaylv,@songaylt,@sogiotc,@solanditre ";
            int data = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@idLuong",maluong );
                    command.Parameters.AddWithValue("@thang", thang);
                    command.Parameters.AddWithValue("@nam", nam);
                    command.Parameters.AddWithValue("@songaylv", songaylv);
                    command.Parameters.AddWithValue("@songaylt", songaylt);
                    command.Parameters.AddWithValue("@sogiotc", sogiotc);
                    command.Parameters.AddWithValue("@solanditre", solanditre);
                    data = command.ExecuteNonQuery();
                    return data;
                }
                catch
                {
                    MessageBox.Show(SQL_Error());
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            CapNhatChamCong(Convert.ToInt32(maluong.Text), Convert.ToInt32(thang.Text), Convert.ToInt32(nam.Text), Convert.ToInt32(songaylv.Text), Convert.ToInt32(songaylt.Text), Convert.ToInt32(sogiotc.Text), Convert.ToInt32(solanditre.Text));
            viewCC();
        }
        public int Delete(int maluong)
        {
            const string query = @"SP_Xoa_ChamCong @idLuong ";
            int data = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@idLuong", maluong);
                    data = command.ExecuteNonQuery();
                    return data;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa");
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }
        void XoaNhatChamCong(int maluong)
        {
            int status = Delete(maluong);
            if (status == 0)
                MessageBox.Show("Xóa thất bại");
            else
                MessageBox.Show("Xóa thành công");
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            XoaNhatChamCong(Convert.ToInt32(maluong.Text));
            viewCC();
        }

        private void idnv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var a = lstNV.Where(p => p.IdNV == Convert.ToInt32(idnv.SelectedValue)).Select(p => (p.TenNV,p.NgaySinh));
            foreach(var i in a)
            {
                tennv.Text = i.TenNV.ToString();
                ngaysinh.Text = i.NgaySinh.ToString();
            }
        }

        private void CCview_SelectionChanged(object sender, EventArgs e)
        {
            int i=0;
            i = CCview.CurrentRow.Index;
            maluong.Text = CCview.Rows[i].Cells[0].Value.ToString();
            tennv.Text = CCview.Rows[i].Cells[2].Value.ToString();
            thang.Text = CCview.Rows[i].Cells[3].Value.ToString();
            nam.Text = CCview.Rows[i].Cells[4].Value.ToString();
            songaylv.Text = CCview.Rows[i].Cells[8].Value.ToString();
            songaylt.Text = CCview.Rows[i].Cells[9].Value.ToString();
            sogiotc.Text = CCview.Rows[i].Cells[10].Value.ToString();
            solanditre.Text = CCview.Rows[i].Cells[11].Value.ToString();

        }

       
        public DataTable TimKiem_TenNV(string name)
        {
            connection.Open();
            string query = "select * from FN_ChamCong_Name(N'" + name + "')";
            var cmd = new SqlCommand(query, connection);
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        private void tbx_nv_TextChanged(object sender, EventArgs e)
        {
            if (tbx_nv.Text == "")
                viewCC();
            else
            {
                CCview.DataSource = TimKiem_TenNV(tbx_nv.Text);
            }    
        }

        private void maluong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
