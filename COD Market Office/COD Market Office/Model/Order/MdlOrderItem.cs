using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COD_Market_Office.Model.Stock;

namespace COD_Market_Office.Model.Order
{
    public class MdlOrderItem
    {
        public long id { get; set; }
        public List<ItemOrder> item { get;set; }
        public long ongkir;
        public double jarak;
    }
}
