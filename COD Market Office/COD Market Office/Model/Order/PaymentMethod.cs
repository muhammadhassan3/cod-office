using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Order
{
    public class PaymentMethod
    {
        public long metodeId { get; set; }
        public string metodeName { get; set; }
        public string metodeKeterangan { get; set; }
    }
}
