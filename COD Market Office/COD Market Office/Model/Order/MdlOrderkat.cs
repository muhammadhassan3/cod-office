using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Order
{
    public class MdlOrderkat
    {
        public bool isSelected { get; set; }
        public long id { get; set; }
        public string noOrder { get; set; }
        public User user { get; set; }
        public string user_name
        {
            get
            {
                return user.nama;
            }
        }
        public double latKirim { get; set; }
        public double lngKirim { get; set; }
        public string createdAt { get; set; }
        public string alamat { get; set; }
        public PaymentMethod metode { get; set; }
        public string metode_name
        {
            get
            {
                return metode.metodeName;
            }
        }
    }
}
