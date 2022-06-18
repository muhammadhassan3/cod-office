using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model
{
    public class UserKaryawan
    {
        public User owner { get; set; }
        public List<Outlet.Outlet> list { get; set; }
        public Grant.Type jabatan { get; set; }
        public string createdAt { get; set; }
        public bool enabled { get; set; }
    }
}
