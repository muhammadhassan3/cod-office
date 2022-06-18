using COD_Market_Office.Model.ItemList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Stock
{
    public class Stock
    {
        public long id { get; set; }
        public MdlItem item { get; set; }
        public long hargaJual { get; set; }
        public long grosirDiskon { get; set; }
        public int stock { get; set; }

    }
}
