using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class ChucVuModel
    {
        private int idCV;
        private string tenCV;

        public int IdCV { get => idCV; set => idCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }

        public ChucVuModel(int id,string ten)
        {
            this.IdCV = id;
            this.TenCV = ten;
        }
        public ChucVuModel() { }

    }
}
