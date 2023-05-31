using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class HDModel
    {
        private int idHD;
        private string tenHD;
        private string loaiHD;
        private int thoiHan;

        public HDModel() { }
        public HDModel(int idHD, string tenHD, string loaiHD, int thoiHan)
        {
            this.idHD = idHD;
            this.tenHD = tenHD;
            this.loaiHD = loaiHD;
            this.thoiHan = thoiHan;
        }

        public int IdHD { get => idHD; set => idHD = value; }
        public string TenHD { get => tenHD; set => tenHD = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public int ThoiHan { get => thoiHan; set => thoiHan = value; }
    }
}
