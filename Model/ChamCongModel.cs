using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class ChamCongModel
    {
        private int idLuong;
        private int idNV;
        private int thang;
        private int SoNgayLamViec;
        private int SoNgayLamThem;
        private int SoGioTangCa;
        private int SoLanDiTre;
        private int nam;
        public ChamCongModel() { }
        public ChamCongModel(int idLuong, int idNV, int thang,int nam, int soNgayLamViec, int soNgayLamThem, int soGioTangCa, int soLanDiTre)
        {
            this.IdLuong = idLuong;
            this.IdNV = idNV;
            this.Thang = thang;
            this.Nam = nam;
            SoNgayLamViec1 = soNgayLamViec;
            SoNgayLamThem1 = soNgayLamThem;
            SoGioTangCa1 = soGioTangCa;
            SoLanDiTre1 = soLanDiTre;
        }

        public int IdLuong { get => idLuong; set => idLuong = value; }
        public int IdNV { get => idNV; set => idNV = value; }
        public int Thang { get => thang; set => thang = value; }
        public int SoNgayLamViec1 { get => SoNgayLamViec; set => SoNgayLamViec = value; }
        public int SoNgayLamThem1 { get => SoNgayLamThem; set => SoNgayLamThem = value; }
        public int SoGioTangCa1 { get => SoGioTangCa; set => SoGioTangCa = value; }
        public int SoLanDiTre1 { get => SoLanDiTre; set => SoLanDiTre = value; }
        public int Nam { get => nam; set => nam = value; }
    }
}
