using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model
{
    public class Kategori
    {
        public long id { get; set; }
        public string nama { get; set; }
        public bool visible { get; set; }
        public string fileName { get; set; }

        public string isVisible { 
            get
            {
                return visible ? "Ya" : "Tidak";
            } 
        }

        public string isImageAvailable
        {
            get
            {
                return fileName == null ? "Tidak" : "Ya";
            }
        }
    }
}
