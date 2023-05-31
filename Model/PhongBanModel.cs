using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class PhongBanModel
    {
        private int idPB;
        private string tenPB;

        public int IdPB { get => idPB; set => idPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }

        public PhongBanModel(int id,string ten)
        {
            this.IdPB = id;
            this.TenPB = ten;
        }
        public PhongBanModel() { }
    }
}
