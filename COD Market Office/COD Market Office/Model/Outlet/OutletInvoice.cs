using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Outlet
{
    class OutletInvoice
    {
        public long id { get; set; }
        public string name { get; set; }
        public Outlet outlet { get; set; }
        public string outlet_name
        {
            get
            {
                return outlet.nama;
            }
        }
        public long value { get; set; }
        public string value_format
        {
            get
            {
                double price = value;
                return price.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            }
        }
        public string ket { get; set; }
        public string createdAt { get; set; }
        public string expiredAt { get; set; }
    }
}
