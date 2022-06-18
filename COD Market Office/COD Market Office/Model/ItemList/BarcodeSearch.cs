using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.ItemList
{
    public class BarcodeSearch
    {
        public MdlItem kat { get; set; }
        public MdlItem merek { get; set; }
        public MdlItem item { get; set; }

        public long item_id
        {
            get
            {
                return item.id;
            }
        }

        public string item_nama
        {
            get
            {
                return item.nama;
            }
        }

        public string item_barcode
        {
            get
            {
                return item.barcode;
            }
        }
    }
}
