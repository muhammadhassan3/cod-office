using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Outlet
{
    public class Outlet
    {
        public long id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public Area kab { get; set; }
        public string kab_name { get
            {
                return kab.nama;
            }
        }
        public Area prov { get; set; }
        public string prov_name { get {
                return prov.nama;
            } }
        public string telp { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string email { get; set; }
        public bool shop { get; set; }
        public string isShop { get
            {
                return shop ? "Ya" : "Tidak";
            }
        }
        public bool open { get; set; }
        public string isOpen { get
            {
                return open ? "Ya" : "Tidak";
            } }
        public string key { get; set; }
        public string value { get; set; }
        public bool visible { get; set; }
        public string isVisible
        {
            get
            {
                return visible ? "Ya" : "Tidak";
            }
        }
    }
}
