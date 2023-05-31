using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Model
{
    class TrinhDoModel
    {
        private int idTD;
        private string tenTD;

        public int IdTD { get => idTD; set => idTD = value; }
        public string TenTD { get => tenTD; set => tenTD = value; }

        public TrinhDoModel(int id, string ten)
        {
            this.IdTD = id;
            this.TenTD = ten;
        }
        public TrinhDoModel() { }
    }
}
