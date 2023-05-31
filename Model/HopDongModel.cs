using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class HopDongModel
    {
        private int idHD;
        private string tenHD;
        private string loaiHD;
        private int thoiHan;

        public int IdHD { get => idHD; set => idHD = value; }
        public string TenHD { get => tenHD; set => tenHD = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public int ThoiHan { get => thoiHan; set => thoiHan = value; }

        public HopDongModel(int id,string ten, string loai, int thoihan)
        {
            this.IdHD = id;
            this.TenHD = ten;
            this.loaiHD = loai;
            this.thoiHan = thoihan;
        }
        public HopDongModel() { }
    }

}
