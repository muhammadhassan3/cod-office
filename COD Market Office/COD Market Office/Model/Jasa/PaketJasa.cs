using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Jasa
{
    class PaketJasa
    {
        public long id { get; set; }
        public string nama { get; set; }
        public int jmlImg { get; set; }
        public long jmlViews { get; set; }
        public bool visible { get; set; }
        public long harga { get; set; }
        public int extra { get; set; }
    }
}
