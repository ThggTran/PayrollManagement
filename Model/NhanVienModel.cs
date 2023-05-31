using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class NhanVienModel
    {
        private int idNV;
        private string tenNV;
        private string username;
        private string password;
        private string sdt;
        private string email;
        private string gioiTinh;
        private DateTime ngaySinh;
        private DateTime ngayKyHD;
        private int HSLuong;
        private int LuongCB;
        private string tenCV;
        private string tenTD;
        private string tenPB;
        private int idHD;
        private string tenHD;
        private int phanQuyen;

        public NhanVienModel() { }

        public NhanVienModel(int idNV, string tenNV, string username, string password, string sdt, string email, string gioiTinh, DateTime ngaySinh, DateTime ngayKyHD/*, DateTime ngayHetHD*/, int hSLuong, int luongCB, string tenCV, string tenTD, string tenPB, int idHD,string tenHD,int phanQuyen)
        {
            this.IdNV = idNV;
            this.TenNV = tenNV;
            this.Username = username;
            this.Password = password;
            this.Sdt = sdt;
            this.Email = email;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.NgayKyHD = ngayKyHD;
            //this.NgayHetHD = ngayHetHD;
            this.HSLuong1 = hSLuong;
            this.LuongCB1 = luongCB;
            this.TenCV = tenCV;
            this.TenTD = tenTD;
            this.TenPB = tenPB;
            this.IdHD = idHD;
            this.TenHD = tenHD;
            this.PhanQuyen = phanQuyen;
        }

        public int IdNV { get => idNV; set => idNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayKyHD { get => ngayKyHD; set => ngayKyHD = value; }
        //public DateTime NgayHetHD { get => ngayHetHD; set => ngayHetHD = value; }
        public int HSLuong1 { get => HSLuong; set => HSLuong = value; }
        public int LuongCB1 { get => LuongCB; set => LuongCB = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string TenTD { get => tenTD; set => tenTD = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        public int IdHD { get => idHD; set => idHD = value; }
        public string TenHD { get => tenHD; set => tenHD = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
    }
}
