using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Order
{
    public class ItemOrder
    {
        public int jumlah { get; set; }
        public long hargaAwal { get; set; }
        public string hargaAwal_format
        {
            get
            {
                return hargaAwal.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            }
        }
        public long hargaTotal { get; set; }
        public string hargaTotal_format
        {
            get
            {
                return hargaTotal.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            }
        }
        public Stock.Stock item { get; set; }
        public string item_name
        {
            get
            {
                return item.item.nama;
            }
        }
    }
}
